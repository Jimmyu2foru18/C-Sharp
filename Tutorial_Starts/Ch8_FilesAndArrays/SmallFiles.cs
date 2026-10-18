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
namespace Ch8_FilesAndArrays
{
    public partial class SmallFiles : Form
    {
        public SmallFiles()
        {
            InitializeComponent();
        }
        string[] names, phoneNumbers; //Declare arrays
        int recordCount = 0;

        private void SmallFiles_Load(object sender, EventArgs e)
        {
            string currentLine;
            string[] fields = new string[7];   // Declare array named fields
            StreamReader vendorReader = new StreamReader("Vendor.txt"); 

            names = new string[10];
            phoneNumbers = new string[10];
            // Read each line, split & store name and phone number into two arrays.
            while (vendorReader.EndOfStream == false)
            {
                currentLine = vendorReader.ReadLine();
                fields = currentLine.Split(','); 

                                                 //Store name into the array, names
                                                 //Store phone# into phoneNumbers

                                                 // Add names to the ComboBox
                recordCount = recordCount + 1;
            }
            vendorReader.Close();
        }

        private void cboVendorNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get selected vendor name from the ComboBox
            string searchName = cboVendorNames.SelectedItem.ToString();
            //string fmtStr = "{0,-15}{1,8}";
            lstDisplay.Items.Clear();

            // Use IndexOf method to find the record
            
                        //if there is no match, index would be -1.
           // (enter code to display phone number, if found)




        }
    }
}
