using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;
using Model;
using API;

namespace BTCTrade
{
    public partial class BuyForm : DockContent
    {
        public BuyForm()
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

                if (order != null && order.bids != null)
                {
                    if (gridBuyOrder.Rows.Count == 0)
                    {
                        decimal totalAmount = 0m;
                        decimal totalBTC = 0m;

                        int numAdd = 0;

                        for (int i = 0; i < numRow + numAdd && numRow + numAdd < order.bids.Count; i++)
                        {
                            totalAmount += order.bids[i][1];
                            totalBTC += (order.bids[i][0] * order.bids[i][1]);

                            if (order.bids[i][1] < numGHS.Value)
                            {
                                numAdd++;
                                continue;
                            }


                            int index = gridBuyOrder.Rows.Add();
                            gridBuyOrder.Rows[index].Cells["Price"].Value = order.bids[i][0].ToString("f8");
                            gridBuyOrder.Rows[index].Cells["Amount"].Value = order.bids[i][1].ToString("f8");
                            gridBuyOrder.Rows[index].Cells["TotalAmount"].Value = totalAmount.ToString("f8");
                            gridBuyOrder.Rows[index].Cells["BTC"].Value = (order.bids[i][0] * order.bids[i][1]).ToString("f8");
                            gridBuyOrder.Rows[index].Cells["TotalBTC"].Value = totalBTC.ToString("f8");
                            gridBuyOrder.Rows[index].Cells["AvgBTC"].Value = (totalBTC / totalAmount).ToString("f8");
                        }
                    }
                    else
                    {
                        dt.Rows.Clear();

                        decimal totalAmount = 0m;
                        decimal totalBTC = 0m;
                        int numAdd = 0;

                        for (int i = 0; i < numRow + numAdd && numRow + numAdd < order.bids.Count; i++)
                        {
                            totalAmount += order.bids[i][1];
                            totalBTC += (order.bids[i][0] * order.bids[i][1]);

                            if (order.bids[i][1] < numGHS.Value)
                            {
                                numAdd++;
                                continue;
                            }

                            DataRow dr = dt.NewRow();
                            dt.Rows.Add(dr);

                            dr["Price"] = order.bids[i][0].ToString("f8");
                            dr["Amount"] = order.bids[i][1].ToString("f8");
                            dr["TotalAmount"] = totalAmount.ToString("f8");
                            dr["BTC"] = (order.bids[i][0] * order.bids[i][1]).ToString("f8");
                            dr["TotalBTC"] = totalBTC.ToString("f8");
                            dr["AvgBTC"] = (totalBTC / totalAmount).ToString("f8");
                        }

                        int nowIndex = -1;

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            var q = from e in gridBuyOrder.Rows.Cast<DataGridViewRow>()
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
                                if (nowIndex >= (this.gridBuyOrder.Rows.Count - 1))
                                {
                                    nowIndex = this.gridBuyOrder.Rows.Add();
                                }
                                else
                                {
                                    gridBuyOrder.Rows.Insert(nowIndex, 1);
                                }
                                gridBuyOrder.Rows[nowIndex].Cells["Price"].Value = dt.Rows[i]["Price"];
                                gridBuyOrder.Rows[nowIndex].Cells["Amount"].Value = dt.Rows[i]["Amount"];
                                gridBuyOrder.Rows[nowIndex].Cells["TotalAmount"].Value = dt.Rows[i]["TotalAmount"];
                                gridBuyOrder.Rows[nowIndex].Cells["BTC"].Value = dt.Rows[i]["BTC"];
                                gridBuyOrder.Rows[nowIndex].Cells["TotalBTC"].Value = dt.Rows[i]["TotalBTC"];
                                gridBuyOrder.Rows[nowIndex].Cells["AvgBTC"].Value = dt.Rows[i]["AvgBTC"];

                            }
                        }

                        for (int i = gridBuyOrder.Rows.Count - 1; i >= 0; i--)
                        {
                            var q = from e in dt.AsEnumerable()
                                    where e["Price"].ToString() == gridBuyOrder.Rows[i].Cells["Price"].Value.ToString()
                                    select e;

                            if (q.Count() <= 0)
                                gridBuyOrder.Rows.RemoveAt(i);
                        }

                        for (int i = gridBuyOrder.Rows.Count - 1; i > numRow; i--)
                        {
                            gridBuyOrder.Rows.RemoveAt(i);
                        }
                    }
                }
            }
            catch
            {

            }
        }

        int numRow = 500;
        DataTable dt = new DataTable();

        private void timer1_Tick(object sender, EventArgs e)
        {
            GridBind();
        }

        private void numGHS_Leave(object sender, EventArgs e)
        {
            Timestamp = "0";
        }

        private void BuyForm_Load(object sender, EventArgs e)
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

        private void gridBuyOrder_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.SetSell(decimal.Parse(gridBuyOrder.SelectedRows[0].Cells["TotalAmount"].Value.ToString()), decimal.Parse(gridBuyOrder.SelectedRows[0].Cells["Price"].Value.ToString()), decimal.Parse(gridBuyOrder.SelectedRows[0].Cells["TotalBTC"].Value.ToString()));

            }
            catch
            {

            }
        }
    }
}