namespace BTCTrade
{
    partial class SellForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numGHS = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridSellOrder = new System.Windows.Forms.DataGridView();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgBTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGHS)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSellOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numGHS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 41);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据过滤";
            // 
            // numGHS
            // 
            this.numGHS.DecimalPlaces = 8;
            this.numGHS.Location = new System.Drawing.Point(65, 12);
            this.numGHS.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numGHS.Name = "numGHS";
            this.numGHS.Size = new System.Drawing.Size(97, 21);
            this.numGHS.TabIndex = 1;
            this.numGHS.Leave += new System.EventHandler(this.numGHS_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "GHS大于                   显示";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridSellOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 221);
            this.panel1.TabIndex = 7;
            // 
            // gridSellOrder
            // 
            this.gridSellOrder.AllowUserToAddRows = false;
            this.gridSellOrder.AllowUserToDeleteRows = false;
            this.gridSellOrder.AllowUserToResizeRows = false;
            this.gridSellOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSellOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Price,
            this.Amount,
            this.TotalAmount,
            this.BTC,
            this.TotalBTC,
            this.AvgBTC});
            this.gridSellOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSellOrder.Location = new System.Drawing.Point(0, 0);
            this.gridSellOrder.Name = "gridSellOrder";
            this.gridSellOrder.ReadOnly = true;
            this.gridSellOrder.RowHeadersVisible = false;
            this.gridSellOrder.RowTemplate.Height = 23;
            this.gridSellOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSellOrder.Size = new System.Drawing.Size(535, 221);
            this.gridSellOrder.TabIndex = 6;
            this.gridSellOrder.DoubleClick += new System.EventHandler(this.gridSellOrder_Click);
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "GHS价格";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Price.Width = 70;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "GHS数量";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Amount.Width = 80;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.TotalAmount.HeaderText = "GHS总数量";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BTC
            // 
            this.BTC.DataPropertyName = "BTC";
            this.BTC.HeaderText = "BTC价格";
            this.BTC.Name = "BTC";
            this.BTC.ReadOnly = true;
            this.BTC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BTC.Width = 80;
            // 
            // TotalBTC
            // 
            this.TotalBTC.DataPropertyName = "TotalBTC";
            this.TotalBTC.HeaderText = "总需BTC";
            this.TotalBTC.Name = "TotalBTC";
            this.TotalBTC.ReadOnly = true;
            this.TotalBTC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AvgBTC
            // 
            this.AvgBTC.DataPropertyName = "AvgBTC";
            this.AvgBTC.HeaderText = "BTC平均价格";
            this.AvgBTC.Name = "AvgBTC";
            this.AvgBTC.ReadOnly = true;
            this.AvgBTC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 262);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SellForm";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockLeft;
            this.ShowIcon = false;
            this.Text = "卖单";
            this.Load += new System.EventHandler(this.SellForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGHS)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSellOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numGHS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridSellOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgBTC;
    }
}