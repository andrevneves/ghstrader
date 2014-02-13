using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.Threading;
using System.Linq;
using System.IO;
using Model;
using API;

namespace BTCTrade
{
    public partial class SellForm : DockContent
    {
        public SellForm()
        {
            InitializeComponent();
        }

        public string Timestamp
        {
            get;
            set;
        }

        public TradeMain MainForm
        {
            get;
            set;
        }

        private void GridBind()
        {
            try
            {
                OrderModel order = MainForm.Order;

                if (order == null
                    || order.timestamp == Timestamp)
                    return;

                Timestamp = order.timestamp;

                if (order != null && order.asks != null)
                {
                    if (gridSellOrder.Rows.Count == 0)
                    {
                        decimal totalAmount = 0m;
                        decimal totalBTC = 0m;

                        int numAdd = 0;

                        for (int i = 0; i < numRow + numAdd && numRow + numAdd < order.asks.Count; i++)
                        {
                            totalAmount += order.asks[i][1];
                            totalBTC += (order.asks[i][0] * order.asks[i][1]);

                            if (order.asks[i][1] < numGHS.Value)
                            {
                                numAdd++;
                                continue;
                            }


                            int index = gridSellOrder.Rows.Add();
                            gridSellOrder.Rows[index].Cells["Price"].Value = order.asks[i][0].ToString("f8");
                            gridSellOrder.Rows[index].Cells["Amount"].Value = order.asks[i][1].ToString("f8");
                            gridSellOrder.Rows[index].Cells["TotalAmount"].Value = totalAmount.ToString("f8");
                            gridSellOrder.Rows[index].Cells["BTC"].Value = (order.asks[i][0] * order.asks[i][1]).ToString("f8");
                            gridSellOrder.Rows[index].Cells["TotalBTC"].Value = totalBTC.ToString("f8");
                            gridSellOrder.Rows[index].Cells["AvgBTC"].Value = (totalBTC / totalAmount).ToString("f8");
                        }
                    }
                    else
                    {
                        dt.Rows.Clear();

                        decimal totalAmount = 0m;
                        decimal totalBTC = 0m;
                        int numAdd = 0;

                        for (int i = 0; i < numRow + numAdd && numRow + numAdd < order.asks.Count; i++)
                        {
                            totalAmount += order.asks[i][1];
                            totalBTC += (order.asks[i][0] * order.asks[i][1]);

                            if (order.asks[i][1] < numGHS.Value)
                            {
                                numAdd++;
                                continue;
                            }

                            DataRow dr = dt.NewRow();
                            dt.Rows.Add(dr);

                            dr["Price"] = order.asks[i][0].ToString("f8");
                            dr["Amount"] = order.asks[i][1].ToString("f8");
                            dr["TotalAmount"] = totalAmount.ToString("f8");
                            dr["BTC"] = (order.asks[i][0] * order.asks[i][1]).ToString("f8");
                            dr["TotalBTC"] = totalBTC.ToString("f8");
                            dr["AvgBTC"] = (totalBTC / totalAmount).ToString("f8");
                        }

                        int nowIndex = -1;

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            var q = from e in gridSellOrder.Rows.Cast<DataGridViewRow>()
                                    where e.Cells["Price"].Value.ToString() == dt.Rows[i]["Price"].ToString()
                                    select e;

                            if (q.Count() == 1)
                            {
                                DataGridViewRow dr = q.SingleOrDefault();
                                nowIndex = dr.Index;

                                dr.Cells["Price"].Value = dt.Rows[i]["Price"];
                                dr.Cells["Amount"].Value = dt.Rows[i]["Amount"];
                                dr.Cells["TotalAmount"].Value = dt.Rows[i]["TotalAmount"];
                                dr.Cells["BTC"].Value = dt.Rows[i]["BTC"];
                                dr.Cells["TotalBTC"].Value = dt.Rows[i]["TotalBTC"];
                                dr.Cells["AvgBTC"].Value = dt.Rows[i]["AvgBTC"];
                            }
                            else
                            {
                                nowIndex++;
                                if (nowIndex >= (this.gridSellOrder.Rows.Count - 1))
                                {
                                    nowIndex = this.gridSellOrder.Rows.Add();
                                }
                                else
                                {
                                    gridSellOrder.Rows.Insert(nowIndex, 1);
                                }
                                gridSellOrder.Rows[nowIndex].Cells["Price"].Value = dt.Rows[i]["Price"];
                                gridSellOrder.Rows[nowIndex].Cells["Amount"].Value = dt.Rows[i]["Amount"];
                                gridSellOrder.Rows[nowIndex].Cells["TotalAmount"].Value = dt.Rows[i]["TotalAmount"];
                                gridSellOrder.Rows[nowIndex].Cells["BTC"].Value = dt.Rows[i]["BTC"];
                                gridSellOrder.Rows[nowIndex].Cells["TotalBTC"].Value = dt.Rows[i]["TotalBTC"];
                                gridSellOrder.Rows[nowIndex].Cells["AvgBTC"].Value = dt.Rows[i]["AvgBTC"];

                            }
                        }

                        for (int i = gridSellOrder.Rows.Count - 1; i >= 0; i--)
                        {
                            var q = from e in dt.AsEnumerable()
                                    where e["Price"].ToString() == gridSellOrder.Rows[i].Cells["Price"].Value.ToString()
                                    select e;

                            if (q.Count() <= 0)
                                gridSellOrder.Rows.RemoveAt(i);
                        }

                        for (int i = gridSellOrder.Rows.Count - 1; i > numRow; i--)
                        {
                            gridSellOrder.Rows.RemoveAt(i);
                        }
                    }
                }
            }
            catch
            {

            }
        }

        DataTable dt = new DataTable();

        int numRow = 500;

        private void SellForm_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Price");
            dt.Columns.Add("Amount");
            dt.Columns.Add("TotalAmount");
            dt.Columns.Add("BTC");
            dt.Columns.Add("TotalBTC");
            dt.Columns.Add("AvgBTC");

            IniHelper ini = new IniHelper(Directory.GetCurrentDirectory() + "\\Config.ini");
            try
            {
                numRow = int.Parse(ini.ReadValue("Config", "ViewRow"));
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GridBind();
        }

        private void numGHS_Leave(object sender, EventArgs e)
        {
            Timestamp = "0";
        }

        private void gridSellOrder_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.SetBuy(decimal.Parse(gridSellOrder.SelectedRows[0].Cells["TotalAmount"].Value.ToString()), decimal.Parse(gridSellOrder.SelectedRows[0].Cells["Price"].Value.ToString()), decimal.Parse(gridSellOrder.SelectedRows[0].Cells["TotalBTC"].Value.ToString()));
            }
            catch
            { 
            }
        }
    }
}
