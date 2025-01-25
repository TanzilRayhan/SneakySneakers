namespace SneakySneakers
{
    partial class BillingUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddBill = new System.Windows.Forms.PictureBox();
            this.billingSearch = new System.Windows.Forms.Button();
            this.txtSearchBilling = new System.Windows.Forms.TextBox();
            this.dgvBilling = new System.Windows.Forms.DataGridView();
            this.BillingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillingDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefreshBill = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshBill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(200)))));
            this.panel2.Controls.Add(this.btnRefreshBill);
            this.panel2.Controls.Add(this.btnAddBill);
            this.panel2.Controls.Add(this.billingSearch);
            this.panel2.Controls.Add(this.txtSearchBilling);
            this.panel2.Location = new System.Drawing.Point(-3, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1188, 100);
            this.panel2.TabIndex = 6;
            // 
            // btnAddBill
            // 
            this.btnAddBill.Image = global::SneakySneakers.Properties.Resources.add;
            this.btnAddBill.Location = new System.Drawing.Point(1043, 22);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(100, 50);
            this.btnAddBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddBill.TabIndex = 2;
            this.btnAddBill.TabStop = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // billingSearch
            // 
            this.billingSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            this.billingSearch.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingSearch.ForeColor = System.Drawing.Color.White;
            this.billingSearch.Location = new System.Drawing.Point(425, 33);
            this.billingSearch.Name = "billingSearch";
            this.billingSearch.Size = new System.Drawing.Size(103, 37);
            this.billingSearch.TabIndex = 1;
            this.billingSearch.Text = "Search";
            this.billingSearch.UseVisualStyleBackColor = false;
            this.billingSearch.Click += new System.EventHandler(this.billingSearch_Click);
            // 
            // txtSearchBilling
            // 
            this.txtSearchBilling.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBilling.Location = new System.Drawing.Point(31, 33);
            this.txtSearchBilling.Name = "txtSearchBilling";
            this.txtSearchBilling.Size = new System.Drawing.Size(363, 37);
            this.txtSearchBilling.TabIndex = 0;
            // 
            // dgvBilling
            // 
            this.dgvBilling.AllowUserToAddRows = false;
            this.dgvBilling.AllowUserToDeleteRows = false;
            this.dgvBilling.AllowUserToResizeColumns = false;
            this.dgvBilling.AllowUserToResizeRows = false;
            this.dgvBilling.BackgroundColor = System.Drawing.Color.White;
            this.dgvBilling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBilling.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBilling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBilling.ColumnHeadersHeight = 30;
            this.dgvBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBilling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillingId,
            this.OrderId,
            this.TotalAmount,
            this.BillingDiscount});
            this.dgvBilling.EnableHeadersVisualStyles = false;
            this.dgvBilling.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            this.dgvBilling.Location = new System.Drawing.Point(0, 0);
            this.dgvBilling.Name = "dgvBilling";
            this.dgvBilling.RowHeadersWidth = 51;
            this.dgvBilling.RowTemplate.Height = 24;
            this.dgvBilling.Size = new System.Drawing.Size(1185, 355);
            this.dgvBilling.TabIndex = 5;
            // 
            // BillingId
            // 
            this.BillingId.DataPropertyName = "BillingId";
            this.BillingId.HeaderText = "Billing Id";
            this.BillingId.MinimumWidth = 6;
            this.BillingId.Name = "BillingId";
            this.BillingId.Width = 200;
            // 
            // OrderId
            // 
            this.OrderId.DataPropertyName = "OrderId";
            this.OrderId.HeaderText = "Order Id";
            this.OrderId.MinimumWidth = 6;
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            this.OrderId.Width = 200;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "TotalAmount";
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.MinimumWidth = 6;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.Width = 250;
            // 
            // BillingDiscount
            // 
            this.BillingDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BillingDiscount.DataPropertyName = "BillingDiscount";
            this.BillingDiscount.HeaderText = "Discount";
            this.BillingDiscount.MinimumWidth = 6;
            this.BillingDiscount.Name = "BillingDiscount";
            // 
            // btnRefreshBill
            // 
            this.btnRefreshBill.Image = global::SneakySneakers.Properties.Resources.refresh;
            this.btnRefreshBill.Location = new System.Drawing.Point(918, 22);
            this.btnRefreshBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshBill.Name = "btnRefreshBill";
            this.btnRefreshBill.Size = new System.Drawing.Size(100, 50);
            this.btnRefreshBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefreshBill.TabIndex = 12;
            this.btnRefreshBill.TabStop = false;
            this.btnRefreshBill.Click += new System.EventHandler(this.btnRefreshBill_Click);
            // 
            // BillingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvBilling);
            this.Name = "BillingUserControl";
            this.Size = new System.Drawing.Size(1183, 452);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnAddBill;
        private System.Windows.Forms.Button billingSearch;
        private System.Windows.Forms.TextBox txtSearchBilling;
        private System.Windows.Forms.DataGridView dgvBilling;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillingDiscount;
        private System.Windows.Forms.PictureBox btnRefreshBill;
    }
}
