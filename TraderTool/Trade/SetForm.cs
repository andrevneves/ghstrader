using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WeifenLuo.WinFormsUI.Docking;
using API;

namespace BTCTrade
{
    public partial class SetForm : DockContent
    {
        public SetForm()
        {
            InitializeComponent();
        }

        public TradeMain MainForm
        {
            get;
            set;
        }

        private void btnSetSave_Click(object sender, EventArgs e)
        {
            IniHelper ini = new IniHelper(Directory.GetCurrentDirectory() + "\\Config.ini");
            ini.WriteValue("Config", "Key", txtKey.Text);
            ini.WriteValue("Config", "Secret", txtSecret.Text);
            ini.WriteValue("Config", "Code", txtCode.Text);
            ini.WriteValue("Config", "ViewRow", numRow.Value.ToString());

            MainForm.SetUserForm();
            MainForm.GetUserSet();
        }

        private void SetForm_Load(object sender, EventArgs e)
        {
            try
            {
                IniHelper ini = new IniHelper(Directory.GetCurrentDirectory() + "\\Config.ini");
                txtKey.Text = ini.ReadValue("Config", "Key");
                txtSecret.Text = ini.ReadValue("Config", "Secret");
                txtCode.Text = ini.ReadValue("Config", "Code");
                numRow.Value = decimal.Parse(ini.ReadValue("Config", "ViewRow"));
            }
            catch
            {
            }
        }
    }
}
