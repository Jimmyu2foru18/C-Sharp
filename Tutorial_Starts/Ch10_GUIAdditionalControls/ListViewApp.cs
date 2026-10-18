using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Ch10_GUIAdditionalControls
{
    public partial class ListViewApp : Form
    {
        public ListViewApp()
        {
            InitializeComponent();
        }

        int numOfTickets;
        private void ListView_Load(object sender, EventArgs e)
        {
            string currentLine;
            string[] fields = new string[3];   
            StreamReader PriceReader = new StreamReader("TicketPrices.txt"); 
            // Read each line, split it, and store in an array:
            while (PriceReader.EndOfStream == false)
            {
                currentLine = PriceReader.ReadLine();
                fields = currentLine.Split(','); 

                // Use the array to create a ListViewItem (row). 


                // Add the entire ListViewItem to the ListView control

            }
            PriceReader.Close();
        }

        private void hsbNumOfTickets_ValueChanged(object sender, EventArgs e)
        {
            numOfTickets = hsbNumOfTickets.Value;
            lblNumOfTickets.Text = numOfTickets.ToString();
        }

        private void btnComputePrice_Click(object sender, EventArgs e)
        {

            // If the CheckBoxes property of the ListView is set to True, 
            // use CheckedItems collection instead of SelectedItems as follows:


            // Alternate method:Store the selected row in a variable & get price from it:


                        // gets price from SubItems[2].


        }

  

    }
}
