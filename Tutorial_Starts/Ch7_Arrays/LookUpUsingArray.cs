using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch7_Arrays
{
    public partial class LookUpUsingArray : Form
    {
        public LookUpUsingArray()
        {
            InitializeComponent();
        }
        string[] months = { "January", "February", "March", "April", "May", "June", "July", 
                              "August", "September", "October", "November", "December" };
        int[] unitsSold = { 572, 645, 693, 564, 580, 756, 960, 756, 663, 678, 745, 960}; 

        private void btnDisplayUnitsSold_Click(object sender, EventArgs e)
        {
            string monthName = txtMonthName.Text;
            int monthIndex, unitsSoldInMonth;
            
            // Find index of the month, and use the index to find units sold
             


            //lblUnitsSold.Text = unitsSoldInMonth.ToString();

            // Alternate method using a loop: 
            // Compare each month from the array to the specified month



            // Display a message if month was not found



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMonthName.Clear();
            lblUnitsSold.Text = null;
        }
    }
}
