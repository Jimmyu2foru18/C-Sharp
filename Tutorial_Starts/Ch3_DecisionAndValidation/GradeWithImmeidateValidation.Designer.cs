namespace Ch3_DecisionAndValidation
{
    partial class GradeWithImmeidateValidation
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
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGrade
            // 
            this.btnGrade.BackColor = System.Drawing.SystemColors.Control;
            this.btnGrade.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGrade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGrade.Location = new System.Drawing.Point(68, 78);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGrade.Size = new System.Drawing.Size(95, 25);
            this.btnGrade.TabIndex = 26;
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
            this.txtAttendance.Location = new System.Drawing.Point(258, 24);
            this.txtAttendance.MaxLength = 0;
            this.txtAttendance.Name = "txtAttendance";
            this.txtAttendance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAttendance.Size = new System.Drawing.Size(49, 22);
            this.txtAttendance.TabIndex = 25;
            this.txtAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtScore
            // 
            this.txtScore.AcceptsReturn = true;
            this.txtScore.BackColor = System.Drawing.SystemColors.Window;
            this.txtScore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtScore.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtScore.Location = new System.Drawing.Point(114, 23);
            this.txtScore.MaxLength = 0;
            this.txtScore.Name = "txtScore";
            this.txtScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtScore.Size = new System.Drawing.Size(49, 22);
            this.txtScore.TabIndex = 24;
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGrade
            // 
            this.lblGrade.BackColor = System.Drawing.Color.White;
            this.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrade.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblGrade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGrade.Location = new System.Drawing.Point(114, 48);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGrade.Size = new System.Drawing.Size(49, 18);
            this.lblGrade.TabIndex = 27;
            this.lblGrade.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(19, 50);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(89, 16);
            this.Label3.TabIndex = 23;
            this.Label3.Text = "Letter grade:";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(171, 24);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(81, 20);
            this.Label2.TabIndex = 22;
            this.Label2.Text = "Attendance (%):";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(22, 24);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(76, 17);
            this.Label1.TabIndex = 21;
            this.Label1.Text = "Total score:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(185, 78);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 24);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // GradeWithImmeidateValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 114);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.txtAttendance);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "GradeWithImmeidateValidation";
            this.Text = "Grade With Immeidate Validation";
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
        private System.Windows.Forms.Button btnExit;
    }
}