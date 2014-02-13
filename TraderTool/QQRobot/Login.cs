using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using yiwoSDK;

namespace QQRobot
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        CookieContainer cookie = new CookieContainer();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //登陆
            string qq = this.txtQQ.Text.Trim();

            if (string.IsNullOrEmpty(qq))
            {
                MessageBox.Show("请输入QQ号码！");
                return;
            }

            String pass = this.txtPass.Text.Trim();
            if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("请输入QQ密码！");
                return;
            }

            String code = this.txtCode.Text.Trim();
            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("请输入验证码！");
                return;
            }

            int ret = QQAPI.cWebQQ.Login(qq, pass, code, "Q我吧");

            switch (ret)
            {
                case 0:
                    this.Hide();
                    Main frmMain = new Main();
                    frmMain.Show();
                    break;
                case 1:
                    MessageBox.Show("密码错误！");
                    break;
                case 2:
                    MessageBox.Show("验证码错误");
                    GetVerify();
                    break;
                default:
                    MessageBox.Show("您输入的账号或密码有误" + ret);
                    break;
            }
        }

        private void GetVerify()
        {
            string qq = this.txtQQ.Text.Trim();

            string result = QQAPI.cWebQQ.GetLoginVC(qq);//根据QQ号获取默认验证码

            if (result.IndexOf("!") < 0)
            {
                txtCode.Enabled = true;
                //需要验证图片
                Image codeImage = QQAPI.cWebQQ.GetLoginVCImage(qq);
                this.picboxCode.Image = codeImage;
            }
            else
            {
                txtCode.Text = result.Substring(result.IndexOf('!'), 4);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CFun.I_LOVE_BBS("yiwowang.com");

            QQAPI.cWebQQ.SetHttpWeb(QQAPI.cHttpWeb);

            GetVerify();
        }
    }
}
