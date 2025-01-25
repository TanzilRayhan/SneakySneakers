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
    public partial class UpdateUser : Form
    {
        private DataAccess Da { get; set; }
        public UpdateUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateUser_Click_1(object sender, EventArgs e)
        {

            try
            {
                string query = null;
                var sql = "select * from UserInfo where UserId = '" + this.txtUserId.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    // Update query
                    query = @"update UserInfo
                      set UserId = '" + this.txtUserId.Text + @"',
                          UserName = '" + this.txtUserName.Text + @"',
                          Password = '" + this.txtPassword.Text + @"',
                          EmailAddress = '" + this.txtEmailAddress.Text + @"',
                          Role = '" + this.txtRole.Text + @"'
                      where UserId = '" + this.txtUserId.Text + "';";

                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("User data has been updated properly");
                    else
                        MessageBox.Show("User data update failed");
                }
                else
                {
                    MessageBox.Show("User with the given ID does not exist.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occurred:\n" + exc.Message);
            }
        }
    }
}
