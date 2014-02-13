namespace BTCTrade
{
    partial class Remind
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboSound = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSoundDelete = new System.Windows.Forms.Button();
            this.btnSoundAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSound = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.comboCalc = new System.Windows.Forms.ComboBox();
            this.comboMoney = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbSound);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numPrice);
            this.groupBox2.Controls.Add(this.comboCalc);
            this.groupBox2.Controls.Add(this.comboMoney);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 128);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboSound);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSoundDelete);
            this.groupBox1.Controls.Add(this.btnSoundAdd);
            this.groupBox1.Location = new System.Drawing.Point(6, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 73);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "声音设置";
            // 
            // comboSound
            // 
            this.comboSound.DisplayMember = "买单";
            this.comboSound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSound.FormattingEnabled = true;
            this.comboSound.Location = new System.Drawing.Point(47, 19);
            this.comboSound.Name = "comboSound";
            this.comboSound.Size = new System.Drawing.Size(129, 20);
            this.comboSound.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "声音";
            // 
            // btnSoundDelete
            // 
            this.btnSoundDelete.Location = new System.Drawing.Point(101, 44);
            this.btnSoundDelete.Name = "btnSoundDelete";
            this.btnSoundDelete.Size = new System.Drawing.Size(75, 23);
            this.btnSoundDelete.TabIndex = 8;
            this.btnSoundDelete.Text = "删除";
            this.btnSoundDelete.UseVisualStyleBackColor = true;
            this.btnSoundDelete.Click += new System.EventHandler(this.btnSoundDelete_Click);
            // 
            // btnSoundAdd
            // 
            this.btnSoundAdd.Location = new System.Drawing.Point(14, 44);
            this.btnSoundAdd.Name = "btnSoundAdd";
            this.btnSoundAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSoundAdd.TabIndex = 7;
            this.btnSoundAdd.Text = "添加";
            this.btnSoundAdd.UseVisualStyleBackColor = true;
            this.btnSoundAdd.Click += new System.EventHandler(this.btnSoundAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(311, 54);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 66);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(206, 54);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 66);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "提醒";
            // 
            // cbSound
            // 
            this.cbSound.AutoSize = true;
            this.cbSound.Location = new System.Drawing.Point(338, 23);
            this.cbSound.Name = "cbSound";
            this.cbSound.Size = new System.Drawing.Size(48, 16);
            this.cbSound.TabIndex = 5;
            this.cbSound.Text = "声音";
            this.cbSound.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "时提醒并且用";
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 8;
            this.numPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            524288});
            this.numPrice.Location = new System.Drawing.Point(154, 20);
            this.numPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(102, 21);
            this.numPrice.TabIndex = 2;
            // 
            // comboCalc
            // 
            this.comboCalc.DisplayMember = "买单";
            this.comboCalc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCalc.FormattingEnabled = true;
            this.comboCalc.Items.AddRange(new object[] {
            "大于",
            "小于"});
            this.comboCalc.Location = new System.Drawing.Point(83, 20);
            this.comboCalc.Name = "comboCalc";
            this.comboCalc.Size = new System.Drawing.Size(65, 20);
            this.comboCalc.TabIndex = 1;
            // 
            // comboMoney
            // 
            this.comboMoney.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMoney.FormattingEnabled = true;
            this.comboMoney.Items.AddRange(new object[] {
            "买单",
            "卖单"});
            this.comboMoney.Location = new System.Drawing.Point(12, 20);
            this.comboMoney.Name = "comboMoney";
            this.comboMoney.Size = new System.Drawing.Size(65, 20);
            this.comboMoney.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(420, 233);
            this.listBox1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "wav 文件|*.wav";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Remind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 361);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Remind";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Document;
            this.Text = "提醒设置";
            this.Load += new System.EventHandler(this.Remind_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbSound;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.ComboBox comboCalc;
        private System.Windows.Forms.ComboBox comboMoney;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboSound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSoundDelete;
        private System.Windows.Forms.Button btnSoundAdd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}