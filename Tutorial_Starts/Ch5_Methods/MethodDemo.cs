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
    public partial class MethodDemo : Form
    {
        public MethodDemo()
        {
            InitializeComponent();
        }

        private void DisplayInfo()
        {
            string greeting;
            if (DateTime.Now < DateTime.Parse("12:00 PM"))
                greeting = "Good Morning!";
            else if (DateTime.Now < DateTime.Parse("6:00 PM"))
                greeting = "Good Afternoon!";
            else
                greeting = "Good Evening!";

            MessageBox.Show(greeting + " This form computes training heart rate:"
                                     + "0.6*(220-Age-RestingRate) + RestingRate");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {


        }
        // Method to compute training rate goes here











        
        private void btnTrainingRate_Click(object sender, EventArgs e)
        {

        }

    }
}
