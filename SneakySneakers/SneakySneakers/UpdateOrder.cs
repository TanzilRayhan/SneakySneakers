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
    public partial class UpdateOrder : Form
    {
        private DataAccess Da { get; set; }

        public UpdateOrder()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                string query = null;
                var sql = "select * from OrderProduct where OrderId = '" + this.txtOrderId.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    // Update query
                    query = @"update OrderProduct
                      set OrderId = '" + this.txtOrderId.Text + @"',
                          ProductId = '" + this.txtProductId.Text + @"',
                          EmployeeId = '" + this.txtEmployeeId.Text + @"',
                          Stock = '" + this.txtStock.Text + @"'
                      where OrderId = '" + this.txtOrderId.Text + "';";

                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("Order data has been updated properly");
                    else
                        MessageBox.Show("Order data update failed");
                }
                else
                {
                    MessageBox.Show("Order with the given ID does not exist.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occurred:\n" + exc.Message);
            }
        }
    }
}
