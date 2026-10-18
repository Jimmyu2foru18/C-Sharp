using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_5_Method_Writing_HW
{
    public partial class Ch_5_Hotel_Discount : Form
    {

        public Ch_5_Hotel_Discount()
        {
            InitializeComponent();

            // Fill Discount ComboBox
            cbDiscount.Items.Add("AAA");
            cbDiscount.Items.Add("Govt");
            cbDiscount.Items.Add("Senior");
            cbDiscount.Items.Add("No Discount");

            // Fill Pet ComboBox
            cbPets.Items.Add("0 pets");
            cbPets.Items.Add("1 pet");
            cbPets.Items.Add("2 pets");
            // Weekday or Weekend
            cbWeek.Items.Add("Yes");
            cbWeek.Items.Add("No");
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            //Determine the Base Rate
            double baseRate;
            bool isWeekend = IsWeekend();
            if (isWeekend)
            {
                baseRate = 200.0; // Weekend Rate
            }
            else
            {
                baseRate = 150.0; // Weekday Rate
            }

            // Apply Discount Based on Code
            double discountPercentage = 0.0;
            switch (cbDiscount.SelectedItem.ToString())
            {
                case "No Discount":
                    discountPercentage = 0.0;
                    break;
                case "AAA":
                    discountPercentage = 0.05;
                    break;
                case "Govt":
                    discountPercentage = 0.10;
                    break;
                case "Senior":
                    discountPercentage = 0.20;
                    break;
                default:
                    break;
            }

            // Add Pet Fee
            double petFee = 0.0;
            switch (cbPets.SelectedItem.ToString())
            {
                case "0 pets":
                    petFee = 0.0;
                    break;
                case "1 pet":
                    petFee = 40.0;
                    break;
                case "2 pets":
                    petFee = 100.0;
                    break;
                default:
                    break;
            }

            // Calculate
            double subtotal = baseRate + petFee - (baseRate * discountPercentage);

            // Tax
            double taxRate = 0.08;
            double tax = subtotal * taxRate;

            // Total
            double finalTotal = subtotal + tax;

            // Display List
            lstResults.Items.Clear();
            lstResults.Items.Add("1 Night Hotel Fee:");
            lstResults.Items.Add("");
            lstResults.Items.Add("Subtotal: $" + subtotal.ToString("0.00"));
            lstResults.Items.Add("Tax: $" + tax.ToString("0.00"));
            lstResults.Items.Add("");
            lstResults.Items.Add("Final Price: $" + finalTotal.ToString("0.00"));
            lstResults.Items.Add("");
        }
        //Weekday or Weekend
        private bool IsWeekend()
        {
            if (cbWeek.SelectedItem.ToString() == "Yes")
            {
                return true; // Weekend
            }
            else
            {
                return false; // Weekday
            }
        }
    }
}
