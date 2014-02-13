namespace QQRobot
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_pass_info = new System.Windows.Forms.Label();
            this.lbl_qq_info = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.picboxCode = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtQQ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCode)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_pass_info
            // 
            this.lbl_pass_info.AutoSize = true;
            this.lbl_pass_info.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_pass_info.Location = new System.Drawing.Point(76, 128);
            this.lbl_pass_info.Name = "lbl_pass_info";
            this.lbl_pass_info.Size = new System.Drawing.Size(0, 16);
            this.lbl_pass_info.TabIndex = 18;
            // 
            // lbl_qq_info
            // 
            this.lbl_qq_info.AutoSize = true;
            this.lbl_qq_info.Font = new System.Drawing.Font("宋体", 12F);
            this.lbl_qq_info.Location = new System.Drawing.Point(76, 72);
            this.lbl_qq_info.Name = "lbl_qq_info";
            this.lbl_qq_info.Size = new System.Drawing.Size(0, 16);
            this.lbl_qq_info.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F);
            this.label3.Location = new System.Drawing.Point(25, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "验证";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("宋体", 9F);
            this.txtCode.Location = new System.Drawing.Point(60, 60);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(92, 21);
            this.txtCode.TabIndex = 12;
            this.txtCode.Text = "!pic";
            // 
            // picboxCode
            // 
            this.picboxCode.Location = new System.Drawing.Point(158, 60);
            this.picboxCode.Name = "picboxCode";
            this.picboxCode.Size = new System.Drawing.Size(101, 53);
            this.picboxCode.TabIndex = 15;
            this.picboxCode.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(25, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "密码";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("宋体", 9F);
            this.txtPass.Location = new System.Drawing.Point(60, 33);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(199, 21);
            this.txtPass.TabIndex = 10;
            this.txtPass.Text = "x2256812";
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtQQ
            // 
            this.txtQQ.Font = new System.Drawing.Font("宋体", 9F);
            this.txtQQ.Location = new System.Drawing.Point(60, 6);
            this.txtQQ.Name = "txtQQ";
            this.txtQQ.Size = new System.Drawing.Size(200, 21);
            this.txtQQ.TabIndex = 9;
            this.txtQQ.Text = "1059651643";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "QQ号码";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("宋体", 9F);
            this.btnLogin.Location = new System.Drawing.Point(27, 87);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(125, 26);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "登 陆";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 125);
            this.Controls.Add(this.lbl_pass_info);
            this.Controls.Add(this.lbl_qq_info);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.picboxCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtQQ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pass_info;
        private System.Windows.Forms.Label lbl_qq_info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.PictureBox picboxCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtQQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
    }
}