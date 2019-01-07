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
    public partial class addPartForm : Form
    {
        public mainForm mainFormObject;
        public addPartForm()
        {
            InitializeComponent();
        }
        
        // Updates label text dependign on which radio button is checked
        private void companyOrMachineLabelUpdate()
        {
            if (inHouseRadioButton.Checked)
                companyMachineLabel.Text = "Machine ID";
            else
                companyMachineLabel.Text = "Company Name";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            int invInStock = Int32.Parse(InvTextBox.Text);
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

            BasePart b = new BasePart();
            b.partID = Inventory.createPartID();
            b.name = nameTextBox.Text;
            b.price = Double.Parse(PriceTextBox.Text);
            b.min = minStock;
            b.max = maxStock;
            if (invInStock <= maxStock && invInStock >= minStock)
                b.inStock = Int32.Parse(InvTextBox.Text);

            if (inHouseRadioButton.Checked)
            {
                Inhouse newPart = new Inhouse(b, Int32.Parse(MachineCompanyIDTextBox.Text));
                Inventory.addPart(newPart);
                mainFormObject.addPartTableRow(newPart);
            }
            else
            {
                Outsourced newPart = new Outsourced(b, MachineCompanyIDTextBox.Text);
                Inventory.addPart(newPart);
                mainFormObject.addPartTableRow(newPart);
            }
            Close();
        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            companyOrMachineLabelUpdate();
        }

        private void inHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            companyOrMachineLabelUpdate();
        }

        private void cancelAddPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
