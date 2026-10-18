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
    public partial class Array_1D_Intro : Form
    {
        public Array_1D_Intro()
        {
            InitializeComponent();
        }
        private void btnDemo_Click(object sender, EventArgs e)
        {
            // Create array testScore with default values:

   

            // Create array testScore using array initializer

            
            // Change the first test score to 89, and the third test Score to 99: 



            // Use a for loop to display each element of the array and compute the average score:
            //totalScore must be initialized to zero
            lstDisplay.Items.Add("index" + "     " + "Score");






            //float averageScore = (float)totalScore / testScore.Length;
            //lstDisplay.Items.Add("Average:  " + averageScore.ToString("N"));

            // Use foreach loop to display each element of the array and compute the average score:








            //lstDisplay.Items.Add("Average:  " + averageScore.ToString("N")); 

            // Assigning testScore to another arrray reference variable - doesn't copy the array



            //Copy the entire array testScore using Array.Copy method to temp2:


            // copy the last four elements of testScore to temp3:





            // copy testScore to another array using for loop:



        }
    }
}
