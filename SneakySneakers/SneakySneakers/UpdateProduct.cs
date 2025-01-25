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
    public partial class UpdateProduct : Form
    {

        private DataAccess Da { get; set; }
        public UpdateProduct()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void ProductInventory_Click(object sender, EventArgs e)
        {

        }
        private void ClearAll()
        {
            this.txtProductId.Clear();
            this.txtProductName.Text = "";
            this.txtPrice.Clear();
            this.txtStock.Clear();
        }
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtProductId.Text) || String.IsNullOrEmpty(this.txtProductName.Text)
            || String.IsNullOrEmpty(this.txtPrice.Text) || String.IsNullOrEmpty(this.txtStock.Text))

                return false;
            else
                return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query = null;
                var sql = "select * from Product where ProductId = '" + this.txtProductId.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    // Update query
                    query = @"update Product
                      set ProductId = '" + this.txtProductId.Text + @"',
                          ProductName = '" + this.txtProductName.Text + @"',
                          Price = " + this.txtPrice.Text + @",
                          Stock = '" + this.txtStock.Text + @"'
                      where ProductId = '" + this.txtProductId.Text + "';";

                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("Product data has been updated properly");
                    else
                        MessageBox.Show("Product data update failed");
                }
                else
                {
                    MessageBox.Show("Product with the given ID does not exist.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occurred:\n" + exc.Message);
            }
        }

    }
}
