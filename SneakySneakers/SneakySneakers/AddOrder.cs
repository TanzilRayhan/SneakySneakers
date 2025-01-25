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
    public partial class AddOrder : Form
    {
        private DataAccess Da { get; set; }
        public AddOrder()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void ClearAll()
        {
            this.txtOrderId.Clear();
            this.txtProductId.Clear();
            this.txtEmployeeId.Clear();
            this.txtStock.Clear();
        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtOrderId.Text) || String.IsNullOrEmpty(this.txtProductId.Text) ||  String.IsNullOrEmpty(this.txtEmployeeId.Text)
            ||  String.IsNullOrEmpty(this.txtStock.Text))

                return false;
            else
                return true;
        }
        private void btnInsertOrder_Click(object sender, EventArgs e)
        {

            try
            {
                string formattedDate = this.dptOrderDate.Value.ToString("yyyy-MM-dd");

                string query = "insert into OrderProduct values('" + this.txtOrderId.Text + "', '" + this.txtProductId.Text + "', '" + this.txtStock.Text + "', '" + formattedDate + "','" + this.txtEmployeeId.Text + "');";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                {
                    MessageBox.Show("Order has been added properly");
                    return;
                }

                else
                    MessageBox.Show("Order insertion failed");
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occurred:\n" + exc.Message);
            }

        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
    }
    
}
