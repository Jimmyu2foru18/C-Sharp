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
    public partial class FinPlannerForLoop : Form
    {
        public FinPlannerForLoop()
        {
            InitializeComponent();
        }

        private void btnInvestment_Click(object sender, EventArgs e)
        {
            // Get input data from Text Boxes:
            double yearlyInvestment = double.Parse(txtInvestment.Text);
            float YearlyGrowthPercent = float.Parse(txtGrowthRate.Text);
            int numberOfYears = int.Parse(txtYears.Text);

            // Print heading
            string formatCode = "{0,7}{1,20}";
            lstDisplay.Items.Add(string.Format(formatCode, "years", 
                                                    "Investment Value"));
            lstDisplay.Items.Add("");

            // Set investment value to zero
            double investmentValue = 0;

            // Use for loop to compute investment value for each year










            //lstDisplay.Items.Add(string.Format(formatCode, year, 
            //                               investmentValue.ToString("C")));
        }
    }
}
