using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFormApps1
{
    public partial class FinancialPlanner : Form
    {
        public FinancialPlanner()
        {
            InitializeComponent();
        }
        //Declare a variable of type DisplayInvestment form.

        
        private void btnHowlong_Click(object sender, EventArgs e)
        {
            // Create an instance of DisplayIvestment form and 
            // store its reference in the variable displayInvestment:

            // Load and show the form:


            // Get input data from Text Boxes:
            double yearlyInvestment = double.Parse(txtInvestment.Text);
            float YearlyGrowthPercent = float.Parse(txtGrowthRate.Text);
            double targetAmt = double.Parse(txtTargetAmt.Text);

            // Print heading
            string formatCode = "{0,5}{1,17}";
            // Add heading to the ListBox lstDisplay in DisplayInvestment form.
            // displayInvestment.lstDisplay.Items.Add(string.Format(formatCode,
            //                "Year", "Investment Value"));      
            // displayInvestment.lstDisplay.Items.Add("");

            // Set year and investment value to zero
            int year = 0;
            double investmentValue = 0;
            // Use while loop to compute investment value for each year
            while (investmentValue < targetAmt)
            {
                year = year + 1; 
                investmentValue = (investmentValue + yearlyInvestment) * 
                                                (1 + YearlyGrowthPercent / 100);
                // Add year & investment value to the lstDisplay in DisplayInvestment form
                // displayInvestment.lstDisplay.Items.Add(string.Format(formatCode, 
                //                                    year, investmentValue.ToString("C")));
            }
        }
        private void btnUnhideDisplayForm_Click(object sender, EventArgs e)
        {

        }
    }
}
