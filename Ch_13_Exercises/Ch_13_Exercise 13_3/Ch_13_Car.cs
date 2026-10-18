using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_13_Exercise_13_3
{
    public partial class Ch_13_Car : Form
    {
        public Ch_13_Car()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                string make = txtMake.Text;
                string model = txtModel.Text;
                int year = Convert.ToInt32(txtYear.Text);

                string Description = txtDescription.Text;
                decimal amount = Convert.ToDecimal(txtAmount.Text);

                Car newCar = new Car(make, model, year);

                Repair RepairCar = new Repair(Description, amount);

                lstCars.Items.Add(newCar);
                lstCars.Items.Add(RepairCar);
            }
        }
    }
}
