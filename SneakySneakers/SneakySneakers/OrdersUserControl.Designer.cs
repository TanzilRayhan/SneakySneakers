namespace SneakySneakers
{
    partial class OrdersUserControl
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
            this.btnRefreshOrder = new System.Windows.Forms.PictureBox();
            this.btnOrderEdit = new System.Windows.Forms.PictureBox();
            this.btnOrderRemove = new System.Windows.Forms.PictureBox();
            this.btnAddOrder = new System.Windows.Forms.PictureBox();
            this.orderSearch = new System.Windows.Forms.Button();
            this.txtSearchOrder = new System.Windows.Forms.TextBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrderEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrderRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(200)))));
            this.panel2.Controls.Add(this.btnRefreshOrder);
            this.panel2.Controls.Add(this.btnOrderEdit);
            this.panel2.Controls.Add(this.btnOrderRemove);
            this.panel2.Controls.Add(this.btnAddOrder);
            this.panel2.Controls.Add(this.orderSearch);
            this.panel2.Controls.Add(this.txtSearchOrder);
            this.panel2.Location = new System.Drawing.Point(-3, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1188, 100);
            this.panel2.TabIndex = 4;
            // 
            // btnRefreshOrder
            // 
            this.btnRefreshOrder.Image = global::SneakySneakers.Properties.Resources.refresh;
            this.btnRefreshOrder.Location = new System.Drawing.Point(683, 22);
            this.btnRefreshOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshOrder.Name = "btnRefreshOrder";
            this.btnRefreshOrder.Size = new System.Drawing.Size(100, 50);
            this.btnRefreshOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefreshOrder.TabIndex = 7;
            this.btnRefreshOrder.TabStop = false;
            this.btnRefreshOrder.Click += new System.EventHandler(this.btnRefreshOrder_Click);
            // 
            // btnOrderEdit
            // 
            this.btnOrderEdit.Image = global::SneakySneakers.Properties.Resources.edit;
            this.btnOrderEdit.Location = new System.Drawing.Point(803, 22);
            this.btnOrderEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderEdit.Name = "btnOrderEdit";
            this.btnOrderEdit.Size = new System.Drawing.Size(100, 50);
            this.btnOrderEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOrderEdit.TabIndex = 6;
            this.btnOrderEdit.TabStop = false;
            this.btnOrderEdit.Click += new System.EventHandler(this.btnOrderEdit_Click);
            // 
            // btnOrderRemove
            // 
            this.btnOrderRemove.Image = global::SneakySneakers.Properties.Resources.remove;
            this.btnOrderRemove.Location = new System.Drawing.Point(923, 22);
            this.btnOrderRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderRemove.Name = "btnOrderRemove";
            this.btnOrderRemove.Size = new System.Drawing.Size(100, 50);
            this.btnOrderRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOrderRemove.TabIndex = 5;
            this.btnOrderRemove.TabStop = false;
            this.btnOrderRemove.Click += new System.EventHandler(this.btnOrderRemove_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Image = global::SneakySneakers.Properties.Resources.add;
            this.btnAddOrder.Location = new System.Drawing.Point(1043, 22);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(100, 50);
            this.btnAddOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddOrder.TabIndex = 2;
            this.btnAddOrder.TabStop = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // orderSearch
            // 
            this.orderSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            this.orderSearch.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderSearch.ForeColor = System.Drawing.Color.White;
            this.orderSearch.Location = new System.Drawing.Point(425, 33);
            this.orderSearch.Name = "orderSearch";
            this.orderSearch.Size = new System.Drawing.Size(103, 37);
            this.orderSearch.TabIndex = 1;
            this.orderSearch.Text = "Search";
            this.orderSearch.UseVisualStyleBackColor = false;
            this.orderSearch.Click += new System.EventHandler(this.orderSearch_Click);
            // 
            // txtSearchOrder
            // 
            this.txtSearchOrder.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchOrder.Location = new System.Drawing.Point(31, 33);
            this.txtSearchOrder.Name = "txtSearchOrder";
            this.txtSearchOrder.Size = new System.Drawing.Size(363, 37);
            this.txtSearchOrder.TabIndex = 0;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AllowUserToResizeColumns = false;
            this.dgvOrders.AllowUserToResizeRows = false;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrders.ColumnHeadersHeight = 30;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.EmployeeId,
            this.Column1,
            this.Column4,
            this.OrderDate});
            this.dgvOrders.EnableHeadersVisualStyles = false;
            this.dgvOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            this.dgvOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(1185, 355);
            this.dgvOrders.TabIndex = 3;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "OrderId";
            this.Column2.HeaderText = "Order Id";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "EmployeeId";
            this.EmployeeId.HeaderText = "Employee Id";
            this.EmployeeId.MinimumWidth = 6;
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ProductId";
            this.Column1.HeaderText = "Product Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Stock";
            this.Column4.HeaderText = "Stock";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 155;
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.MinimumWidth = 6;
            this.OrderDate.Name = "OrderDate";
            // 
            // OrdersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvOrders);
            this.Name = "OrdersUserControl";
            this.Size = new System.Drawing.Size(1183, 452);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrderEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrderRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnAddOrder;
        private System.Windows.Forms.Button orderSearch;
        private System.Windows.Forms.TextBox txtSearchOrder;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.PictureBox btnOrderEdit;
        private System.Windows.Forms.PictureBox btnOrderRemove;
        private System.Windows.Forms.PictureBox btnRefreshOrder;
    }
}
