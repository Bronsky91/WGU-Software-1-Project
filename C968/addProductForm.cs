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
            int invInStock = Int32.Parse(invTextBox.Text);
            int minStock = Int32.Parse(minTextBox.Text);
            int maxStock = Int32.Parse(maxTextBox.Text);

            Product newProduct = new Product();
            newProduct.setProductID(Int32.Parse(idTextBox.Text));
            newProduct.setName(nameTextBox.Text);
            newProduct.setPrice(Double.Parse(priceTextBox.Text));
            newProduct.setMax(maxStock);
            newProduct.setMin(minStock);

            if (invInStock < maxStock && invInStock > minStock)
            {
                newProduct.setInStock(invInStock);
            }

            mainFormObject.addProductTableRow(newProduct);

            // Closes add product form
            this.Close();
        }
    }
}
