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
    public partial class modifyProductForm : Form
    {
        public mainForm mainFormObject;
        public int selectedProductID;

        public modifyProductForm()
        {
            InitializeComponent();
        }

        private void modifyProductForm_Load(object sender, EventArgs e)
        {
            Product selectedProduct = Inventory.lookupProduct(selectedProductID);

            // Populates form with the selected product details
            idTextBox.Text = selectedProduct.getProductID().ToString();
            nameTextBox.Text = selectedProduct.getName();
            invTextBox.Text = selectedProduct.getInStock().ToString();
            priceTextBox.Text = selectedProduct.getPrice().ToString();
            maxTextBox.Text = selectedProduct.getMax().ToString();
            minTextBox.Text = selectedProduct.getMin().ToString();

            // Populates all parts table
            ArrayList allParts = Inventory.getAllParts();
            foreach (Part p in allParts)
            {
                addToTable(p, addPartsTable);
            }

            // Populates current parts table
            ArrayList associatedParts = selectedProduct.getAssociatedParts();
            foreach (Part p in associatedParts)
            {
                addToTable(p, currentPartsTable);
            }
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

        private void partsSearch_Click(object sender, EventArgs e)
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

        private void addPart_Click(object sender, EventArgs e)
        {
            int selectedPartID = Int32.Parse(addPartsTable.Rows[addPartsTable.CurrentCell.RowIndex].Cells[addPartsTable.CurrentCell.ColumnIndex].Value.ToString());
            var selectedPart = Inventory.lookupPart(selectedPartID);
            addToTable(selectedPart, currentPartsTable);
        }

        private void deletePart_Click(object sender, EventArgs e)
        {
            currentPartsTable.Rows.Remove(currentPartsTable.CurrentRow);
        }

        private void saveProduct_Click(object sender, EventArgs e)
        {
            // Converts textbox values to integars
            int invInStock = Int32.Parse(invTextBox.Text);
            int minStock = Int32.Parse(minTextBox.Text);
            int maxStock = Int32.Parse(maxTextBox.Text);

            // Creates Product with data inputted from textboxes
            Product newProduct = new Product();
            newProduct.setProductID(Int32.Parse(idTextBox.Text));
            newProduct.setName(nameTextBox.Text);
            newProduct.setPrice(Double.Parse(priceTextBox.Text));
            newProduct.setMax(maxStock);
            newProduct.setMin(minStock);

            if (invInStock <= maxStock && invInStock >= minStock)
                newProduct.setInStock(invInStock);

            // Adds currently selectd parts to product associated parts
            foreach (DataGridViewRow row in currentPartsTable.Rows)
            {
                if (row.Cells[0].Value == null)
                    continue;

                newProduct.updateAssociatedPart(
                    Int32.Parse(row.Cells[0].Value.ToString()),
                    Inventory.lookupPart(Int32.Parse(row.Cells[0].Value.ToString()))
                    );
            }

            // Inserts Product into Mainform Product Table and productsList
            mainFormObject.removeCurrentProduct();
            mainFormObject.addProductTableRow(newProduct);
            Inventory.updateProduct(newProduct.getProductID(), newProduct);

            // Closes add product form
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
