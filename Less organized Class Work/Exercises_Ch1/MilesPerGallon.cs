using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercises_Ch1
{
    public partial class MilesPerGallon : Form
    {
        public MilesPerGallon()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(milesTextBox.Text, out double miles) &&
                double.TryParse(gallonsTextBox.Text, out double gallons))
            {

                if (gallons != 0)
                {
                    double milesPerGallon = miles / gallons;
                    resultLabel.Text = $"Miles per Gallon: {milesPerGallon:F2}";
                }
                else
                {
                    resultLabel.Text = "Gallons must be greater than zero.";
                }
            }
            else
            {
                resultLabel.Text = "Invalid input. Please enter valid numeric values.";
            }
        }
    }
}