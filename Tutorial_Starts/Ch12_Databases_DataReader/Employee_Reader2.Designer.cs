namespace Ch12_Databases_DataReader
{
    partial class Employee_Reader2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvwEmployee = new System.Windows.Forms.ListView();
            this.EmpId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeptNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountryId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Salary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboDeptNo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lvwEmployee
            // 
            this.lvwEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmpId,
            this.LastName,
            this.FirstName,
            this.DOB,
            this.Phone,
            this.DeptNo,
            this.CountryId,
            this.Salary,
            this.FullTime,
            this.Position});
            this.lvwEmployee.Location = new System.Drawing.Point(33, 81);
            this.lvwEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvwEmployee.Name = "lvwEmployee";
            this.lvwEmployee.Size = new System.Drawing.Size(1242, 151);
            this.lvwEmployee.TabIndex = 32;
            this.lvwEmployee.UseCompatibleStateImageBehavior = false;
            this.lvwEmployee.View = System.Windows.Forms.View.Details;
            // 
            // EmpId
            // 
            this.EmpId.Text = "Emp ID";
            this.EmpId.Width = 70;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 120;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 120;
            // 
            // DOB
            // 
            this.DOB.Text = "DOB";
            this.DOB.Width = 80;
            // 
            // DeptNo
            // 
            this.DeptNo.DisplayIndex = 4;
            this.DeptNo.Text = "Dept No";
            this.DeptNo.Width = 80;
            // 
            // CountryId
            // 
            this.CountryId.DisplayIndex = 5;
            this.CountryId.Text = "Country Id";
            this.CountryId.Width = 100;
            // 
            // Salary
            // 
            this.Salary.DisplayIndex = 6;
            this.Salary.Text = "Salary";
            // 
            // Phone
            // 
            this.Phone.DisplayIndex = 7;
            this.Phone.Text = "Phone";
            // 
            // FullTime
            // 
            this.FullTime.Text = "Full Time";
            this.FullTime.Width = 80;
            // 
            // Position
            // 
            this.Position.Text = "Position";
            this.Position.Width = 70;
            // 
            // cboDeptNo
            // 
            this.cboDeptNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeptNo.FormattingEnabled = true;
            this.cboDeptNo.Location = new System.Drawing.Point(33, 27);
            this.cboDeptNo.Name = "cboDeptNo";
            this.cboDeptNo.Size = new System.Drawing.Size(177, 33);
            this.cboDeptNo.TabIndex = 33;
            this.cboDeptNo.Text = "Select DeptNo";
            this.cboDeptNo.SelectedIndexChanged += new System.EventHandler(this.cboDeptNo_SelectedIndexChanged);
            // 
            // Employee_Reader2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 257);
            this.Controls.Add(this.cboDeptNo);
            this.Controls.Add(this.lvwEmployee);
            this.Name = "Employee_Reader2";
            this.Text = "Employee_Reader2";
            this.Load += new System.EventHandler(this.Employee_Reader2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListView lvwEmployee;
        internal System.Windows.Forms.ColumnHeader EmpId;
        internal System.Windows.Forms.ColumnHeader LastName;
        internal System.Windows.Forms.ColumnHeader FirstName;
        internal System.Windows.Forms.ColumnHeader DOB;
        internal System.Windows.Forms.ColumnHeader DeptNo;
        internal System.Windows.Forms.ColumnHeader CountryId;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Salary;
        private System.Windows.Forms.ColumnHeader FullTime;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.ComboBox cboDeptNo;
    }
}