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

        private void addPartsButton_Click(object sender, EventArgs e)
        {
            addPartForm addPartForm = new addPartForm();
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
    }
}
