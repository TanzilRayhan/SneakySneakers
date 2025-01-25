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
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {

            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {

        }

        private void DashBoardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ProductUserControl productuserControl = new ProductUserControl();
            DashboardPanel.Controls.Clear();
            DashboardPanel.Controls.Add(productuserControl);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void DashBoardForm_AutoSizeChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OrdersUserControl orderuserControl = new OrdersUserControl();
            DashboardPanel.Controls.Clear();
            DashboardPanel.Controls.Add(orderuserControl);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            BillingUserControl billinguserControl = new BillingUserControl();
            DashboardPanel.Controls.Clear();
            DashboardPanel.Controls.Add(billinguserControl);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            UsersUserControl usersuserControl = new UsersUserControl();
            DashboardPanel.Controls.Clear();
            DashboardPanel.Controls.Add(usersuserControl);
        }
    }
}
