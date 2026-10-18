using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch2_DataTypes
{
    public partial class IceCreamTotalDataTypes : Form
    {
        public IceCreamTotalDataTypes()
        {
            InitializeComponent();
        }

        private void btnComputeTotal_Click(object sender, EventArgs e)
        {
            //Compute the total cost for an order of icecream:

            //Declare variables to hold input data and computed results
            int scoops;
            decimal unitPrice, subTotal, salesTax, totalCost;

            //Declare a constant to hold the tax rate
            const decimal TAX_RATE =  5.5m;  // TAX_RATE is decimal type

            //Get input data from Text Boxes:
            unitPrice = decimal.Parse(txtUnitPrice.Text);
            scoops = int.Parse(txtScoops.Text);

            // Compute results
            subTotal = unitPrice * scoops;
            salesTax = subTotal * TAX_RATE / 100;
            totalCost = subTotal + salesTax;

            // Display Results with decimals aligned
            lstOutput.Items.Add(string.Format("{0,12}{1,10:C}", "Sub Total:", subTotal));
            lstOutput.Items.Add(string.Format("{0,12}{1,10:C}", "Sales Tax:", salesTax));
            lstOutput.Items.Add("");  // Add a blank line
            lstOutput.Items.Add(string.Format("{0,12}{1,10:C}", "Total Cost:", totalCost));
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtScoops.Clear();
            txtUnitPrice.Clear();
            lstOutput.Items.Clear();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
