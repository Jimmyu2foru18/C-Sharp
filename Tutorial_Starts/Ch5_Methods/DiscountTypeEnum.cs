using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch5_Methods
{
    public partial class DiscountTypeEnum : Form
    {
        public DiscountTypeEnum()
        {
            InitializeComponent();
        }
        enum discountTypes { NoDiscount, AAA, Govt, Senior};
        discountTypes selectedDiscType;

        private void DiscountTypeEnum_Load(object sender, EventArgs e)
        {
            string[] discTypes = { "No Discount", "AAA", "Federal Government", "Senior" };
            for (int index = 0; index <= 3; index++)
                cboDiscountType.Items.Add(discTypes[index]);
        }

        private void cboDiscountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cboDiscountType.SelectedItem.ToString())
            {
                case "No Discount":
                    selectedDiscType = discountTypes.NoDiscount;
                    break;
                case "AAA":
                    selectedDiscType = discountTypes.AAA;
                    break;
                case "Federal Government":
                    selectedDiscType = discountTypes.Govt;
                    break;
                case "Senior":
                    selectedDiscType = discountTypes.Senior;
                    break;
            }
        }

        private void ComputeRate(discountTypes discountType, ref float rate)
        {
            switch (discountType)
            {
                case discountTypes.NoDiscount:
                    rate = 125;
                    break;
                case discountTypes.AAA:
                    rate = 110;
                    break;
                case discountTypes.Govt:
                    rate = 120;
                    break;
                case discountTypes.Senior:
                    rate = 105;
                    break;
            }
        }
       
        private void btnComputeRate_Click(object sender, EventArgs e)
        {
            float rate = 0;
            ComputeRate(selectedDiscType, ref rate);

            lstDisplay.Items.Clear();
            lstDisplay.Items.Add("Rate for disc. type, " + selectedDiscType + ":  " + rate.ToString("C"));
        }
    }
}