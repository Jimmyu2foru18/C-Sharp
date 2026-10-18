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
    public partial class Employee_Select : Form
    {
        public Employee_Select()
        {
            InitializeComponent();
        }

        // data table, data adapter and binding source for Employee table
        DataTable dtEmployee = new DataTable(); 
        SqlDataAdapter daEmployee;  
        BindingSource bsEmployee = new BindingSource();

        // data table and data adapter for Department table



        private void Employee_Select_Load(object sender, EventArgs e)
        {
            // Fill employee data table, dtEmployee
            string connString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                                                C:\VC\HR2.mdf";
            string empSQLStr = "SELECT * FROM Employee";    
            daEmployee = new SqlDataAdapter(empSQLStr, connString);
            daEmployee.Fill(dtEmployee);

            // Display employee data
            bsEmployee.DataSource = dtEmployee; // links binding source to the data table
            DisplayCurrentRow();
            lblRecordNo.Text = (bsEmployee.Position + 1) + "  of  " + bsEmployee.Count;
            bsEmployee.PositionChanged += bsEmployee_PositionChanged;

            // Fill department data table, dtDept




            //Display DeptNo's from dtDept, in the ComboBox, cboFillByDept: 




            //Display DeptNo's from dtDept, in the ComboBox, cboFilterByDept:


 
        }

        // (insert SelectionChangeCommitted event hadler of cboFilterByDept)










        private void cboFillByDept_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Specify the SQL





        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {

            
            
                            // remove the filter

            lblRecordNo.Text = (bsEmployee.Position + 1) + "  of  " + bsEmployee.Count;
            DisplayCurrentRow();
        }

        private void DisplayCurrentRow()
        {
            // store the current row of the data table in a DataRow
            int currentRow = bsEmployee.Position;
            DataRowView drvEmployee = (DataRowView)bsEmployee[currentRow];

            // copy data from the datarow to controls on the form:
            txtEmpId.Text = drvEmployee["EmpId"].ToString();
            // Or, use the index as in, drvEmployee[0].ToString();
            txtFirstName.Text = drvEmployee["FirstName"].ToString();
            txtLastName.Text = drvEmployee["LastName"].ToString();
            txtDOB.Text = drvEmployee["DateofBirth"].ToString();
            txtPhone.Text = drvEmployee["Phone"].ToString();
            txtCountryId.Text = drvEmployee["CountryId"].ToString();
            txtDepNo.Text = drvEmployee["DeptNo"].ToString();
            txtSalary.Text = drvEmployee["Salary"].ToString();
            chkFullTime.Checked = bool.Parse(drvEmployee["FullTime"].ToString());
            txtPosition.Text = drvEmployee["Position"].ToString();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bsEmployee.MoveFirst();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bsEmployee.MovePrevious();
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            bsEmployee.MoveLast();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            bsEmployee.MoveNext();
        }

        private void bsEmployee_PositionChanged(object sender, System.EventArgs e)
        {
            // display row number and data, whenever a the current record position changes
            if (bsEmployee.Count > 0)
            {
                lblRecordNo.Text = (bsEmployee.Position + 1) + "  of  " + bsEmployee.Count;
                DisplayCurrentRow();
            }
        }
    }
}
