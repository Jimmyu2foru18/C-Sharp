namespace Ch12_Databases_UntypedDatasets
{
    partial class Employee_AddEdDel
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
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblRecordNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label0 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.rdbStaff = new System.Windows.Forms.RadioButton();
            this.rdbMgr = new System.Windows.Forms.RadioButton();
            this.rdbVP = new System.Windows.Forms.RadioButton();
            this.txtCountryId = new System.Windows.Forms.TextBox();
            this.chkFullTime = new System.Windows.Forms.CheckBox();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboDeptNo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(244, 298);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(56, 23);
            this.btnLast.TabIndex = 263;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(51, 296);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(56, 23);
            this.btnFirst.TabIndex = 262;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(113, 298);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(56, 23);
            this.btnPrevious.TabIndex = 261;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(175, 298);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(63, 23);
            this.btnNext.TabIndex = 260;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblRecordNo
            // 
            this.lblRecordNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRecordNo.Location = new System.Drawing.Point(103, 276);
            this.lblRecordNo.Name = "lblRecordNo";
            this.lblRecordNo.Size = new System.Drawing.Size(96, 18);
            this.lblRecordNo.TabIndex = 259;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(56, 194);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(41, 14);
            this.label3.TabIndex = 258;
            this.label3.Text = "Salary:";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(100, 194);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(99, 20);
            this.txtSalary.TabIndex = 270;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.BackColor = System.Drawing.Color.White;
            this.Phone.Cursor = System.Windows.Forms.Cursors.Default;
            this.Phone.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Phone.Location = new System.Drawing.Point(57, 120);
            this.Phone.Name = "Phone";
            this.Phone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Phone.Size = new System.Drawing.Size(40, 14);
            this.Phone.TabIndex = 256;
            this.Phone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(103, 120);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(97, 20);
            this.txtPhone.TabIndex = 240;
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.BackColor = System.Drawing.Color.White;
            this.Country.Cursor = System.Windows.Forms.Cursors.Default;
            this.Country.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Country.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Country.Location = new System.Drawing.Point(41, 168);
            this.Country.Name = "Country";
            this.Country.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Country.Size = new System.Drawing.Size(56, 14);
            this.Country.TabIndex = 254;
            this.Country.Text = "CountryId:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label2.Location = new System.Drawing.Point(65, 94);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(32, 14);
            this.Label2.TabIndex = 253;
            this.Label2.Text = "DOB:";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.Color.White;
            this.Label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label13.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label13.Location = new System.Drawing.Point(49, 144);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label13.Size = new System.Drawing.Size(48, 14);
            this.Label13.TabIndex = 252;
            this.Label13.Text = "Dept No:";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.White;
            this.Label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label12.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label12.Location = new System.Drawing.Point(37, 68);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label12.Size = new System.Drawing.Size(61, 14);
            this.Label12.TabIndex = 251;
            this.Label12.Text = "First Name:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label1.Location = new System.Drawing.Point(37, 42);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(61, 14);
            this.Label1.TabIndex = 250;
            this.Label1.Text = "Last Name:";
            // 
            // Label0
            // 
            this.Label0.AutoSize = true;
            this.Label0.BackColor = System.Drawing.Color.White;
            this.Label0.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label0.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label0.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label0.Location = new System.Drawing.Point(59, 16);
            this.Label0.Name = "Label0";
            this.Label0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label0.Size = new System.Drawing.Size(39, 14);
            this.Label0.TabIndex = 249;
            this.Label0.Text = "EmpID:";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(49, 239);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(48, 16);
            this.Label5.TabIndex = 248;
            this.Label5.Text = "Position:";
            // 
            // rdbStaff
            // 
            this.rdbStaff.Location = new System.Drawing.Point(203, 239);
            this.rdbStaff.Name = "rdbStaff";
            this.rdbStaff.Size = new System.Drawing.Size(48, 16);
            this.rdbStaff.TabIndex = 283;
            this.rdbStaff.Text = "Staff";
            // 
            // rdbMgr
            // 
            this.rdbMgr.Location = new System.Drawing.Point(149, 239);
            this.rdbMgr.Name = "rdbMgr";
            this.rdbMgr.Size = new System.Drawing.Size(48, 16);
            this.rdbMgr.TabIndex = 282;
            this.rdbMgr.Text = " Mgr";
            // 
            // rdbVP
            // 
            this.rdbVP.Location = new System.Drawing.Point(99, 240);
            this.rdbVP.Name = "rdbVP";
            this.rdbVP.Size = new System.Drawing.Size(45, 14);
            this.rdbVP.TabIndex = 2281;
            this.rdbVP.Text = "VP";
            // 
            // txtCountryId
            // 
            this.txtCountryId.Location = new System.Drawing.Point(100, 168);
            this.txtCountryId.Name = "txtCountryId";
            this.txtCountryId.Size = new System.Drawing.Size(99, 20);
            this.txtCountryId.TabIndex = 260;
            // 
            // chkFullTime
            // 
            this.chkFullTime.Location = new System.Drawing.Point(103, 216);
            this.chkFullTime.Name = "chkFullTime";
            this.chkFullTime.Size = new System.Drawing.Size(80, 24);
            this.chkFullTime.TabIndex = 2280;
            this.chkFullTime.Text = "Full Time?";
            // 
            // txtEmpId
            // 
            this.txtEmpId.BackColor = System.Drawing.Color.White;
            this.txtEmpId.Location = new System.Drawing.Point(103, 16);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(96, 20);
            this.txtEmpId.TabIndex = 200;
            // 
            // txtDOB
            // 
            this.txtDOB.AcceptsReturn = true;
            this.txtDOB.BackColor = System.Drawing.Color.White;
            this.txtDOB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDOB.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDOB.Location = new System.Drawing.Point(103, 94);
            this.txtDOB.MaxLength = 0;
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDOB.Size = new System.Drawing.Size(97, 20);
            this.txtDOB.TabIndex = 230;
            // 
            // txtFirstName
            // 
            this.txtFirstName.AcceptsReturn = true;
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFirstName.Location = new System.Drawing.Point(103, 68);
            this.txtFirstName.MaxLength = 0;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFirstName.Size = new System.Drawing.Size(97, 20);
            this.txtFirstName.TabIndex = 220;
            // 
            // txtLastName
            // 
            this.txtLastName.AcceptsReturn = true;
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLastName.Location = new System.Drawing.Point(103, 42);
            this.txtLastName.MaxLength = 0;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLastName.Size = new System.Drawing.Size(97, 20);
            this.txtLastName.TabIndex = 210;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(244, 45);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 24);
            this.btnCancel.TabIndex = 269;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(244, 75);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 24);
            this.btnSave.TabIndex = 268;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(244, 105);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 26);
            this.btnDelete.TabIndex = 267;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(244, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 24);
            this.btnAdd.TabIndex = 265;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(244, 140);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 22);
            this.btnExit.TabIndex = 270;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // cboDeptNo
            // 
            this.cboDeptNo.FormattingEnabled = true;
            this.cboDeptNo.Location = new System.Drawing.Point(100, 144);
            this.cboDeptNo.Name = "cboDeptNo";
            this.cboDeptNo.Size = new System.Drawing.Size(100, 21);
            this.cboDeptNo.TabIndex = 250;
            this.cboDeptNo.Text = "Select Dept";
            // 
            // Employee_AddEdDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 333);
            this.Controls.Add(this.cboDeptNo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblRecordNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label0);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.rdbStaff);
            this.Controls.Add(this.rdbMgr);
            this.Controls.Add(this.rdbVP);
            this.Controls.Add(this.txtCountryId);
            this.Controls.Add(this.chkFullTime);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Name = "Employee_AddEdDel";
            this.Text = "Add/Edit/Delete Employee Records";
            this.Load += new System.EventHandler(this.Employee_AddEdDel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnLast;
        internal System.Windows.Forms.Button btnFirst;
        internal System.Windows.Forms.Button btnPrevious;
        internal System.Windows.Forms.Button btnNext;
        internal System.Windows.Forms.Label lblRecordNo;
        public System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtSalary;
        public System.Windows.Forms.Label Phone;
        internal System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.Label Country;
        public System.Windows.Forms.Label Label2;
        public System.Windows.Forms.Label Label13;
        public System.Windows.Forms.Label Label12;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Label Label0;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.RadioButton rdbStaff;
        internal System.Windows.Forms.RadioButton rdbMgr;
        internal System.Windows.Forms.RadioButton rdbVP;
        internal System.Windows.Forms.TextBox txtCountryId;
        internal System.Windows.Forms.CheckBox chkFullTime;
        internal System.Windows.Forms.TextBox txtEmpId;
        public System.Windows.Forms.TextBox txtDOB;
        public System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cboDeptNo;
    }
}