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
    public partial class ComputeGrade : Form
    {
        public ComputeGrade()
        {
            InitializeComponent();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            string letterGrade;
            float totalScore = float.Parse(txtScore.Text);
            if (totalScore == Math.Truncate(totalScore))
                MessageBox.Show("Is integer");
            // Compute grade based only on score:



            // Display grade:
            // lblGrade.Text = letterGrade;
        }
    }
}
