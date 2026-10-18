using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch11_MultiFormApps2
{
    public partial class DisplayProducts : Form
    {
        public DisplayProducts()
        {
            InitializeComponent();
        }
        // Create the Dictionary

        private void DisplayPrices_Load(object sender, EventArgs e)
        {
            // Call LoadDictionary method from sharedMethods class.
            
        }

        private void btnDisplayProducts_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Add("Product#        Price");





        }
    }
}
