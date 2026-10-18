using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
                       // using Directive to include System.IO

namespace Ch8_FilesAndArrays
{
    public partial class WriteToTextFile : Form
    {
        public WriteToTextFile()
        {
            InitializeComponent();
        }
        // Declare variable ExamsWriter at class level:

        private void WriteToTextFiles_Load(object sender, EventArgs e)
        {
            // Create StreamWriter object


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name, score1, score2;
            // Store all data in string variables to be stored in the text file.
            name = txtName.Text;
            score1 = txtScore1.Text;
            score2 = txtScore2.Text;
            // Combine name, score1 & score2 into a single string and store in Exams.txt

            MessageBox.Show("Data Saved");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtScore1.Text = "";
            txtScore2.Text = "";
        }
    }
}
