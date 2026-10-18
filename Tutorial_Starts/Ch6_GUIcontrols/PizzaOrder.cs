using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch5_GUIcontrols
{
    public partial class PizzaOrder : Form
    {
        public PizzaOrder()
        {
            InitializeComponent();
        }
        // This form uses a ListBox to let users select multiple items from a list:
        private void PizzaOrder_Load(object sender, EventArgs e)
        {
            string[] toppings = {"Pepperoni","Sausage", "Onion", "Green Pepper", 
                                 "Mushrooms", "Xtra Cheese", "Ham", "Anchovies"};
            foreach (string topping in toppings)  // Add toppings to ListBox
                lstToppings.Items.Add(topping); 

            rdbDefault.Checked = true;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            // Verify that the user selected size:
            if (rdbDefault.Checked == true)
            {
                MessageBox.Show("Please select size");
                return;
            }
            // Invoke UnitPrice to get base price and cost per topping




            // Compute and display price
            // (insert code here to compute the price: base price + cost of toppings)
            float price = 0;
            lstDisplay.Items.Clear();
            lstDisplay.Items.Add ("Price:  " + price.ToString("C2"));
            // Display Toppings:
            lstDisplay.Items.Add("");
            lstDisplay.Items.Add ("Toppings");
            if (lstToppings.SelectedItems.Count == 0)  // if no item is selected
                lstDisplay.Items.Add("    None");
            else
            {
                // (insert the code to display selected items)

            }
        }

        private (float basePrice, float costPerTopping) UnitPrice()
        {
            float basePrice = 0, costPerTopping = 0;
            if (rdbSmall.Checked)
            {
                basePrice = 6.95F;
                costPerTopping = 1.5F;
            }
            else if (rdbMedium.Checked)
            {
                basePrice = 8.95F;
                costPerTopping = 2.0F;
            }
            else if (rdbLarge.Checked)
            {
                basePrice = 11.95F;
                costPerTopping = 2.5F;
            }
            return (basePrice, costPerTopping);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdbDefault.Checked = true;
            lstToppings.SelectedIndex = -1;
            lstDisplay.Items.Clear();
        }
    }
}
