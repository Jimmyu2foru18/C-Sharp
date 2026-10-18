namespace Ch12_Databases_DataReader
{
    partial class Employee_Reader
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
            this.btnDisplayData = new System.Windows.Forms.Button();
            this.lstEmployee = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.cboID = new System.Windows.Forms.ComboBox();
            this.lsvEmployee = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dept = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnDisplayData
            // 
            this.btnDisplayData.Location = new System.Drawing.Point(40, 12);
            this.btnDisplayData.Name = "btnDisplayData";
            this.btnDisplayData.Size = new System.Drawing.Size(96, 23);
            this.btnDisplayData.TabIndex = 3;
            this.btnDisplayData.Text = "Display Data";
            this.btnDisplayData.Click += new System.EventHandler(this.btnDisplayData_Click);
            // 
            // lstEmployee
            // 
            this.lstEmployee.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEmployee.ItemHeight = 12;
            this.lstEmployee.Location = new System.Drawing.Point(256, 159);
            this.lstEmployee.Name = "lstEmployee";
            this.lstEmployee.Size = new System.Drawing.Size(534, 76);
            this.lstEmployee.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(112, 329);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 22);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(37, 273);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(63, 23);
            this.Label5.TabIndex = 29;
            this.Label5.Text = "Country:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(106, 276);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(125, 20);
            this.txtCountry.TabIndex = 28;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(169, 302);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(62, 20);
            this.btnAddNew.TabIndex = 27;
            this.btnAddNew.Text = "Add New";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(39, 192);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(60, 21);
            this.Label4.TabIndex = 26;
            this.Label4.Text = "EmpId";
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(107, 195);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(124, 20);
            this.txtEmpId.TabIndex = 25;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(37, 247);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 23);
            this.Label3.TabIndex = 24;
            this.Label3.Text = "Dept:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(37, 218);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(73, 22);
            this.Label2.TabIndex = 23;
            this.Label2.Text = "Last Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(107, 302);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(55, 21);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(107, 250);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(124, 20);
            this.txtDept.TabIndex = 21;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(107, 221);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(124, 20);
            this.txtLName.TabIndex = 20;
            // 
            // cboID
            // 
            this.cboID.Location = new System.Drawing.Point(107, 159);
            this.cboID.Name = "cboID";
            this.cboID.Size = new System.Drawing.Size(124, 21);
            this.cboID.TabIndex = 19;
            this.cboID.Text = "Select Emp Id";
            this.cboID.SelectedIndexChanged += new System.EventHandler(this.cboID_SelectedIndexChanged);
            // 
            // lsvEmployee
            // 
            this.lsvEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.LastName,
            this.FirstName,
            this.DOB,
            this.Dept,
            this.Country});
            this.lsvEmployee.Location = new System.Drawing.Point(40, 41);
            this.lsvEmployee.Name = "lsvEmployee";
            this.lsvEmployee.Size = new System.Drawing.Size(534, 112);
            this.lsvEmployee.TabIndex = 31;
            this.lsvEmployee.UseCompatibleStateImageBehavior = false;
            this.lsvEmployee.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Emp ID";
            this.Id.Width = 100;
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
            // 
            // Dept
            // 
            this.Dept.Text = "Dept";
            // 
            // Country
            // 
            this.Country.Text = "Country";
            this.Country.Width = 200;
            // 
            // Employee_Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 467);
            this.Controls.Add(this.lsvEmployee);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.cboID);
            this.Controls.Add(this.btnDisplayData);
            this.Controls.Add(this.lstEmployee);
            this.Name = "Employee_Reader";
            this.Text = "Employee Reader";
            this.Load += new System.EventHandler(this.Employee_Reader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnDisplayData;
        internal System.Windows.Forms.ListBox lstEmployee;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtCountry;
        internal System.Windows.Forms.Button btnAddNew;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtEmpId;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.TextBox txtDept;
        internal System.Windows.Forms.TextBox txtLName;
        internal System.Windows.Forms.ComboBox cboID;
        internal System.Windows.Forms.ListView lsvEmployee;
        internal System.Windows.Forms.ColumnHeader Id;
        internal System.Windows.Forms.ColumnHeader LastName;
        internal System.Windows.Forms.ColumnHeader FirstName;
        internal System.Windows.Forms.ColumnHeader DOB;
        internal System.Windows.Forms.ColumnHeader Dept;
        internal System.Windows.Forms.ColumnHeader Country;
    }
}

