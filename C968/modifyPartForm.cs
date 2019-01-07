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
    public partial class modifyPartForm : Form
    {
        public mainForm mainFormObject;
        public int selectedPartID;

        public modifyPartForm()
        {
            InitializeComponent();
        }

        private void modifyPartForm_Load(object sender, EventArgs e)
        {
            var selectedPart = Inventory.lookupPart(selectedPartID);

            // Populates form with selected part details
            partIDTextBox.Text = selectedPart.getPartID().ToString();
            nameTextBox.Text = selectedPart.getName();
            invTextBox.Text = selectedPart.getInStock().ToString();
            priceTextBox.Text = selectedPart.getPrice().ToString();
            maxTextBox.Text = selectedPart.getMax().ToString();
            minTextBox.Text = selectedPart.getMin().ToString();
            if (selectedPart is Inhouse)
            {
                companyMachineLabel.Text = "Machine ID";
                inHouseRadioButton.Checked = true;
                MachineCompanyIDTextBox.Text = ((Inhouse)selectedPart).getMachineID().ToString();
            }
            else
            {
                companyMachineLabel.Text = "Company Name";
                outsourcedRadioButton.Checked = true;
                MachineCompanyIDTextBox.Text = ((Outsourced)selectedPart).getCompanyName().ToString();
            }
        }

        private void savePart_Click(object sender, EventArgs e)
        {
            int invInStock = Int32.Parse(invTextBox.Text);
            int minStock = Int32.Parse(minTextBox.Text);
            int maxStock = Int32.Parse(maxTextBox.Text);

            BasePart b = new BasePart();
            b.partID = Inventory.createPartID();
            b.name = nameTextBox.Text;
            b.price = Double.Parse(priceTextBox.Text);
            b.min = minStock;
            b.max = maxStock;
            if (invInStock <= maxStock && invInStock >= minStock)
                b.inStock = Int32.Parse(invTextBox.Text);

            if (inHouseRadioButton.Checked)
            {
                Inhouse newPart = new Inhouse(b, Int32.Parse(MachineCompanyIDTextBox.Text));
                Inventory.updatePart(newPart.getPartID(), newPart);
                mainFormObject.addPartTableRow(newPart);
            }
            else
            {
                Outsourced newPart = new Outsourced(b, MachineCompanyIDTextBox.Text);
                Inventory.updatePart(newPart.getPartID(), newPart);
                mainFormObject.removeCurrentPart();
                mainFormObject.addPartTableRow(newPart);
            }
            Close();
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
