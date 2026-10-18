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
    public partial class GenericList : Form
    {
        public GenericList()
        {
            InitializeComponent();
        }
        // Create a List of arrays:

        private void GenericList_Load(object sender, EventArgs e)
        {
            string currentLine;
            string[] fields = new string[2];
            //Create StreamReader
            StreamReader SalesReader = new StreamReader("Sales.txt");

            //Read each line from the file, split and store in an array
            while (SalesReader.EndOfStream == false)
            {
                currentLine = SalesReader.ReadLine(); // Read a product# and four sales data
                fields = currentLine.Split(','); // Store Product# and Sales in a temp array
                // Add the entire array to the List, sales.

                cboProdNumber.Items.Add(fields[0]);  // Add product# to the ComboBox
            }
            SalesReader.Close();
        }

        private void cboProdNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fmtStr = "{0,-20}{1,8}";
            lstDisplay.Items.Clear();
            lstDisplay.Items.Add(string.Format(fmtStr, "Product#", "Total Sales"));

            // If both the List and ComboBox are not sorted, or if both are sorted, then 
            // you can use the SelectedIndex from the ComboBox to find the item from the List:



            // compute total sales for quarters 1 - 4
            int annualSales = 0;



            lstDisplay.Items.Add(string.Format(fmtStr, cboProdNumber.SelectedItem, annualSales));

            // If either the List or the ComboBox is sorted and the other not sorter, then
            // loop through each item in sales collection to find the selected Product:
            // This works also when both are sorted, and when both are not sorted
            {
                string selectedProduct = cboProdNumber.SelectedItem.ToString();
                // if selected product matches product in current row (array) compute total






                lstDisplay.Items.Add(string.Format(fmtStr, cboProdNumber.SelectedItem, annualSales));
                return;     // Exit the method, if a matching product is found
            }
        }
    }
}
