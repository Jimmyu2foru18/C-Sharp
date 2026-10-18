using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_8_Car_Sales
{
    public partial class Car_Sales : Form
    {
        private string[,] sales;

        public Car_Sales()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            CarSales();
            ComboBoxFill();
        }

        private void CarSales()
        {
            StreamReader read = new StreamReader("CarSales.txt");
            string brand;
            int line = 0;
            while ((brand = read.ReadLine()) != null)
            {
                string[] data = brand.Split(',');
                if (sales == null)
                {
                    sales = new string[data.Length, 5];
                }
                for (int j = 0; j < data.Length; j++)
                {
                    sales[line, j] = data[j].Trim();
                }
                line++;
            }
            read.Close();
            lstResults.Items.Clear();
            lstResults.Items.Add("Company\t\tQ1\tQ2\tQ3\tQ4");
            for (int i = 0; i < line; i++)
            {
                lstResults.Items.Add($"{sales[i, 0]} \t\t{sales[i, 1]}\t{sales[i, 2]}\t{sales[i, 3]}\t{sales[i, 4]}");
            }
        }

        private void ComboBoxFill()
        {
            cboSelection.Items.Clear();
            if (sales != null && sales.GetLength(0) > 0)
            {
                for (int i = 0; i < sales.GetLength(0); i++)
                {
                    string manufacturer = sales[i, 0];
                    if (manufacturer != null && !cboSelection.Items.Contains(manufacturer))
                    { 
                        cboSelection.Items.Add(manufacturer);
                    }
                }
            }
        }

        private void btnTotalGross_Click(object sender, EventArgs e)
        {
            //had to google to check for null or wouldnt work
            if (sales == null)
            {
                return;
            }

            int totalGross = 0;
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (int.TryParse(sales[i, j], out int sale))
                    {
                        totalGross += sale;
                    }
                }
            }
            lstResults.Items.Add("");
            lstResults.Items.Add($"Total Gross is \t\t{totalGross}");
            txtTotalGross.Text = totalGross.ToString();
        }

        private void btnSpecificGross_Click(object sender, EventArgs e)
        {
            //had to google to check for null or wouldnt work
            if (cboSelection.SelectedItem == null)
            {
                return;
            }

            string selectedManufacturer = cboSelection.SelectedItem.ToString();
            int specificGross = 0;
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                if (sales[i, 0] == selectedManufacturer)
                {
                    for (int j = 1; j < 5; j++)
                    {
                        if (int.TryParse(sales[i, j], out int sale))
                        {
                            specificGross += sale;
                        }
                    }
                    break;
                }
            }
            lstResults.Items.Add("");
            lstResults.Items.Add($"Gross Sales for {selectedManufacturer}: \t{specificGross}");
            MessageBox.Show($"Gross Sales for {selectedManufacturer}: {specificGross}");
        }
    }
}
