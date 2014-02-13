using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace BTCTrade
{
    public partial class TradeForm : DockContent
    {
        public TradeForm()
        {
            InitializeComponent();
        }

        public TradeMain MainForm
        {
            get;
            set;
        }

        private void BuyValueChangd(object sender, EventArgs e)
        {
            txtBuyBTC.Text = (numBuyAmount.Value * numBuyPrice.Value).ToString("f8");
        }

        private void SellValueChanged(object sender, EventArgs e)
        {
            txtSellBTC.Text = (numSellAmount.Value * numSellPrice.Value).ToString("f8");
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            MainForm.BuyOrSellBTC("buy", numBuyAmount.Value, numBuyPrice.Value);
        }

        private void butSell_Click(object sender, EventArgs e)
        {
            MainForm.BuyOrSellBTC("sell", numSellAmount.Value, numSellPrice.Value);
        }

        public void SetBuy(decimal argAmount, decimal argPrice, decimal argTotalBTC)
        {
            numBuyAmount.Value = argAmount;
            numBuyPrice.Value = argPrice;
            txtBuyBTC.Text = argTotalBTC.ToString("f8");
        }

        public void SetSell(decimal argAmount, decimal argPrice, decimal argTotalBTC)
        {
            numSellAmount.Value = argAmount;
            numSellPrice.Value = argPrice;
            txtSellBTC.Text = argTotalBTC.ToString("f8");
        }
    }
}
