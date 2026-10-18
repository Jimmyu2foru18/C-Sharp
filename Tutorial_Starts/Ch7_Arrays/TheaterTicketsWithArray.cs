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
    public partial class TheaterTicketsWithArray : Form
    {
        public TheaterTicketsWithArray()
        {
            InitializeComponent();
        }

        private void TheaterTicketsWithArray_Load(object sender, EventArgs e)
        {
            chkMember.CheckState = CheckState.Indeterminate;
            rdbDefault.Checked = true;
            string[] shows = {"Mamma Mia","Rock of Ages","Les Misrables", "Motown The Musical", 
                                 "The Lion King", "The Phantom of the Opera"};
            foreach (string show in shows)
                cboShow.Items.Add(show);
        }

        private void hsbNumOfTickets_ValueChanged(object sender, EventArgs e)
        {
            lblNumOfTickets.Text = hsbNumOfTickets.Value.ToString();
        }

        private void cboShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verify that the user selected number of tickets:
            if (hsbNumOfTickets.Value == 0)
            {
                MessageBox.Show("Please select number of tickets");
                return;
            }
            // Verify that the user selected a section:
            if (rdbDefault.Checked == true)
            {
                MessageBox.Show("Please select the section");
                return;
            }
            // Verify that the user selected membership status:
            if (chkMember.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("plese specify membership status");
                return;
            }
            // Get number of tickets
            int numOfTickets = hsbNumOfTickets.Value;
            // Get discount
            float discount = 0;
            if (chkMember.Checked)
                discount = 20;
            // Get unitPrice
            float unitPrice = 0;
            GetUnitPrice(ref unitPrice);
            // Add the code here to get the markup. Add markup to amount due.




            float amtDue = numOfTickets * (unitPrice - discount);
            string fmtStr = "{0,-25}{1,12}";
            lstDisplay.Items.Clear();
            lstDisplay.Items.Add(string.Format(fmtStr, "Show", "Total Price"));
            lstDisplay.Items.Add(string.Format(fmtStr, cboShow.SelectedItem, amtDue.ToString("C")));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            hsbNumOfTickets.Value = 0;
            chkMember.CheckState = CheckState.Indeterminate;
            rdbDefault.Checked = true;
            cboShow.SelectedIndex = -1;
        }

        private void GetUnitPrice(ref float unitPrice)
        {
            if (rdbSec1.Checked == true)
            {
                unitPrice = 70;
            }
            else if (rdbSec2.Checked == true)
            {
                unitPrice = 60;
            }
            else if (rdbSec3.Checked == true)
            {
                unitPrice = 52;
            }
            else if (rdbSec4.Checked == true)
            {
                unitPrice = 45;
            }
        }
    }
}
