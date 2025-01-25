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
    public partial class ProductUserControl : UserControl
    {
        private DataAccess Da { get; set; }
        public ProductUserControl()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        public void PopulateGridView(string sql = "select * from Product;")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.DataSource = ds.Tables[0];
        }

 

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void productSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where ProductId = '" + this.txtSearchProduct.Text + "';";
            this.PopulateGridView(sql);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvProduct.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var id = this.dgvProduct.CurrentRow.Cells[0].Value.ToString();
                var query = "delete from Product where ProductId = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show("Product has been removed from the list.");
                else
                            MessageBox.Show("Product data remove failed");

                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvProduct.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a row first to Update the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure to Update the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
                return;
            else
            {
                UpdateProduct updateProduct = new UpdateProduct();
                updateProduct.ShowDialog();
            }
           
        }

        private void btnRefreshProduct_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }
    }
}
