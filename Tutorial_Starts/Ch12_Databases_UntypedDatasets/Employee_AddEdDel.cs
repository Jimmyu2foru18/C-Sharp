using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Ch12_Databases_UntypedDatasets
{
    public partial class Employee_AddEdDel : Form
    {
        public Employee_AddEdDel()
        {
            InitializeComponent();
        }

        DataTable dtEmployee = new DataTable();
        SqlDataAdapter daEmployee;
        BindingSource bsEmployee = new BindingSource();

        // data table, data adapter and binding source Department table:
        DataTable dtDept = new DataTable();
        SqlDataAdapter daDept;
        BindingSource bsDept = new BindingSource();

        bool adding = false;
        DataRowView drvEmployee;
        DataRow drEmployee;

        private void Employee_AddEdDel_Load(object sender, EventArgs e)
        {
            // Fill employee data table, dtEmployee
            string connString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\VC\HR2.mdf";
            string empSQLStr = "SELECT * FROM Employee";

            daEmployee = new SqlDataAdapter(empSQLStr, connString);
            //Build UpdateCommand, DeleteCommand, and InserCommand
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(daEmployee);

            daEmployee.Fill(dtEmployee);

            // Fill department data table, dtDept
            string DeptSQLStr = "SELECT DeptNo, DeptName FROM Department";
            daDept = new SqlDataAdapter(DeptSQLStr, connString); //Create data adapter
            daDept.Fill(dtDept);

            //Display DeptNo's from data table, in cboDept:




            // Display employee data
            bsEmployee.DataSource = dtEmployee; // links the binding source to the data table
            DisplayCurrentRow();
            lblRecordNo.Text = (bsEmployee.Position + 1) + "  of  " + bsEmployee.Count;
            bsEmployee.PositionChanged += bsEmployee_PositionChanged;
        }

        private void DisplayCurrentRow()
        {
            // Copy the current row into a DataRowView:
            int currentRow = bsEmployee.Position;
            DataRowView drvEmployee = (DataRowView)bsEmployee[currentRow];

            // Copy data from the datarowview to controls on the form:
            txtEmpId.Text = drvEmployee["EmpId"].ToString();
            txtLastName.Text = drvEmployee["LastName"].ToString();
            txtFirstName.Text = drvEmployee["FirstName"].ToString();
            txtDOB.Text = drvEmployee["DateofBirth"].ToString();
            txtPhone.Text = drvEmployee["Phone"].ToString();
            txtCountryId.Text = drvEmployee["CountryId"].ToString();
            txtPhone.Text = drvEmployee["Phone"].ToString();
            cboDeptNo.Text = drvEmployee["DeptNo"].ToString();
            txtSalary.Text = drvEmployee["Salary"].ToString();
            chkFullTime.Checked = bool.Parse(drvEmployee["FullTime"].ToString());
            // (add swtich statement here)











        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                           // clear all controls

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int noOfRecords = 0;
                // Save data to the data table:
                if (adding == true)    // if it is a new record
                {
                    // Create a blank DataRow by calling the NewRow() method of data table.

                                        // copy data, into a DataRow
                    // Add the new DataRow to the Rows collection of the data table
                    

                    lblRecordNo.Text = (bsEmployee.Position + 1) + "  of  " + bsEmployee.Count;
                    adding = false;
                }
                else // it's an existing record
                {
                // Create a DataRowView that references the current row of 
                // the binding source:



                                            // Copy data from controls the DataRowView:
                                            //Save the DataRowView into data table
                 }
                // Update the database table
                                                           // Save to database table
                MessageBox.Show("Changes saved to database");
        }

        private void CopyToDataRowView()
        {
            // Copy data from controls into columns in the DataRowView
            drvEmployee["LastName"] = txtLastName.Text;
            drvEmployee["FirstName"] = txtFirstName.Text;
            drvEmployee["DateOfBirth"] = txtDOB.Text;
            drvEmployee["Phone"] = txtPhone.Text;
            drvEmployee["CountryId"] = txtCountryId.Text;
            drvEmployee["DeptNo"] = cboDeptNo.Text;
            drvEmployee["FullTime"] = chkFullTime.Checked;
            string empPosition = null; //empPoistion represents the job title
            if (rdbVP.Checked == true)
                empPosition = "VP";
            else if (rdbMgr.Checked)
                empPosition = "Manager";
            else if (rdbStaff.Checked)
                empPosition = "Staff";

            drvEmployee["Position"] = empPosition;
        }

        private void CopyToDataRow()
        {
            // Copy data from controls into columns of the DataRow
            drEmployee["EmpId"] = txtEmpId.Text;
            drEmployee["LastName"] = txtLastName.Text;
            drEmployee["FirstName"] = txtFirstName.Text;
            drEmployee["DateofBirth"] = txtDOB.Text;
            drEmployee["CountryId"] = txtCountryId.Text;
            drEmployee["DeptNo"] = cboDeptNo.Text;
            drEmployee["FullTime"] = chkFullTime.Checked;
            string empPosition = null;
            if (rdbVP.Checked == true)
                empPosition = "VP";
            else if (rdbMgr.Checked)
                empPosition = "Manager";
            else if (rdbStaff.Checked)
                empPosition = "Staff";

            drEmployee["Position"] = empPosition;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {





                //Remove current record from data table


                //Update the database table with the dataset table

                MessageBox.Show("Record deleted from the database");

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bsEmployee.MoveFirst();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            bsEmployee.MoveNext();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bsEmployee.MovePrevious();
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            bsEmployee.MoveLast();
        }
        private void bsEmployee_PositionChanged(object sender, System.EventArgs e)
        {
            if (bsEmployee.Count > 0)
            {
                lblRecordNo.Text = (bsEmployee.Position + 1) + "  of  " + bsEmployee.Count;
                DisplayCurrentRow();
            }
        }

        private void ClearControls()
        {
            // (add code to clear TextBoxes)




            cboDeptNo.Text = null;
            rdbVP.Checked = false;
            rdbMgr.Checked = false;
            rdbStaff.Checked = false;
            chkFullTime.Checked = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisplayCurrentRow();
            adding = false;
        }
    }
}
