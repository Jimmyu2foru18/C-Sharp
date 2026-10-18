using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    // add this using directive

namespace Ch12_Databases_UntypedDatasets
{
    public partial class Employee_Display : Form
    {
        public Employee_Display()
        {
            InitializeComponent();
        }
                                       // creates the data table
                                       // Declares a reference variable for the data adapter;
                                       // Creates the binding source

        private void Employee_Display_Load(object sender, EventArgs e)
        {
            // Create the data adapter




            // Fill the data table, dtEmployere

            // Link binding source to the data table


            // call DisplayCurrentRow method to display the current row


            // Display row number and count of rows 
            

            // Link (subscribe) PositionChanged event to bsEmployee_PositionChanged method
            
        }
        private void DisplayCurrentRow()
        {
            // store the current row of the data table in a DataRowView



            // copy data from the DataRowView to controls on the form:
       
                    // Or, use the index as in, drvEmployee[0].ToString();
            //txtFirstName.Text = drvEmployee["FirstName"].ToString(); 
            //txtLastName.Text = drvEmployee["LastName"].ToString();
            //txtDOB.Text = drvEmployee["DateofBirth"].ToString();
            //txtPhone.Text = drvEmployee["Phone"].ToString();
            //txtCountryId.Text = drvEmployee["CountryId"].ToString();
            //txtDepNo.Text = drvEmployee["DeptNo"].ToString();
            //txtSalary.Text = drvEmployee["Salary"].ToString();
            // (add code here to display full time status)
            //txtPosition.Text = drvEmployee["Position"].ToString();
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            // (add the code to move to first record)
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            //bsEmployee.MoveLast();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //bsEmployee.MovePrevious();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            //bsEmployee.MoveNext();
        }

        private void bsEmployee_PositionChanged(object sender, System.EventArgs e) 
        {
            // display data & row number whenever a the current record position changes





        }
    }
}
