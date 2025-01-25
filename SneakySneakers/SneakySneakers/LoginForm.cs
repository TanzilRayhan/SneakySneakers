using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakySneakers
{
    public partial class LoginForm : Form
    {
        private DataAccess Da { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "select * from UserInfo where UserId = '" + this.txtUserID.Text + "' and Password = '" + this.txtPassword.Text + "';";
            DataSet ds = this.Da.ExecuteQuery(sql);

            if (ds.Tables[0].Rows.Count == 1)
            {
               

                var name = ds.Tables[0].Rows[0][2].ToString();
                var role = ds.Tables[0].Rows[0][4].ToString();
                if (role == "Admin")
                {
                    this.Hide();
                    new AdminDashboardForm().Show();
                }
                else if(role == "Employee")
                {
                    this.Hide();
                    new EmployeeDashboardForm().Show();
                }

            }
            else
            {
                MessageBox.Show("Invalid User");
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
