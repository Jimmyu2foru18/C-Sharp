using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ch_6_Exercise_6_1
{
    public partial class Icecream : Form
    {
        private const decimal IceCreamCost = 3.50m;
        private const decimal CustardCost = 3.75m;
        private const decimal YogurtCost = 4.00m;
        private const decimal NutsCost = 0.50m;
        public Icecream()
        {
            InitializeComponent();


            comboBoxSundae.Items.AddRange(new object[] { "Custard", "Ice Cream", "Yogurt" });

            scrollBarScoops.Scroll += scrollBar_Scroll;
        }

        private void scrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            lblScoops.Text = "Number of Scoops: " + scrollBarScoops.Value.ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal sundaeCost = 0m;
            // Determine the cost of the sundae
            switch (comboBoxSundae.SelectedItem.ToString())
            {
                case "Ice Cream":
                    sundaeCost = IceCreamCost;
                    break;
                case "Custard":
                    sundaeCost = CustardCost;
                    break;
                case "Yogurt":
                    sundaeCost = YogurtCost;
                    break;
            }

            // Calculate the amount due 
            decimal amountDue = (sundaeCost * scrollBarScoops.Value) + (checkBoxNuts.Checked ? NutsCost : 0m);

          
            lblResults.Text = "Amount Due: $" + amountDue.ToString("0.00");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            lblScoops.Text = " ";
            lblResults.Text = string.Empty;
            scrollBarScoops.Value = scrollBarScoops.Minimum;
            comboBoxSundae.SelectedIndex = -1;
            checkBoxNuts.Checked = false;
        }
    }
}