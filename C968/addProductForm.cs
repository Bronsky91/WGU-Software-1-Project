using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968
{
    public partial class addProductForm : Form
    {
        public mainForm mainFormObject;
        public addProductForm()
        {
            InitializeComponent();
        }

        private void addProductForm_Load(object sender, EventArgs e)
        {
            ArrayList allParts = Inventory.getAllParts();
            foreach (Part p in allParts)
            {
                addToTable(p, addPartsTable);
            }
        }

        private void saveProduct_Click(object sender, EventArgs e)
        {
            // Converts textbox values to integars
            int invInStock = Int32.Parse(invTextBox.Text);
            int minStock = 0;
            try
            {
                minStock = Int32.Parse(minTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please only type numbers in min field, " + minTextBox.Text + " is not a number", "Min Field Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int maxStock = Int32.Parse(maxTextBox.Text);

            // Creates Product with data inputted from textboxes
            Product newProduct = new Product();
            newProduct.setProductID(Inventory.createProductID());
            newProduct.setName(nameTextBox.Text);
            newProduct.setPrice(Double.Parse(priceTextBox.Text));
            newProduct.setMax(maxStock);
            newProduct.setMin(minStock);

            if (invInStock <= maxStock && invInStock >= minStock)
                newProduct.setInStock(invInStock);

            // Adds currently selectd parts to product associated parts
            foreach (DataGridViewRow row in currentPartsTable.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    newProduct.addAssociatedPart(Inventory.lookupPart(
                                        Int32.Parse(row.Cells[0].Value.ToString())
                                        ));
                }
            }
       
            // Inserts Product into Mainform Product Table and productsList
            mainFormObject.addProductTableRow(newProduct);
            Inventory.addProduct(newProduct);

            // Closes add product form
            this.Close();
        }

        private void AddPart_Click(object sender, EventArgs e)
        {
            int selectedPartID = Int32.Parse(addPartsTable.Rows[addPartsTable.CurrentCell.RowIndex].Cells[addPartsTable.CurrentCell.ColumnIndex].Value.ToString());
            var selectedPart = Inventory.lookupPart(selectedPartID);
            addToTable(selectedPart, currentPartsTable);
        }

        private void searchPart_Click(object sender, EventArgs e)
        {
            string searchValue = partsSearch.Text;
            foreach (DataGridViewRow row in addPartsTable.Rows)
            {
                if ((string)row.Cells[0].Value == searchValue)
                {
                    row.Selected = true;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void deletePart_Click(object sender, EventArgs e)
        {
            currentPartsTable.Rows.Remove(currentPartsTable.CurrentRow);
        }

        private void cancelAddProductForm_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }

        public void addToTable(Part part, DataGridView table)
        {
            string[] row = {
                part.getPartID().ToString(),
                part.getName(),
                part.getInStock().ToString(),
                part.getPrice().ToString()
            };

            table.Rows.Add(row);
        }


    }
}
