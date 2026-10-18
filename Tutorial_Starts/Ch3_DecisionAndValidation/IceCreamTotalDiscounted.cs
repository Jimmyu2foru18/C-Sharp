using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch3_DecisionAndValidation
{
    public partial class IceCreamTotalDiscounted : Form
    {
        public IceCreamTotalDiscounted()
        {
            InitializeComponent();
        }

        private void btnComputeTotal_Click(object sender, EventArgs e)
        {
            //Compute the total cost for an order of icecream:

            //Decalre variables to hold input data and computed results

            decimal unitPrice, subTotal, salesTax, totalCost;
            int scoops;
            //Declare constants to hold the discount and tax rates
            const decimal TAX_RATE = 5.5m;

            //Get input data from Text Boxes:
            unitPrice = decimal.Parse(txtUnitPrice.Text);
            scoops = int.Parse(txtScoops.Text);

            // Compute sub-total
            subTotal = unitPrice * scoops;

            // Compute discount percent
            decimal discountPercent, discount;





            // Compute discount
            //discount = subTotal * discountPercent / 100;

            //// Compute Total Cost
            //decimal netCost;
            //netCost = subTotal - discount;
            //salesTax = netCost * TAX_RATE / 100;
            //totalCost = netCost + salesTax;

            ///* Display Results with decimals aligned
            //   Important Note: To align characters in a column, the Font type of 
            //   the ListBox must be of fixed size, like Courier New.             */
            //string formatString = "{0,-12}{1,10:C}";
            //lstOutput.Items.Add(string.Format(formatString, "Sub Total:", subTotal));
            //lstOutput.Items.Add(string.Format(formatString, "Discount:", discount));
            //lstOutput.Items.Add(string.Format(formatString, "Net Cost:", netCost));
            //lstOutput.Items.Add("");  // Add a blank line


        }
    }
}
