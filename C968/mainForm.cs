using System;
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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        public void addProductTableRow(Product product)
        {
            string[] row = {
                product.getProductID().ToString(),
                product.getName(),
                product.getInStock().ToString(),
                product.getPrice().ToString()
            };

            productsTable.Rows.Add(row);
        }

        public void addPartTableRow(Part part)
        {
            string[] row = {
                part.getPartID().ToString(),
                part.getName(),
                part.getInStock().ToString(),
                part.getPrice().ToString()
            };

            partsTable.Rows.Add(row);
        }

        private void addPartsButton_Click(object sender, EventArgs e)
        {
            addPartForm addPartForm = new addPartForm();
            addPartForm.mainFormObject = this;
            addPartForm.Show();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            addProductForm addProductForm = new addProductForm();
            addProductForm.mainFormObject = this;
            addProductForm.Show();
        }

        private void exitMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchParts_Click(object sender, EventArgs e)
        {
            string searchValue = searchPartsBar.Text;
            foreach(DataGridViewRow row in partsTable.Rows)
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

        private void modifyPart_Click(object sender, EventArgs e)
        {
            modifyPartForm modifyPartForm = new modifyPartForm();
            modifyPartForm.mainFormObject = this;
            modifyPartForm.selectedPartID = Int32.Parse(partsTable.Rows[partsTable.CurrentCell.RowIndex].Cells[partsTable.CurrentCell.ColumnIndex].Value.ToString());
            modifyPartForm.Show();
        }

        public void removeCurrentPart()
        {
            partsTable.Rows.Remove(partsTable.CurrentRow);
        }

        private void deletePart_Click(object sender, EventArgs e)
        {
            removeCurrentPart();
        }
    }
}
