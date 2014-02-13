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
    public partial class BalanceForm : DockContent
    {
        public BalanceForm()
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

        private decimal btcHistory = 0m;

        private bool isLogin = false;

        private decimal maxBTC = 0m;

        private void timer1_Tick(object sender, EventArgs e)
        {
            BalanceModel bank = MainForm.Balance;

            if (bank == null
                || bank.timestamp == Timestamp)
                return;

            Timestamp = bank.timestamp;

            if (bank.BTC != null)
            {
                txtBtcBank.Text = bank.BTC["available"];
                txtBtcOrder.Text = bank.BTC["orders"];
                txtBtcTotal.Text = (decimal.Parse(bank.BTC["available"]) + decimal.Parse(bank.BTC["orders"])).ToString();
            }
            if (bank.GHS != null)
            {
                txtGHSBank.Text = bank.GHS["available"];
                txtGHSOrder.Text = bank.GHS["orders"];
                txtGHSTotal.Text = (decimal.Parse(bank.GHS["available"]) + decimal.Parse(bank.GHS["orders"])).ToString();
            }
            if (!isLogin)
            {
                isLogin = true;
                btcHistory = maxBTC;
            }
            else
            {
                txtGetMoney.Text = (decimal.Parse(txtBtcTotal.Text) - btcHistory).ToString();
            }

            if (maxBTC < decimal.Parse(txtBtcTotal.Text))
            {
                IniHelper ini = new IniHelper(Directory.GetCurrentDirectory() + "\\Config.ini");
                maxBTC = decimal.Parse(txtBtcTotal.Text);
                ini.WriteValue("Config", "MaxBTC", maxBTC.ToString("f8"));
            }

            if (decimal.Parse(txtGHSTotal.Text) != 0)
                txtAvgBtc.Text = ((maxBTC - decimal.Parse(txtBtcTotal.Text)) / decimal.Parse(txtGHSTotal.Text)).ToString("f8");
            else
                txtAvgBtc.Text = "0";

            txtGetBTC.Text = (maxBTC - decimal.Parse(txtBtcTotal.Text)).ToString("f8");
            txtMaxBTC.Text = maxBTC.ToString("f8");
        }

        private void BalanceForm_Load(object sender, EventArgs e)
        {
            IniHelper ini = new IniHelper(Directory.GetCurrentDirectory() + "\\Config.ini");
            try
            {
                maxBTC = decimal.Parse(ini.ReadValue("Config", "MaxBTC"));
            }
            catch
            {
                maxBTC = 0m;
            }
        }
    }
}
