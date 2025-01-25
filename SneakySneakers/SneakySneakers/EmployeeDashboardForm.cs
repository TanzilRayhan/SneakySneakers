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
    public partial class EmployeeDashboardForm : Form
    {
        public EmployeeDashboardForm()
        {
            InitializeComponent();
        }

        private void EmployeeDashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ProductImage_Click(object sender, EventArgs e)
        {
            ProductUserControl productuserControl = new ProductUserControl();
            DashboardPanel.Controls.Clear();
            DashboardPanel.Controls.Add(productuserControl);
        }

        private void OrderImage_Click(object sender, EventArgs e)
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
    }
}
