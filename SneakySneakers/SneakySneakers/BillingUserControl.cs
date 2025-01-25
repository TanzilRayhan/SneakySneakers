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
    public partial class BillingUserControl : UserControl
    {
        private DataAccess Da { get; set; }
        public BillingUserControl()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        public void PopulateGridView(string sql = "select * from Billing;")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvBilling.AutoGenerateColumns = false;
            this.dgvBilling.DataSource = ds.Tables[0];
        }
       
        private void billingSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Billing where BillingId = '" + this.txtSearchBilling.Text + "';";
            this.PopulateGridView(sql);
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            AddBill addBill = new AddBill();
            addBill.ShowDialog();
        }

        private void btnRefreshBill_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }
    }
}
