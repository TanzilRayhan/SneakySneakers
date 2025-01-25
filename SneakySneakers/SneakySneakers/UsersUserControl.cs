using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakySneakers
{
    public partial class UsersUserControl : UserControl
    {
        private DataAccess Da { get; set; }
        public UsersUserControl()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        public void PopulateGridView(string sql = "select * from UserInfo;")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.DataSource = ds.Tables[0];
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void userSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from UserInfo where UserId = '" + this.txtUserSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }

        private void btnRefreshUser_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnUserRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvUsers.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var id = this.dgvUsers.CurrentRow.Cells[0].Value.ToString();
                var query = "delete from UserInfo where UserId = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show("User has been removed from the list.");
                else
                    MessageBox.Show("User data remove failed");

                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
        }

        private void btUserEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvUsers.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a row first to Update the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure to Update the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
                return;
            else
            {
                UpdateUser updateUser = new UpdateUser();
                updateUser.ShowDialog();
            }
        }
    }
}
