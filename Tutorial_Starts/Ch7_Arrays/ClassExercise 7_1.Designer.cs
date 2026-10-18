namespace Ch7_Arrays
{
    partial class ClassExercise_7_2
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
            this.btnDisplayMonth = new System.Windows.Forms.Button();
            this.lblMonthName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMonthNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDisplayMonth
            // 
            this.btnDisplayMonth.Location = new System.Drawing.Point(113, 43);
            this.btnDisplayMonth.Name = "btnDisplayMonth";
            this.btnDisplayMonth.Size = new System.Drawing.Size(105, 24);
            this.btnDisplayMonth.TabIndex = 9;
            this.btnDisplayMonth.Text = "Display Month";
            this.btnDisplayMonth.UseVisualStyleBackColor = true;
            this.btnDisplayMonth.Click += new System.EventHandler(this.btnDisplayMonth_Click);
            // 
            // lblMonthName
            // 
            this.lblMonthName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMonthName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthName.Location = new System.Drawing.Point(113, 76);
            this.lblMonthName.Name = "lblMonthName";
            this.lblMonthName.Size = new System.Drawing.Size(105, 24);
            this.lblMonthName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Month Name:";
            // 
            // txtMonthNumber
            // 
            this.txtMonthNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthNumber.Location = new System.Drawing.Point(113, 15);
            this.txtMonthNumber.Name = "txtMonthNumber";
            this.txtMonthNumber.Size = new System.Drawing.Size(38, 22);
            this.txtMonthNumber.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Month#:";
            // 
            // ClassExercise_7_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 112);
            this.Controls.Add(this.btnDisplayMonth);
            this.Controls.Add(this.lblMonthName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonthNumber);
            this.Controls.Add(this.label1);
            this.Name = "ClassExercise_7_2";
            this.Text = "ClassExercise_7_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayMonth;
        private System.Windows.Forms.Label lblMonthName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMonthNumber;
        private System.Windows.Forms.Label label1;
    }
}