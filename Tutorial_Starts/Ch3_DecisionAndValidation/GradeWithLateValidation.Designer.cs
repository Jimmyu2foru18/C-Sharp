namespace Ch3_DecisionAndValidation
{
    partial class GradeWithLateValidation
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
            this.btnGrade = new System.Windows.Forms.Button();
            this.txtAttendance = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGrade
            // 
            this.btnGrade.BackColor = System.Drawing.SystemColors.Control;
            this.btnGrade.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGrade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGrade.Location = new System.Drawing.Point(67, 74);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGrade.Size = new System.Drawing.Size(95, 25);
            this.btnGrade.TabIndex = 19;
            this.btnGrade.Text = "Compute Grade";
            this.btnGrade.UseVisualStyleBackColor = false;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // txtAttendance
            // 
            this.txtAttendance.AcceptsReturn = true;
            this.txtAttendance.BackColor = System.Drawing.SystemColors.Window;
            this.txtAttendance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAttendance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttendance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAttendance.Location = new System.Drawing.Point(257, 20);
            this.txtAttendance.MaxLength = 0;
            this.txtAttendance.Name = "txtAttendance";
            this.txtAttendance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAttendance.Size = new System.Drawing.Size(49, 22);
            this.txtAttendance.TabIndex = 18;
            this.txtAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtScore
            // 
            this.txtScore.AcceptsReturn = true;
            this.txtScore.BackColor = System.Drawing.SystemColors.Window;
            this.txtScore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtScore.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtScore.Location = new System.Drawing.Point(113, 19);
            this.txtScore.MaxLength = 0;
            this.txtScore.Name = "txtScore";
            this.txtScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtScore.Size = new System.Drawing.Size(49, 22);
            this.txtScore.TabIndex = 17;
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGrade
            // 
            this.lblGrade.BackColor = System.Drawing.Color.White;
            this.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrade.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblGrade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGrade.Location = new System.Drawing.Point(113, 44);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGrade.Size = new System.Drawing.Size(49, 18);
            this.lblGrade.TabIndex = 20;
            this.lblGrade.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(18, 46);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(89, 16);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Letter grade:";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(170, 20);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(81, 20);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Attendance (%):";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(21, 20);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(76, 17);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Total score:";
            // 
            // GradeWithLateValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 113);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.txtAttendance);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "GradeWithLateValidation";
            this.Text = "Grade With Late Validation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGrade;
        public System.Windows.Forms.TextBox txtAttendance;
        public System.Windows.Forms.TextBox txtScore;
        public System.Windows.Forms.Label lblGrade;
        public System.Windows.Forms.Label Label3;
        public System.Windows.Forms.Label Label2;
        public System.Windows.Forms.Label Label1;
    }
}