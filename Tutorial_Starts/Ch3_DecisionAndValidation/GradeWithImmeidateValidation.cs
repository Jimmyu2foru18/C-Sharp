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
    public partial class GradeWithImmeidateValidation : Form
    {
        public GradeWithImmeidateValidation()
        {
            InitializeComponent();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            // Get totalScore and attendance
            float totalScore = float.Parse(txtScore.Text);
            float attendance = float.Parse(txtAttendance.Text);

            // Compute grade:
            string letterGrade;
            if (totalScore >= 90)
                if (attendance >= 90F)
                    letterGrade = "A";
                else
                    letterGrade = "B";
            else if (totalScore >= 80)
                letterGrade = "B";
            else if (totalScore >= 70)
                letterGrade = "C";
            else
                letterGrade = "F";

            // Display grade:
            lblGrade.Text = letterGrade;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
        }
    }
}
