namespace BTCTrade
{
    partial class TradeForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.numBuyPrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numBuyAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butSell = new System.Windows.Forms.Button();
            this.numSellPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numSellAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuyBTC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSellBTC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBuyPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuyAmount)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSellPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(482, 184);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuyBTC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnBuy);
            this.groupBox1.Controls.Add(this.numBuyPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numBuyAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "买GHS";
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(44, 94);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(183, 70);
            this.btnBuy.TabIndex = 4;
            this.btnBuy.Text = "买入";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // numBuyPrice
            // 
            this.numBuyPrice.DecimalPlaces = 8;
            this.numBuyPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            589824});
            this.numBuyPrice.Location = new System.Drawing.Point(44, 40);
            this.numBuyPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBuyPrice.Name = "numBuyPrice";
            this.numBuyPrice.Size = new System.Drawing.Size(183, 21);
            this.numBuyPrice.TabIndex = 3;
            this.numBuyPrice.ValueChanged += new System.EventHandler(this.BuyValueChangd);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "价格";
            // 
            // numBuyAmount
            // 
            this.numBuyAmount.DecimalPlaces = 8;
            this.numBuyAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            589824});
            this.numBuyAmount.Location = new System.Drawing.Point(44, 13);
            this.numBuyAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBuyAmount.Name = "numBuyAmount";
            this.numBuyAmount.Size = new System.Drawing.Size(183, 21);
            this.numBuyAmount.TabIndex = 1;
            this.numBuyAmount.ValueChanged += new System.EventHandler(this.BuyValueChangd);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数量";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSellBTC);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.butSell);
            this.groupBox2.Controls.Add(this.numSellPrice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numSellAmount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "卖GHS";
            // 
            // butSell
            // 
            this.butSell.Location = new System.Drawing.Point(44, 94);
            this.butSell.Name = "butSell";
            this.butSell.Size = new System.Drawing.Size(183, 70);
            this.butSell.TabIndex = 4;
            this.butSell.Text = "卖出";
            this.butSell.UseVisualStyleBackColor = true;
            this.butSell.Click += new System.EventHandler(this.butSell_Click);
            // 
            // numSellPrice
            // 
            this.numSellPrice.DecimalPlaces = 8;
            this.numSellPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            589824});
            this.numSellPrice.Location = new System.Drawing.Point(44, 40);
            this.numSellPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSellPrice.Name = "numSellPrice";
            this.numSellPrice.Size = new System.Drawing.Size(183, 21);
            this.numSellPrice.TabIndex = 3;
            this.numSellPrice.ValueChanged += new System.EventHandler(this.SellValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "价格";
            // 
            // numSellAmount
            // 
            this.numSellAmount.DecimalPlaces = 8;
            this.numSellAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            589824});
            this.numSellAmount.Location = new System.Drawing.Point(44, 13);
            this.numSellAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSellAmount.Name = "numSellAmount";
            this.numSellAmount.Size = new System.Drawing.Size(183, 21);
            this.numSellAmount.TabIndex = 1;
            this.numSellAmount.ValueChanged += new System.EventHandler(this.SellValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "数量";
            // 
            // txtBuyBTC
            // 
            this.txtBuyBTC.Location = new System.Drawing.Point(44, 67);
            this.txtBuyBTC.Name = "txtBuyBTC";
            this.txtBuyBTC.ReadOnly = true;
            this.txtBuyBTC.Size = new System.Drawing.Size(183, 21);
            this.txtBuyBTC.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "BTC";
            // 
            // txtSellBTC
            // 
            this.txtSellBTC.Location = new System.Drawing.Point(44, 67);
            this.txtSellBTC.Name = "txtSellBTC";
            this.txtSellBTC.ReadOnly = true;
            this.txtSellBTC.Size = new System.Drawing.Size(183, 21);
            this.txtSellBTC.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "BTC";
            // 
            // TradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 184);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "TradeForm";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Document;
            this.Text = "交易";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBuyPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBuyAmount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSellPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numBuyAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numBuyPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butSell;
        private System.Windows.Forms.NumericUpDown numSellPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numSellAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuyBTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSellBTC;
        private System.Windows.Forms.Label label6;
    }
}