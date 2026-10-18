namespace Ch12_Databases_DataReader
{
    partial class Employee_Reader1
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
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnGetSalary = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnPhone = new System.Windows.Forms.Button();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPhone
            // 
            this.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(194, 85);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(146, 33);
            this.lblPhone.TabIndex = 19;
            // 
            // btnGetSalary
            // 
            this.btnGetSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetSalary.Location = new System.Drawing.Point(33, 143);
            this.btnGetSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetSalary.Name = "btnGetSalary";
            this.btnGetSalary.Size = new System.Drawing.Size(152, 40);
            this.btnGetSalary.TabIndex = 18;
            this.btnGetSalary.Text = "Get Salary";
            this.btnGetSalary.UseVisualStyleBackColor = true;
            this.btnGetSalary.Click += new System.EventHandler(this.btnGetSalary_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(350, 146);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(149, 36);
            this.lblFirstName.TabIndex = 16;
            // 
            // lblLastName
            // 
            this.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(194, 146);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(146, 36);
            this.lblLastName.TabIndex = 15;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(111, 39);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(74, 25);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "EmpId:";
            // 
            // btnPhone
            // 
            this.btnPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhone.Location = new System.Drawing.Point(33, 78);
            this.btnPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(152, 40);
            this.btnPhone.TabIndex = 13;
            this.btnPhone.Text = "Find Phone#";
            this.btnPhone.UseVisualStyleBackColor = true;
            this.btnPhone.Click += new System.EventHandler(this.btnPhone_Click);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpId.Location = new System.Drawing.Point(194, 39);
            this.txtEmpId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(81, 30);
            this.txtEmpId.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(668, 148);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(172, 35);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update Salary";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(516, 146);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(98, 30);
            this.txtSalary.TabIndex = 21;
            // 
            // Employee_Reader1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 209);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.btnGetSalary);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnPhone);
            this.Controls.Add(this.txtEmpId);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Employee_Reader1";
            this.Text = "Employee Reader 1";
            this.Load += new System.EventHandler(this.Employee_Reader1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label lblPhone;
        internal System.Windows.Forms.Button btnGetSalary;
        internal System.Windows.Forms.Label lblFirstName;
        internal System.Windows.Forms.Label lblLastName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnPhone;
        internal System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSalary;
    }
}