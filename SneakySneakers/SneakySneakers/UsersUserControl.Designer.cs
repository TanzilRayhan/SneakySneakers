namespace SneakySneakers
{
    partial class UsersUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefreshUser = new System.Windows.Forms.PictureBox();
            this.btUserEdit = new System.Windows.Forms.PictureBox();
            this.btnUserRemove = new System.Windows.Forms.PictureBox();
            this.btnAddUser = new System.Windows.Forms.PictureBox();
            this.userSearch = new System.Windows.Forms.Button();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btUserEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUserRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(200)))));
            this.panel2.Controls.Add(this.btnRefreshUser);
            this.panel2.Controls.Add(this.btUserEdit);
            this.panel2.Controls.Add(this.btnUserRemove);
            this.panel2.Controls.Add(this.btnAddUser);
            this.panel2.Controls.Add(this.userSearch);
            this.panel2.Controls.Add(this.txtUserSearch);
            this.panel2.Location = new System.Drawing.Point(-3, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1188, 100);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnRefreshUser
            // 
            this.btnRefreshUser.Image = global::SneakySneakers.Properties.Resources.refresh;
            this.btnRefreshUser.Location = new System.Drawing.Point(699, 25);
            this.btnRefreshUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshUser.Name = "btnRefreshUser";
            this.btnRefreshUser.Size = new System.Drawing.Size(100, 50);
            this.btnRefreshUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefreshUser.TabIndex = 11;
            this.btnRefreshUser.TabStop = false;
            this.btnRefreshUser.Click += new System.EventHandler(this.btnRefreshUser_Click);
            // 
            // btUserEdit
            // 
            this.btUserEdit.Image = global::SneakySneakers.Properties.Resources.edit;
            this.btUserEdit.Location = new System.Drawing.Point(819, 25);
            this.btUserEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUserEdit.Name = "btUserEdit";
            this.btUserEdit.Size = new System.Drawing.Size(100, 50);
            this.btUserEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btUserEdit.TabIndex = 10;
            this.btUserEdit.TabStop = false;
            this.btUserEdit.Click += new System.EventHandler(this.btUserEdit_Click);
            // 
            // btnUserRemove
            // 
            this.btnUserRemove.Image = global::SneakySneakers.Properties.Resources.remove;
            this.btnUserRemove.Location = new System.Drawing.Point(939, 25);
            this.btnUserRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserRemove.Name = "btnUserRemove";
            this.btnUserRemove.Size = new System.Drawing.Size(100, 50);
            this.btnUserRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUserRemove.TabIndex = 9;
            this.btnUserRemove.TabStop = false;
            this.btnUserRemove.Click += new System.EventHandler(this.btnUserRemove_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Image = global::SneakySneakers.Properties.Resources.add;
            this.btnAddUser.Location = new System.Drawing.Point(1059, 25);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(100, 50);
            this.btnAddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.TabStop = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // userSearch
            // 
            this.userSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            this.userSearch.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSearch.ForeColor = System.Drawing.Color.White;
            this.userSearch.Location = new System.Drawing.Point(425, 33);
            this.userSearch.Name = "userSearch";
            this.userSearch.Size = new System.Drawing.Size(103, 37);
            this.userSearch.TabIndex = 1;
            this.userSearch.Text = "Search";
            this.userSearch.UseVisualStyleBackColor = false;
            this.userSearch.Click += new System.EventHandler(this.userSearch_Click);
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserSearch.Location = new System.Drawing.Point(31, 33);
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(363, 37);
            this.txtUserSearch.TabIndex = 0;
            this.txtUserSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeColumns = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.ColumnHeadersHeight = 30;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Role});
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(1185, 355);
            this.dgvUsers.TabIndex = 3;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UserId";
            this.Column1.HeaderText = "User Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Password";
            this.Column3.HeaderText = "Password";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "UserName";
            this.Column2.HeaderText = "User Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "EmailAddress";
            this.Column4.HeaderText = "Email Address";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            // 
            // UsersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvUsers);
            this.Name = "UsersUserControl";
            this.Size = new System.Drawing.Size(1183, 452);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btUserEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUserRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button userSearch;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.PictureBox btnRefreshUser;
        private System.Windows.Forms.PictureBox btUserEdit;
        private System.Windows.Forms.PictureBox btnUserRemove;
        private System.Windows.Forms.PictureBox btnAddUser;
    }
}
