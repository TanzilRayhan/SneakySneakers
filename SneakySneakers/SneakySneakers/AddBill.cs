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
    public partial class AddBill : Form
    {
        private DataAccess Da { get; set; }
        public AddBill()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        private void ClearAll()
        {
            this.txtBillingId.Clear();
            this.txtOrderId.Clear();
            this.txtTotalAmount.Clear();
            this.txtDiscount.Clear();
        }

        private void AddBill_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertBill_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into Billing values('" + this.txtBillingId.Text + "', '" + this.txtOrderId.Text + "', " + this.txtTotalAmount.Text + ",'" + this.txtDiscount.Text + "');";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                {
                    MessageBox.Show("Bill has been added properly");
                    return;
                }

                else
                    MessageBox.Show("Bill insertion failed");
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occurred:\n" + exc.Message);
            }
        }
    }
}
