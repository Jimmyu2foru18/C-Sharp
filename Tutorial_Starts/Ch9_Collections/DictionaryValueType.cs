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
using System.Collections;

namespace Ch9_Collections
{
    public partial class DictionaryValueType : Form
    {
        public DictionaryValueType()
        {
            InitializeComponent();
        }
        // Create a Dictionay named prices of type Dictionary<string, float>

        private void DictionaryValueType_Load(object sender, EventArgs e)
        {
            string currentLine;
            string[] fields = new string[2];
            //Create StreamReader
            StreamReader PriceReader = new StreamReader("Price.txt");

            //Read each line from the file, split and store in an array.
            while (PriceReader.EndOfStream == false)
            {
                currentLine = PriceReader.ReadLine(); // Read a product# and four sales data
                fields = currentLine.Split(','); // Store Product# and Sales in a temp array
                // Add the Prod# as key, and price as the value to the Dictionary:
                
                cboProdNumber.Items.Add(fields[0]);  // Add product# to the ComboBox
            }
            PriceReader.Close();
        }

        private void cboProdNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fmtStr = "{0,-10}{1,8}";
            lstDisplay.Items.Clear();
            lstDisplay.Items.Add(string.Format(fmtStr, "Product#", "Price"));

            string selectedProdcut = cboProdNumber.SelectedItem.ToString();
            // Use the key (Product#) to get the value (price).

            // lstDisplay.Items.Add(string.Format(fmtStr, selectedProdcut, price));
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            string fmtStr = "{0,-10}{1,8:C}";
            lstDisplay.Items.Add(string.Format(fmtStr, "Product#", "Price"));





        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            float totalPrice = 0;
            // Use a foreach loop to access each Value (price)



            lstDisplay.Items.Add("Total Price: " + totalPrice.ToString("C2"));
        }
    }
}
