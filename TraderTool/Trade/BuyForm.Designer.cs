namespace BTCTrade
{
    partial class BuyForm
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
            this.gridBuyOrder = new System.Windows.Forms.DataGridView();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgBTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numGHS = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridBuyOrder)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGHS)).BeginInit();
            this.SuspendLayout();
            // 
            // gridBuyOrder
            // 
            this.gridBuyOrder.AllowUserToAddRows = false;
            this.gridBuyOrder.AllowUserToDeleteRows = false;
            this.gridBuyOrder.AllowUserToResizeRows = false;
            this.gridBuyOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBuyOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Price,
            this.Amount,
            this.TotalAmount,
            this.BTC,
            this.TotalBTC,
            this.AvgBTC});
            this.gridBuyOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBuyOrder.Location = new System.Drawing.Point(0, 0);
            this.gridBuyOrder.Name = "gridBuyOrder";
            this.gridBuyOrder.ReadOnly = true;
            this.gridBuyOrder.RowHeadersVisible = false;
            this.gridBuyOrder.RowTemplate.Height = 23;
            this.gridBuyOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBuyOrder.Size = new System.Drawing.Size(540, 221);
            this.gridBuyOrder.TabIndex = 6;
            //this.gridBuyOrder.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gridBuyOrder_Scroll);
            this.gridBuyOrder.DoubleClick += new System.EventHandler(this.gridBuyOrder_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.gridBuyOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 221);
            this.panel1.TabIndex = 9;
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
            this.groupBox1.Size = new System.Drawing.Size(540, 41);
            this.groupBox1.TabIndex = 8;
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
            // BuyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 262);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "BuyForm";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockRight;
            this.Text = "买单";
            this.Load += new System.EventHandler(this.BuyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBuyOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGHS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBuyOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgBTC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numGHS;
        private System.Windows.Forms.Label label1;
    }
}