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
using System.Media;
using System.Runtime.InteropServices;
using Model;
using API;

namespace BTCTrade
{
    public partial class Remind : DockContent
    {
        public Remind()
        {
            InitializeComponent();
        }

        public TradeMain MainForm
        {
            get;
            set;
        }

        private void btnSoundAdd_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    SoundPlayer sndPlayer = new SoundPlayer(openFileDialog1.FileName);
                    sndPlayer.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                var q = from row in dt.AsEnumerable()
                        where row["Path"].ToString() == openFileDialog1.FileName
                        select row;

                if (q.Count() > 0)
                {
                    MessageBox.Show("该文件已经添加!");
                    return;
                }

                DataRow dr = dt.NewRow();
                dr["Name"] = Path.GetFileName(openFileDialog1.FileName);
                dr["Path"] = openFileDialog1.FileName;
                dt.Rows.Add(dr);


                IniHelper ini = new IniHelper(Directory.GetCurrentDirectory() + "\\Config.ini");

                ini.WriteValue("Sound", null, null);

                ini.WriteValue("Sound", "Max", dt.Rows.Count.ToString());

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ini.WriteValue("Sound", "Key" + 0, dt.Rows[i]["Path"].ToString());
                }
            }
        }

        DataTable dt = new DataTable();
        DataTable dtList = new DataTable();

        private void btnSoundDelete_Click(object sender, EventArgs e)
        {
            if (comboSound.SelectedIndex == -1)
                return;

            try
            {
                var q = from row in dt.AsEnumerable()
                        where row["Path"].ToString() == comboSound.SelectedValue.ToString()
                        select row;

                if (q.Count() > 0)
                    dt.Rows.Remove(q.SingleOrDefault());

                IniHelper ini = new IniHelper(Directory.GetCurrentDirectory() + "\\Config.ini");

                ini.WriteValue("Sound", null, null);

                ini.WriteValue("Sound", "Max", dt.Rows.Count.ToString());

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ini.WriteValue("Sound", "Key" + 0, dt.Rows[i]["Path"].ToString());
                }
            }
            catch
            {
            }
        }

        private void Remind_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Name");
            dt.Columns.Add("Path");

            dtList.Columns.Add("Display");
            dtList.Columns.Add("Money");
            dtList.Columns.Add("Calc");
            dtList.Columns.Add("Price");
            dtList.Columns.Add("IsSound");
            dtList.Columns.Add("SoundPath");

            IniHelper ini = new IniHelper(Directory.GetCurrentDirectory() + "\\Config.ini");
            string str = ini.ReadValue("Sound", "Max");

            if (!string.IsNullOrEmpty(str))
            {
                int max = int.Parse(str);

                for (int i = 0; i < max; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["Name"] = Path.GetFileName(ini.ReadValue("Sound", "Key" + i));
                    dr["Path"] = ini.ReadValue("Sound", "Key" + i);
                    dt.Rows.Add(dr);
                }
            }

            comboSound.DisplayMember = "Name";
            comboSound.ValueMember = "Path";
            comboSound.DataSource = dt;

            comboMoney.SelectedIndex = 0;
            comboCalc.SelectedIndex = 0;

            listBox1.DisplayMember = "Display";
            listBox1.DataSource = dtList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow dr = dtList.NewRow();

            if ((cbSound.Checked && comboSound.Items.Count == 0) || (cbSound.Checked && string.IsNullOrEmpty(comboSound.SelectedValue.ToString())))
            {
                MessageBox.Show("没有选择音乐文件!");
                return;
            }

            dr["Display"] = comboMoney.SelectedItem + " " + comboCalc.SelectedItem + " " + numPrice.Value.ToString() + " (声音提醒:" + (cbSound.Checked ? "是" : "否") + ")";
            dr["Money"] = comboMoney.SelectedItem;
            dr["Calc"] = comboCalc.SelectedItem;
            dr["Price"] = numPrice.Value.ToString();
            dr["IsSound"] = cbSound.Checked;
            dr["SoundPath"] = comboSound.SelectedValue;

            var q = from row in dtList.AsEnumerable()
                    where row["Display"].ToString() == dr["Display"].ToString()
                    select row;

            if (q.Count() > 0)
            {
                MessageBox.Show("提醒重复!");
                return;
            }

            dtList.Rows.Add(dr);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return;

            var q = from row in dtList.AsEnumerable()
                    where row["Display"].ToString() == listBox1.Text
                    select row;

            if (q.Count() > 0)
                dtList.Rows.Remove(q.SingleOrDefault());
        }

        public string Timestamp
        {
            get;
            set;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dtList.Rows.Count > 0)
            {
                OrderModel order = MainForm.Order;

                if (order == null
                    || order.timestamp == Timestamp)
                    return;

                Timestamp = order.timestamp;

                int i = dtList.Rows.Count - 1;

                for (; i >= 0; i--)
                {
                    bool isAlert = false;
                    DataRow dr = dtList.Rows[i];
                    if (dr["Money"].ToString() == "买单" && order.bids != null)
                    {
                        if (dr["Calc"].ToString() == "大于")
                        {
                            if (order.bids[0][0] >= decimal.Parse(dr["Price"].ToString()))
                                isAlert = true;
                        }
                        else
                        {
                            if (order.bids[0][0] <= decimal.Parse(dr["Price"].ToString()))
                                isAlert = true;
                        }
                    }
                    else if (dr["Money"].ToString() == "卖单" && order.asks != null)
                    {
                        if (dr["Calc"].ToString() == "大于")
                        {
                            if (order.asks[0][0] >= decimal.Parse(dr["Price"].ToString()))
                                isAlert = true;
                        }
                        else
                        {
                            if (order.asks[0][0] <= decimal.Parse(dr["Price"].ToString()))
                                isAlert = true;
                        }
                    }

                    if (isAlert)
                    {
                        MainForm.ShowAlert(dtList.Rows[i]["Display"].ToString(), bool.Parse(dtList.Rows[i]["IsSound"].ToString()) ? dtList.Rows[i]["SoundPath"].ToString() : null);
                        dtList.Rows.RemoveAt(i);
                    }
                }
            }
        }
    }
}