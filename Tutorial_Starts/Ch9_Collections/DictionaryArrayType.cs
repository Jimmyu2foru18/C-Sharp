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
    public partial class DictionaryArrayType : Form
    {
        public DictionaryArrayType()
        {
            InitializeComponent();
        }
        // Create a Dictionarh of type  Dictionary<string, string[]> 

        private void DictionaryArrayType_Load(object sender, EventArgs e)
        {
            string currentLine;
            string[] fields = new string[2];
            StreamReader SalesReader = new StreamReader("Sales.txt");
            //Read each line from the file, split and store in an array.
            while (SalesReader.EndOfStream == false)
            {
                currentLine = SalesReader.ReadLine(); // Read product# & four sales.
                fields = currentLine.Split(','); 
				
                // Copy four sales from fields into a another array, salesArray.
                string[] salesArray = new string[4];
                Array.Copy(fields, 1, salesArray, 0, 4);
                //Syntax: Array.Copy(fromArray, fromIndex, toArray, toIndex, length

                // Add the key (Prod#) and value (salesArray) to the Dictionary:

                cboProdNumber.Items.Add(fields[0]);  // Add product# to the ComboBox
            }
            SalesReader.Close();
        }

        private void cboProdNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fmtStr = "{0,-10}{1,8}";
            lstDisplay.Items.Clear();
            lstDisplay.Items.Add(string.Format(fmtStr, "Product#", "Annual Sales"));

            string selectedProdcut = cboProdNumber.SelectedItem.ToString();
            // Use the key (Product#) to get the value (sales array).


            int annualSales = 0;
            

            // Or, you may use a for loop:
            //for (int quarter = 0; quarter <= 3; quarter++)
            //    annualSales = annualSales + int.Parse(salesArray[quarter]);
            lstDisplay.Items.Add(string.Format(fmtStr, selectedProdcut, annualSales));
        }
    }
}
