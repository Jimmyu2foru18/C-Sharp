using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramBasics
{
    public partial class FinancialPlanner : Form
    {
        public FinancialPlanner()
        {
            InitializeComponent();
        }

        private void btnHowLong_Click(object sender, EventArgs e)
        {
            // Get input data from Text Boxes:
            double yearlyInvestment = double.Parse(txtInvestment.Text);
            float YearlyGrowthPercent = float.Parse(txtGrowthRate.Text);
            double targetAmt = double.Parse(txtTargetAmt.Text);

            // Print heading
            string formatCode = "{0,7}{1,20}";
            lstDisplay.Items.Add(string.Format(formatCode, "years", 
                                                        "Investment Value"));
            lstDisplay.Items.Add("");

            // Set year and investment value to zero
            int year = 0;
            double investmentValue = 0;

            // Use while loop to compute investment value for each year





            // Use do-while loop to compute investment value for each year






        }
    }
}
