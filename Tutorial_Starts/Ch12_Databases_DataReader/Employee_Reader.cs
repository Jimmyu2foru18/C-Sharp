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

namespace Ch12_Databases_DataReader
{
    public partial class Employee_Reader : Form
    {
        public Employee_Reader()
        {
            InitializeComponent();
        }
        // Create an SqlCommand object
        SqlCommand cmdEmployee = new SqlCommand();
        bool loading;
        private void Employee_Reader_Load(object sender, EventArgs e)
        {
            // cnnWorld.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =   C:\VC\HR2.mdf";

            //cmdEmployee.Connection = cnnWorld
            //or
            // 
            // Specify connection information for the SqlCommand, cmdEmployee
            cmdEmployee.Connection = new SqlConnection();
            cmdEmployee.Connection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                                                                    C:\VC\HR2.mdf";
            // Specify the SQL for the SqlCommand, cmdEmployee
            cmdEmployee.CommandText = "SELECT * FROM Employee";
        }

        private void btnDisplayData_Click(object sender, EventArgs e)
        {
            loading = true;     
            SqlDataReader drEmployee = null;
            int count = 0;

            //cnnWorld.Open()
            //or
            cmdEmployee.Connection.Open();

            // Use the ExecuteReader method to retrieve the data (specified by the SQL) 
            // into the DataReader, drEmployee
            drEmployee = cmdEmployee.ExecuteReader();

            //Read one row at a time from the DataReader.
            while (drEmployee.Read() == true)
            {

                // Display data in a ListBox:

                //lstEmployee.Items.Add(drEmployee["EmpId"].ToString &  drEmployee(1).ToString 
                //& vbTab & drEmployee(2).ToString & vbTab & drEmployee("DateOfBirth").ToString _
                //& vbTab & drEmployee("Dept").ToString & vbTab & drEmployee("nameOfCountry").ToString)

                // Instead of using field names, the index of the field may be used, as in:
                // drEmployee(0) - gets the value of EmpId.

                // or, display data in a ListView by storing the current row in an array
                int rowCount = drEmployee.FieldCount; // fieldCount would be 6.
                string[] empRow = new string[rowCount + 1];
                for (count = 0; count < rowCount; count++)
                {
                    empRow[count] = drEmployee[count].ToString(); //data is retrieved as objects
                                                                         // Loops through each field - indexes 0 to 5.
                }

                // Alternate method: 
                object[] empColumns = new object[10];
                drEmployee.GetValues(empColumns);
                //For count = 0 To 5
                //    empRow(count) = EmpRow(count).ToString
                //Next

                // Create a ListViewItem and add it to the ListView:
                ListViewItem lviEmp = new ListViewItem(empRow);
                lsvEmployee.Items.Add(lviEmp);

                //Add EmpID to the ComboBox cboEmpId
                cboID.Items.Add(drEmployee["EmpID"]);

                // Referring to fields by name, is less efficient than referring to them by 
                // their position (index).The alternate method shown below avoids this problems.
                // In both cases, data is retrieved as objects
            }

            //Alternate method:
            // In this method, the position (ordinal or index) of the columns are obtained once
            // and used to specify the fields, as shown below:
            Int32 EmpIdIndx = 0;
            Int32 LnameIndx = 0;
            Int32 FnameIndx = 0;
            Int32 DOBIndx = 0;
            Int32 DeptIndx = 0;
            Int32 CountryIndx = 0;

            EmpIdIndx = drEmployee.GetOrdinal("EmpId");
            LnameIndx = drEmployee.GetOrdinal("LastName");
            FnameIndx = drEmployee.GetOrdinal("FirstName");
            DOBIndx = drEmployee.GetOrdinal("DateOfBirth");
            DeptIndx = drEmployee.GetOrdinal("DeptNo");
            CountryIndx = drEmployee.GetOrdinal("CountryId");

            while (drEmployee.Read() == true)
            {
                lstEmployee.Items.Add(drEmployee.GetString(EmpIdIndx) + "\t" + drEmployee.GetString(LnameIndx) + "\t" + drEmployee.GetString(FnameIndx) + "\t" + drEmployee.GetDateTime(DOBIndx).ToString() + "\t" + "\t" + drEmployee.GetInt16(DeptIndx).ToString() + "\t" + drEmployee.GetString(CountryIndx));
                // Retrieving data by specifying the datatypes avoids need for data conversions

                // Add EmpID to the ComboBox cboEmpId
                cboID.Items.Add(drEmployee[EmpIdIndx]);
            }

            drEmployee.Close();
            //cnnWorld.Close()
            //or
            cmdEmployee.Connection.Close();

            loading = false;
        }

        private void cboID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loading)
            {
                string sSQL = null;
                //cnnWorld.Open()
                cmdEmployee.Connection.Open();
                SqlDataReader drEmployee = null;
                sSQL = "SELECT * FROM Employee WHERE EmpID = '" + cboID.Text + "'";
                cmdEmployee.CommandText = sSQL;

                drEmployee = cmdEmployee.ExecuteReader();
                drEmployee.Read();

                txtEmpId.Text = drEmployee[0].ToString(); //or, drEmployee("EmpId")
                txtLName.Text = drEmployee[1].ToString();
                txtDept.Text = drEmployee["Dept"].ToString();
                txtCountry.Text = drEmployee["NameOfCountry"].ToString();
                drEmployee.Close();
                //cnnWorld.Close()
                cmdEmployee.Connection.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sSQL = null;
            Int32 iCount = 0;
            string sLName = null;
            sLName = txtLName.Text;
            //cnnWorld.Open()
            cmdEmployee.Connection.Open();
            //The SQL shown below updates only the last name; but it can be extended to 
            //updating other fields too.
            sSQL = "UPDATE Employee SET  LastName = '" + sLName + "'" + " WHERE EmpID = '" + cboID.Text + "'";
            //cmdEmployee.CommandType = CommandType.Text
            cmdEmployee.CommandText = sSQL;
            try
            {
                iCount = cmdEmployee.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            //Reset the CommandText property to select all records.
            cmdEmployee.CommandText = "SELECT * FROM Employee";
            //cnnWorld.Close()
            cmdEmployee.Connection.Close();
        }
    }
}
