using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_13_Employee_1
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        // Load the Employee Form
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            DateTime birthdate = new DateTime(1999, 5, 1);
            Employee employee1 = new Employee("Joe Smith", birthdate, 15.75m, "Burger Flipper");
            lblEmployee.Text = employee1.ToString();
        }

        // Button to save information to list
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            DateTime birthdate = dateTimePicker1.Value;
            string jobTitle = txtJobTitle.Text;
            decimal hourlyPayRate = decimal.Parse(txtHourPayRate.Text);


            //employee class to instantiate the object
            Employee employee2 = new Employee(name, birthdate, jobTitle, hourlyPayRate);

            //add object to list
            lstEmployee.Items.Add(employee2);
        }
    }
}
