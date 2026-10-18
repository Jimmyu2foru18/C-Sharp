using System;

namespace Ch3_Decisions
{
    partial class Decisions
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
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.lblLetterGrade = new System.Windows.Forms.Label();
            this.lblAttendance = new System.Windows.Forms.Label();
            this.txtTotalScore = new System.Windows.Forms.TextBox();
            this.txtLetterGrade = new System.Windows.Forms.TextBox();
            this.txtAttendance = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.Location = new System.Drawing.Point(12, 20);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(63, 13);
            this.lblTotalScore.TabIndex = 0;
            this.lblTotalScore.Text = "Total score:";
            // 
            // lblLetterGrade
            // 
            this.lblLetterGrade.AutoSize = true;
            this.lblLetterGrade.Location = new System.Drawing.Point(12, 52);
            this.lblLetterGrade.Name = "lblLetterGrade";
            this.lblLetterGrade.Size = new System.Drawing.Size(69, 13);
            this.lblLetterGrade.TabIndex = 1;
            this.lblLetterGrade.Text = "Letter Grade:";
            // 
            // lblAttendance
            // 
            this.lblAttendance.AutoSize = true;
            this.lblAttendance.Location = new System.Drawing.Point(175, 19);
            this.lblAttendance.Name = "lblAttendance";
            this.lblAttendance.Size = new System.Drawing.Size(62, 13);
            this.lblAttendance.TabIndex = 2;
            this.lblAttendance.Text = "Attendance";
            // 
            // txtTotalScore
            // 
            this.txtTotalScore.Location = new System.Drawing.Point(81, 13);
            this.txtTotalScore.Name = "txtTotalScore";
            this.txtTotalScore.Size = new System.Drawing.Size(77, 20);
            this.txtTotalScore.TabIndex = 3;
            // 
            // txtLetterGrade
            // 
            this.txtLetterGrade.Location = new System.Drawing.Point(81, 45);
            this.txtLetterGrade.Name = "txtLetterGrade";
            this.txtLetterGrade.Size = new System.Drawing.Size(77, 20);
            this.txtLetterGrade.TabIndex = 4;
            // 
            // txtAttendance
            // 
            this.txtAttendance.Location = new System.Drawing.Point(243, 12);
            this.txtAttendance.Name = "txtAttendance";
            this.txtAttendance.Size = new System.Drawing.Size(77, 20);
            this.txtAttendance.TabIndex = 5;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(81, 81);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 6;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(227, 86);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(0, 13);
            this.lblGrade.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 123);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtAttendance);
            this.Controls.Add(this.txtLetterGrade);
            this.Controls.Add(this.txtTotalScore);
            this.Controls.Add(this.lblAttendance);
            this.Controls.Add(this.lblLetterGrade);
            this.Controls.Add(this.lblTotalScore);
            this.Name = "Form1";
            this.Text = "Compute Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalScore;
        private System.Windows.Forms.Label lblLetterGrade;
        private System.Windows.Forms.Label lblAttendance;
        private System.Windows.Forms.TextBox txtTotalScore;
        private System.Windows.Forms.TextBox txtLetterGrade;
        private System.Windows.Forms.TextBox txtAttendance;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblGrade;
    }
}

