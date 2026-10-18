using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserNameString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*First 5 letters of last name 
             * First Character of first name
             * Last 2 digits of the ID
             * 
             * Brandon 
             * Smith
             * 12345
             * 
             * SmithB45
             */
            string result;
            if
                (txtLastName.Text.Length >= 5)
                result = txtLastName.Text.Trim().Substring(0, 5)
                       + txtFirstName.Text.Trim().Substring(0, 1)
                       + txtId.Text.Trim().Substring(txtId.Text.Length - 2, 2);
            else
            {
                int x = txtLastName.Text.Length;

                result = txtLastName.Text
                       + txtFirstName.Text.Trim().Substring(0, 5 - x)
                       + txtId.Text.Trim().Substring(txtId.Text.Length - 2, 2);
            }
            UserNameR.Text = result;

        }
    }
}
