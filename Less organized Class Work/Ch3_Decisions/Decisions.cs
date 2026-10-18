using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch3_Decisions
{
    public partial class Decisions : Form
    {
        public Decisions()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string letterGrade;

            if (float.TryParse(txtTotalScore.Text, out float totalScore))
            {
                // Compute grade based on total score
                if (totalScore >= 90)
                    letterGrade = "A";         // nested within the outter if
                else if (totalScore >= 80)
                    letterGrade = "B";
                else if (totalScore >= 70)
                    letterGrade = "C";
                else
                    letterGrade = "F";
                // Display the grade
                txtLetterGrade.Text = letterGrade;
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }
    }
}