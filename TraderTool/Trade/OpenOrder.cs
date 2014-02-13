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

namespace BTCTrade
{
    public partial class OpenOrder : DockContent
    {
        public OpenOrder()
        {
            InitializeComponent();
        }

        public TradeMain MainForm
        {
            get;
            set;
        }

        public DataTable DtOpenOrder
        {
            get;
            set;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((string)dataGridView1.CurrentCell.Value == "取消")
                {
                    MainForm.CancelOrder(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                }
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                List<Dictionary<string, string>> order = MainForm.MyOrder;

                if (order == null )
                    return;

                if (dataGridView1.Rows.Count == 0)
                {
                    foreach (Dictionary<string, string> dic in order)
                    {
                        int index = dataGridView1.Rows.Add();

                        dataGridView1.Rows[index].Cells["Id"].Value = dic["id"];
                        dataGridView1.Rows[index].Cells["Type"].Value = dic["type"];
                        dataGridView1.Rows[index].Cells["Amount"].Value = dic["amount"];
                        dataGridView1.Rows[index].Cells["Price"].Value = dic["price"];
                        dataGridView1.Rows[index].Cells["Pending"].Value = dic["pending"];
                        dataGridView1.Rows[index].Cells["TotalBTC"].Value = (decimal.Parse(dic["amount"]) * decimal.Parse(dic["price"])).ToString("f8");
                        dataGridView1.Rows[index].Cells["RemainingBTC"].Value = (decimal.Parse(dic["pending"]) * decimal.Parse(dic["price"])).ToString("f8");
                    }
                }
                else
                {
                    foreach (Dictionary<string, string> dic in order)
                    {
                        DataRow dr = dt.NewRow();

                        dr["Id"] = dic["id"];
                        dr["Type"] = dic["type"];
                        dr["Amount"] = dic["amount"];
                        dr["Price"] = dic["price"];
                        dr["Pending"] = dic["pending"];
                        dr["TotalBTC"] = (decimal.Parse(dic["amount"]) * decimal.Parse(dic["price"])).ToString("f8");
                        dr["RemainingBTC"] = (decimal.Parse(dic["pending"]) * decimal.Parse(dic["price"])).ToString("f8");

                        dt.Rows.Add(dr);
                    }

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var q = from r in dataGridView1.Rows.Cast<DataGridViewRow>()
                                where r.Cells["Id"].Value.ToString() == dt.Rows[i]["Id"].ToString()
                                select r;

                        if (q.Count() == 1)
                        {
                            DataGridViewRow dr = q.SingleOrDefault();

                            if (dr.Cells["MessageBox"].Value != null
                                && bool.Parse(dr.Cells["MessageBox"].Value.ToString())
                                && dr.Cells["Section"].Value != null
                                && bool.Parse(dr.Cells["Section"].Value.ToString())
                                && dr.Cells["Pending"].Value != null
                                && decimal.Parse(dr.Cells["Pending"].Value.ToString()) != decimal.Parse(dt.Rows[i]["pending"].ToString()))
                            {
                                MainForm.ShowAlert(string.Format("你价位在 {0} 的单据发生改变。", dt.Rows[i]["price"].ToString()), bool.Parse(dr.Cells["Sound"].Value.ToString()) ? Directory.GetCurrentDirectory() + "\\提示.wav" : null);

                                dr.Cells["Id"].Value = dt.Rows[i]["id"];
                                dr.Cells["Type"].Value = dt.Rows[i]["type"];
                                dr.Cells["Amount"].Value = dt.Rows[i]["amount"];
                                dr.Cells["Price"].Value = dt.Rows[i]["price"];
                                dr.Cells["Pending"].Value = dt.Rows[i]["pending"];
                                dr.Cells["TotalBTC"].Value = (decimal.Parse(dt.Rows[i]["amount"].ToString()) * decimal.Parse(dt.Rows[i]["price"].ToString())).ToString("f8");
                                dr.Cells["RemainingBTC"].Value = (decimal.Parse(dt.Rows[i]["pending"].ToString()) * decimal.Parse(dt.Rows[i]["price"].ToString())).ToString("f8");
                            }
                        }
                        else
                        {
                            int index = this.dataGridView1.Rows.Add();

                            dataGridView1.Rows[index].Cells["Id"].Value = dt.Rows[i]["id"];
                            dataGridView1.Rows[index].Cells["Type"].Value = dt.Rows[i]["type"];
                            dataGridView1.Rows[index].Cells["Amount"].Value = dt.Rows[i]["amount"];
                            dataGridView1.Rows[index].Cells["Price"].Value = dt.Rows[i]["price"];
                            dataGridView1.Rows[index].Cells["Pending"].Value = dt.Rows[i]["pending"];
                            dataGridView1.Rows[index].Cells["TotalBTC"].Value = (decimal.Parse(dt.Rows[i]["amount"].ToString()) * decimal.Parse(dt.Rows[i]["price"].ToString())).ToString("f8");
                            dataGridView1.Rows[index].Cells["RemainingBTC"].Value = (decimal.Parse(dt.Rows[i]["pending"].ToString()) * decimal.Parse(dt.Rows[i]["price"].ToString())).ToString("f8");
                        }
                    }

                    for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
                    {
                        var q = from r in dt.AsEnumerable()
                                where r["ID"].ToString() == dataGridView1.Rows[i].Cells["ID"].Value.ToString()
                                select r;

                        if (q.Count() <= 0)
                        {
                            DataGridViewRow dr = dataGridView1.Rows[i];

                            if (dr.Cells["MessageBox"].Value != null
                                && bool.Parse(dr.Cells["MessageBox"].Value.ToString()))
                                MainForm.ShowAlert(string.Format("你价位在 {0} 的单据交易成功。", dt.Rows[i]["price"].ToString()), bool.Parse(dataGridView1.Rows[i].Cells["Sound"].Value.ToString()) ? Directory.GetCurrentDirectory() + "\\提示.wav" : null);

                            dataGridView1.Rows.RemoveAt(i);
                        }
                    }

                    dt.Rows.Clear();
                }
            }
            catch
            { }
        }

        DataTable dt = new DataTable();

        private void OpenOrder_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Id");
            dt.Columns.Add("Type");
            dt.Columns.Add("Amount");
            dt.Columns.Add("Pending");
            dt.Columns.Add("Price");
            dt.Columns.Add("TotalBTC");
            dt.Columns.Add("RemainingBTC");
        }

        internal void CancelAlert(string argId)
        {
            try
            {
                var q = from e in dataGridView1.Rows.Cast<DataGridViewRow>()
                        where e.Cells["Id"].Value.ToString() == argId
                        select e;

                if (q.Count() > 0)
                {
                    dataGridView1.Rows.Remove(q.SingleOrDefault());
                }
            }
            catch
            {

            }
        }
    }
}
