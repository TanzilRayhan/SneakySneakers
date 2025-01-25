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
    public partial class AddProduct : Form
    {
        private DataAccess Da { get; set; }
        public AddProduct()
        {
            InitializeComponent();
            this.Da = new DataAccess();
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

        private void AddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }

        private void btnInsertProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into Product values('" + this.txtProductId.Text + "', '" + this.txtProductName.Text + "', " + this.txtPrice.Text + ",'" + this.txtStock.Text + "');";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                {
                    MessageBox.Show("Product has been added properly");
                    return;
                }
                    
                else
                    MessageBox.Show("Product insertion failed");
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occurred:\n" + exc.Message);
            }

        }
    }
}
