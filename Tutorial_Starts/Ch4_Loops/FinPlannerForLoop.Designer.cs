namespace ProgramBasics
{
    partial class FinPlannerForLoop
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
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.txtInvestment = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.txtGrowthRate = new System.Windows.Forms.TextBox();
            this.btnInvestment = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.ItemHeight = 14;
            this.lstDisplay.Location = new System.Drawing.Point(239, 22);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(217, 354);
            this.lstDisplay.TabIndex = 26;
            // 
            // txtInvestment
            // 
            this.txtInvestment.AcceptsReturn = true;
            this.txtInvestment.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvestment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvestment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInvestment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvestment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInvestment.Location = new System.Drawing.Point(161, 22);
            this.txtInvestment.MaxLength = 0;
            this.txtInvestment.Name = "txtInvestment";
            this.txtInvestment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtInvestment.Size = new System.Drawing.Size(58, 22);
            this.txtInvestment.TabIndex = 24;
            this.txtInvestment.Text = "10000";
            // 
            // txtYears
            // 
            this.txtYears.AcceptsReturn = true;
            this.txtYears.BackColor = System.Drawing.SystemColors.Window;
            this.txtYears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYears.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYears.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYears.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtYears.Location = new System.Drawing.Point(161, 86);
            this.txtYears.MaxLength = 0;
            this.txtYears.Name = "txtYears";
            this.txtYears.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtYears.Size = new System.Drawing.Size(58, 22);
            this.txtYears.TabIndex = 22;
            this.txtYears.Text = "22";
            // 
            // txtGrowthRate
            // 
            this.txtGrowthRate.AcceptsReturn = true;
            this.txtGrowthRate.BackColor = System.Drawing.SystemColors.Window;
            this.txtGrowthRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrowthRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrowthRate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrowthRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGrowthRate.Location = new System.Drawing.Point(161, 54);
            this.txtGrowthRate.MaxLength = 0;
            this.txtGrowthRate.Name = "txtGrowthRate";
            this.txtGrowthRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGrowthRate.Size = new System.Drawing.Size(58, 22);
            this.txtGrowthRate.TabIndex = 20;
            this.txtGrowthRate.Text = "7";
            // 
            // btnInvestment
            // 
            this.btnInvestment.BackColor = System.Drawing.SystemColors.Control;
            this.btnInvestment.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnInvestment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvestment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInvestment.Location = new System.Drawing.Point(67, 130);
            this.btnInvestment.Name = "btnInvestment";
            this.btnInvestment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInvestment.Size = new System.Drawing.Size(152, 25);
            this.btnInvestment.TabIndex = 19;
            this.btnInvestment.Text = "Compute Investment";
            this.btnInvestment.UseVisualStyleBackColor = false;
            this.btnInvestment.Click += new System.EventHandler(this.btnInvestment_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Window;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label1.Location = new System.Drawing.Point(17, 22);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(125, 26);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Yearly Investment:";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.SystemColors.Window;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label3.Location = new System.Drawing.Point(17, 88);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(97, 18);
            this.Label3.TabIndex = 23;
            this.Label3.Text = "No. of Years:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Window;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label2.Location = new System.Drawing.Point(17, 56);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(117, 16);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "Yearly Growth (%):";
            // 
            // FinPlannerForLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 383);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.txtInvestment);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.txtGrowthRate);
            this.Controls.Add(this.btnInvestment);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Name = "FinPlannerForLoop";
            this.Text = "FinPlannerForLoop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox lstDisplay;
        public System.Windows.Forms.TextBox txtInvestment;
        public System.Windows.Forms.TextBox txtYears;
        public System.Windows.Forms.TextBox txtGrowthRate;
        public System.Windows.Forms.Button btnInvestment;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Label Label3;
        public System.Windows.Forms.Label Label2;
    }
}