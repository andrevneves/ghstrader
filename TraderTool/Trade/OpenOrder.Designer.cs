namespace BTCTrade
{
    partial class OpenOrder
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Command = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MessageBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Sound = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pending = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingBTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Command,
            this.MessageBox,
            this.Section,
            this.Sound,
            this.ID,
            this.Type,
            this.Amount,
            this.Pending,
            this.Price,
            this.TotalBTC,
            this.RemainingBTC});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(742, 262);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Command
            // 
            this.Command.HeaderText = "操作";
            this.Command.Name = "Command";
            this.Command.Text = "取消";
            this.Command.ToolTipText = "取消";
            this.Command.UseColumnTextForButtonValue = true;
            this.Command.Width = 50;
            // 
            // MessageBox
            // 
            this.MessageBox.FalseValue = "false";
            this.MessageBox.HeaderText = "提示";
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.TrueValue = "true";
            this.MessageBox.Width = 40;
            // 
            // Section
            // 
            this.Section.FalseValue = "false";
            this.Section.HeaderText = "部分提示";
            this.Section.Name = "Section";
            this.Section.TrueValue = "true";
            this.Section.Width = 60;
            // 
            // Sound
            // 
            this.Sound.FalseValue = "false";
            this.Sound.HeaderText = "声音";
            this.Sound.Name = "Sound";
            this.Sound.TrueValue = "true";
            this.Sound.Width = 40;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "类型";
            this.Type.Name = "Type";
            this.Type.Width = 40;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "GHS数量";
            this.Amount.Name = "Amount";
            this.Amount.Width = 80;
            // 
            // Pending
            // 
            this.Pending.DataPropertyName = "Pending";
            this.Pending.HeaderText = "剩余GHS";
            this.Pending.Name = "Pending";
            this.Pending.Width = 80;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "价格";
            this.Price.Name = "Price";
            this.Price.Width = 80;
            // 
            // TotalBTC
            // 
            this.TotalBTC.DataPropertyName = "TotalBTC";
            this.TotalBTC.HeaderText = "总BTC";
            this.TotalBTC.Name = "TotalBTC";
            // 
            // RemainingBTC
            // 
            this.RemainingBTC.DataPropertyName = "RemainingBTC";
            this.RemainingBTC.HeaderText = "剩于BTC";
            this.RemainingBTC.Name = "RemainingBTC";
            // 
            // OpenOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 262);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "OpenOrder";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockBottom;
            this.Text = "订单取消";
            this.Load += new System.EventHandler(this.OpenOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewButtonColumn Command;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MessageBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Section;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sound;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pending;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingBTC;
    }
}