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
    public partial class LookUpPrice : Form
    {
        public LookUpPrice()
        {
            InitializeComponent();
        }
        // Create the Dictionary

        private void LookUpPrice_Load(object sender, EventArgs e)
        {
            // Call LoadDictionary method from sharedMethods class.

            // Add product numbers (key) to the ComboBox:


        }

        private void cboProdNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProdcut = cboProdNumber.SelectedItem.ToString();
            // Use the key (Product#) to get the value (price).

            // lblPrice.Text = price.ToString();
        }
    }
}
