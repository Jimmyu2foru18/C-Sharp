using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch5_Methods
{
    public partial class HeartRate : Form
    {
        public HeartRate()
        {
            InitializeComponent();
        }
        // TrainingRate method







        private void btnTrainingRate_Click(object sender, EventArgs e)
        {
            float restingRate, age, trainingtRate;
            // Get resting rate and age from Textboxes:
            restingRate = float.Parse(txtRestingRate.Text);
            age = float.Parse(txtAge.Text);

            // Call TrainingRate(), and store the returned value in trainingRate.

            // Display training rate
            //lstResults.Items.Add(string.Format("{0,20}{1,10}", "Training Rate:",
            //                                        trainingtRate.ToString("N0")));
        }

        private void btnTrainingRate_Click_1(object sender, EventArgs e)
        {

        }
    }
}
