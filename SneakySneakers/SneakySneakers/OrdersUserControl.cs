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
    public partial class OrdersUserControl : UserControl
    {
        private DataAccess Da { get; set; }
        public OrdersUserControl()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        public void PopulateGridView(string sql = "select * from OrderProduct;")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvOrders.AutoGenerateColumns = false;
            this.dgvOrders.DataSource = ds.Tables[0];
        }

        private void orderSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from OrderProduct where OrderId = '" + this.txtSearchOrder.Text + "';";
            this.PopulateGridView(sql);
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AddOrder addOrder = new AddOrder();
            addOrder.ShowDialog();
        }

        private void btnRefreshOrder_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnOrderRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvOrders.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var id = this.dgvOrders.CurrentRow.Cells[0].Value.ToString();
                var query = "delete from OrderProduct where OrderId = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show("Order has been removed from the list.");
                else
                    MessageBox.Show("Order data remove failed");

                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
        }

        private void btnOrderEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvOrders.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a row first to Update the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure to Update the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
                return;
            else
            {
                UpdateOrder updateOrder = new UpdateOrder();
                updateOrder.ShowDialog();
            }
        }
    }
}
