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
    public partial class addProductForm : Form
    {
        public mainForm mainFormObject;
        public addProductForm()
        {
            InitializeComponent();
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

            // Inserts Product into Mainform Product Table
            mainFormObject.addProductTableRow(newProduct);

            // Closes add product form
            this.Close();
        }

        private void AddPart_Click(object sender, EventArgs e)
        {

        }

        private void searchPart_Click(object sender, EventArgs e)
        {

        }

        private void deletePart_Click(object sender, EventArgs e)
        {

        }

        private void cancelAddProductForm_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
