namespace Ch_13_Employee_1
{
    partial class EmployeeForm
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
            System.Windows.Forms.Label lblBirthday;
            this.lblEmployee = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.lblHourPayRate = new System.Windows.Forms.Label();
            this.lstEmployee = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.txtHourPayRate = new System.Windows.Forms.TextBox();
            lblBirthday = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new System.Drawing.Point(44, 41);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new System.Drawing.Size(48, 13);
            lblBirthday.TabIndex = 3;
            lblBirthday.Text = "Birthday:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(12, 168);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(35, 13);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "label1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(107, 118);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 37);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(54, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(42, 68);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(50, 13);
            this.lblJobTitle.TabIndex = 4;
            this.lblJobTitle.Text = "Job Title:";
            // 
            // lblHourPayRate
            // 
            this.lblHourPayRate.AutoSize = true;
            this.lblHourPayRate.Location = new System.Drawing.Point(12, 92);
            this.lblHourPayRate.Name = "lblHourPayRate";
            this.lblHourPayRate.Size = new System.Drawing.Size(80, 13);
            this.lblHourPayRate.TabIndex = 5;
            this.lblHourPayRate.Text = "Hour Pay Rate:";
            // 
            // lstEmployee
            // 
            this.lstEmployee.FormattingEnabled = true;
            this.lstEmployee.Location = new System.Drawing.Point(212, 64);
            this.lstEmployee.Name = "lstEmployee";
            this.lstEmployee.Size = new System.Drawing.Size(472, 290);
            this.lstEmployee.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(107, 61);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(100, 20);
            this.txtJobTitle.TabIndex = 9;
            // 
            // txtHourPayRate
            // 
            this.txtHourPayRate.Location = new System.Drawing.Point(107, 92);
            this.txtHourPayRate.Name = "txtHourPayRate";
            this.txtHourPayRate.Size = new System.Drawing.Size(100, 20);
            this.txtHourPayRate.TabIndex = 10;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 365);
            this.Controls.Add(this.txtHourPayRate);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lstEmployee);
            this.Controls.Add(this.lblHourPayRate);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(lblBirthday);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEmployee);
            this.Name = "EmployeeForm";
            this.Text = "Employee Form";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label lblHourPayRate;
        private System.Windows.Forms.ListBox lstEmployee;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.TextBox txtHourPayRate;
    }
}

