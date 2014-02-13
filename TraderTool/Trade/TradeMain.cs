using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Web.Script.Serialization;
using System.Security.Cryptography;
using System.Threading;
using System.IO;
using WeifenLuo.WinFormsUI.Docking;
using Model;
using API;

namespace BTCTrade
{
    public partial class TradeMain : Form
    {
        public TradeMain()
        {
            InitializeComponent();
        }

        public DataTable DtBuyOrder
        {
            get;
            set;
        }

        public DataTable DtOpenOrder
        {
            get;
            set;
        }

        public DateTime GetOrderTime
        {
            get;
            set;
        }

        public BalanceModel Balance
        {
            get;
            set;
        }

        public OrderModel Order
        {
            get;
            set;
        }

        public List<Dictionary<string, string>> MyOrder
        {
            get;
            set;
        }

        public void ShowAlert(string argContent, string argSoundPath)
        {
            Alert.ShowWay showWay = Alert.ShowWay.UpDown;

            int afShowInTime, afShowTime, afShowOutTime;
            int afWidth, afHeigth;

            int.TryParse("200", out afShowInTime);
            int.TryParse("3000000", out afShowTime);
            int.TryParse("500", out afShowOutTime);
            int.TryParse("400", out afWidth);
            int.TryParse("180", out afHeigth);

            Alert af = new Alert();
            af.Show(argContent, argSoundPath, showWay, afWidth, afHeigth, afShowInTime, afShowTime, afShowOutTime);
        }

        public void CancelOrder(string argId)
        {
            try
            {
                if (GHS.CancelOrder(argId))
                {
                    MessageBox.Show("取消成功");

                    orderForm.CancelAlert(argId);

                    try
                    {
                        MyOrder = GHS.OpenOrder();
                    }
                    catch
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BuyOrSellBTC(string argType, decimal argAmount, decimal argPrice)
        {
            try
            {
                if (GHS.BuyOrSellBTC(argType, argAmount, argPrice))
                {
                    MessageBox.Show("交易成功");

                    try
                    {
                        MyOrder = GHS.OpenOrder();
                    }
                    catch
                    {

                    }
                }
                else
                    MessageBox.Show("交易失败，原因未知");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void OpenOrder()
        {
            while (true)
            {
                try
                {
                    MyOrder = GHS.OpenOrder();

                    Thread.CurrentThread.Join(3000);
                }
                catch
                {

                }
            }
        }

        private void GetBalance()
        {
            while (true)
            {
                try
                {
                    Balance = GHS.GetBalance();

                    Thread.CurrentThread.Join(1500);
                }
                catch
                {

                }
            }
        }

        private void GetOrder()
        {
            while (true)
            {
                try
                {
                    Order = GHS.GetOrder();
                    Thread.CurrentThread.Join(1500);
                }
                catch
                {
                }
            }
        }

        private TradeForm tradeForm;
        private SetForm setForm;
        private Remind remindForm;
        private BalanceForm bankForm;
        private OpenOrder orderForm;
        private SellForm sellForm;
        private BuyForm buyForm;

        private void TradeMain_Load(object sender, EventArgs e)
        {
            Order = new OrderModel();

            IniHelper ini = new IniHelper(Directory.GetCurrentDirectory() + "\\Config.ini");

            setForm = new SetForm();
            setForm.MainForm = this;
            setForm.Show(dockPanel1);
            string str = ini.ReadValue("Form", "SetForm");
            if (!string.IsNullOrEmpty(str))
                setForm.DockState = (DockState)Enum.Parse(typeof(DockState), str);

            bankForm = new BalanceForm();
            bankForm.MainForm = this;
            bankForm.Show(dockPanel1);
            str = ini.ReadValue("Form", "BankForm");
            if (!string.IsNullOrEmpty(str))
                bankForm.DockState = (DockState)Enum.Parse(typeof(DockState), str);

            remindForm = new Remind();
            remindForm.MainForm = this;
            remindForm.Show(dockPanel1);
            str = ini.ReadValue("Form", "RemindForm");
            if (!string.IsNullOrEmpty(str))
                remindForm.DockState = (DockState)Enum.Parse(typeof(DockState), str);

            tradeForm = new TradeForm();
            tradeForm.MainForm = this;
            tradeForm.Show(dockPanel1);
            str = ini.ReadValue("Form", "TradeForm");
            if (!string.IsNullOrEmpty(str))
                tradeForm.DockState = (DockState)Enum.Parse(typeof(DockState), str);

            orderForm = new OpenOrder();
            orderForm.MainForm = this;
            orderForm.Show(dockPanel1);
            str = ini.ReadValue("Form", "OrderForm");
            if (!string.IsNullOrEmpty(str))
                orderForm.DockState = (DockState)Enum.Parse(typeof(DockState), str);

            sellForm = new SellForm();
            sellForm.MainForm = this;
            sellForm.Show(dockPanel1);
            str = ini.ReadValue("Form", "SellForm");
            if (!string.IsNullOrEmpty(str))
                sellForm.DockState = (DockState)Enum.Parse(typeof(DockState), str);

            buyForm = new BuyForm();
            buyForm.MainForm = this;
            buyForm.Show(dockPanel1);
            str = ini.ReadValue("Form", "BuyForm");
            if (!string.IsNullOrEmpty(str))
                buyForm.DockState = (DockState)Enum.Parse(typeof(DockState), str);

            GetUserSet();
        }

        public void SetBuy(decimal argAmount, decimal argPrice, decimal argTotalBTC)
        {
            tradeForm.SetBuy(argAmount, argPrice, argTotalBTC);
        }

        public void SetSell(decimal argAmount, decimal argPrice, decimal argTotalBTC)
        {
            tradeForm.SetSell(argAmount, argPrice, argTotalBTC);
        }

        public void SetUserForm()
        {
            IniHelper ini = new IniHelper(Directory.GetCurrentDirectory() + "\\Config.ini");
            ini.WriteValue("Form", "SetForm", setForm.DockState.ToString());
            ini.WriteValue("Form", "RemindForm", remindForm.DockState.ToString());
            ini.WriteValue("Form", "BankForm", bankForm.DockState.ToString());
            ini.WriteValue("Form", "TradeForm", tradeForm.DockState.ToString());
            ini.WriteValue("Form", "OrderForm", orderForm.DockState.ToString());
            ini.WriteValue("Form", "SellForm", sellForm.DockState.ToString());
            ini.WriteValue("Form", "BuyForm", buyForm.DockState.ToString());
        }

        public void GetUserSet()
        {
            IniHelper ini = new IniHelper(Directory.GetCurrentDirectory() + "\\Config.ini");
            GHS.api_key = ini.ReadValue("Config", "Key");
            GHS.secret = ini.ReadValue("Config", "Secret");
            GHS.name = ini.ReadValue("Config", "Code");

            string signature = string.Empty;
            string nonce = string.Empty;

            try
            {
                if (GHS.GetSignature(ref signature, ref nonce))
                {
                    Start();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Thread threadBalance;
        Thread threadOrder;
        Thread threadOpenOrder;

        public void Start()
        {
            if (threadBalance != null)
            {
                threadBalance.Abort();
                threadBalance = null;
            }

            threadBalance = new Thread(new ThreadStart(GetBalance));
            threadBalance.Start();

            if (threadOrder != null)
            {
                threadOrder.Abort();
                threadOrder = null;
            }

            threadOrder = new Thread(new ThreadStart(GetOrder));
            threadOrder.Start();

            if (threadOpenOrder != null)
            {
                threadOpenOrder.Abort();
                threadOpenOrder = null;
            }

            threadOpenOrder = new Thread(new ThreadStart(OpenOrder));
            threadOpenOrder.Start();
        }

        private void TradeMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (threadBalance != null)
                threadBalance.Abort();
            threadBalance = null;

            if (threadOrder != null)
                threadOrder.Abort();
            threadOrder = null;

            if (threadOpenOrder != null)
                threadOpenOrder.Abort();
            threadOpenOrder = null;
        }
    }
}
