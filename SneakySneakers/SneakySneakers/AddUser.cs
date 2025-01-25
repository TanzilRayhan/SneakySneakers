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
    public partial class AddUser : Form
    {
        private DataAccess Da { get; set; }
        public AddUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        private void ClearAll()
        {
            this.txtUserId.Clear();
            this.txtUserName.Text = "";
            //this.txtEmailAddress.Clear();
            this.txtRole.Clear();
        }

        private void OrderInventory_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtProductId_TextChanged(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmailAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void txtEmployeeId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsertId_Click(object sender, EventArgs e)
        {

        }

        private void txtOrderId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into UserInfo values('" + this.txtUserId.Text + "', '" + this.txtUserName.Text + "','" + this.txtEmailAddress.Text + "', " + this.txtPassword.Text + ",'" + this.txtRole.Text + "');";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                {
                    MessageBox.Show("User has been added properly");
                    return;
                }

                else
                    MessageBox.Show("User insertion failed");
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occurred:\n" + exc.Message);
            }
        }

        private void btnClearUser_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
    }
}
