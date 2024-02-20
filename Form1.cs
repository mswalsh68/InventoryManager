using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class inventotyManagementStudio : Form
    {

        DataTable inventory = new DataTable();
        public inventotyManagementStudio()
        {
            InitializeComponent();
        }
        private void inventoryManagementStudio_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("SKU");
            inventory.Columns.Add("Name");
            inventory.Columns.Add("Category");
            inventory.Columns.Add("Price");
            inventory.Columns.Add("Description");
            inventory.Columns.Add("Quantity");


            inventoryGridView.DataSource = inventory;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            itemSku.Text = "";
            itemName.Text = "";
            itemCategory.SelectedIndex = -1;
            itemPrice.Text = "";
            itemDescription.Text = "";
            itemQuantity.Text = "";
        
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // save values from fiends into variables
            String sku = itemSku.Text;
            String name =itemName.Text;
            String category = (string)itemCategory.SelectedItem;
            String price = itemPrice.Text;
            String description = itemDescription.Text;
            String quantity = itemQuantity.Text;

            // add values to the table
            inventory.Rows.Add(sku, name, category, price, description, quantity);

            // clear fields after save
            newButton_Click(sender, e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                inventory.Rows[inventoryGridView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err); ;
            }
        }

        private void inventoryGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                itemSku.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
                itemName.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[1].ToString();

                String itemToLookFor = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[2].ToString();
                itemCategory.SelectedIndex = itemCategory.Items.IndexOf(itemToLookFor);

                itemPrice.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[3].ToString();
                itemDescription.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[4].ToString();
                itemQuantity.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[5].ToString();

                
            }
            catch (Exception err)
            {
                Console.WriteLine("There has been an error: " + err);

            }
        }

    }
}
