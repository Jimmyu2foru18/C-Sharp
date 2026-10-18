namespace ProgramBasics
{
    partial class FinancialPlanner
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
            this.txtTargetAmt = new System.Windows.Forms.TextBox();
            this.txtGrowthRate = new System.Windows.Forms.TextBox();
            this.btnHowLong = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.ItemHeight = 14;
            this.lstDisplay.Location = new System.Drawing.Point(240, 12);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(221, 368);
            this.lstDisplay.TabIndex = 18;
            // 
            // txtInvestment
            // 
            this.txtInvestment.AcceptsReturn = true;
            this.txtInvestment.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvestment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvestment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInvestment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvestment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInvestment.Location = new System.Drawing.Point(162, 12);
            this.txtInvestment.MaxLength = 0;
            this.txtInvestment.Name = "txtInvestment";
            this.txtInvestment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtInvestment.Size = new System.Drawing.Size(62, 22);
            this.txtInvestment.TabIndex = 16;
            this.txtInvestment.Text = "10000";
            // 
            // txtTargetAmt
            // 
            this.txtTargetAmt.AcceptsReturn = true;
            this.txtTargetAmt.BackColor = System.Drawing.SystemColors.Window;
            this.txtTargetAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTargetAmt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTargetAmt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetAmt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTargetAmt.Location = new System.Drawing.Point(162, 76);
            this.txtTargetAmt.MaxLength = 0;
            this.txtTargetAmt.Name = "txtTargetAmt";
            this.txtTargetAmt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTargetAmt.Size = new System.Drawing.Size(62, 22);
            this.txtTargetAmt.TabIndex = 14;
            this.txtTargetAmt.Text = "500000";
            // 
            // txtGrowthRate
            // 
            this.txtGrowthRate.AcceptsReturn = true;
            this.txtGrowthRate.BackColor = System.Drawing.SystemColors.Window;
            this.txtGrowthRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrowthRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrowthRate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrowthRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGrowthRate.Location = new System.Drawing.Point(162, 44);
            this.txtGrowthRate.MaxLength = 0;
            this.txtGrowthRate.Name = "txtGrowthRate";
            this.txtGrowthRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGrowthRate.Size = new System.Drawing.Size(62, 22);
            this.txtGrowthRate.TabIndex = 12;
            this.txtGrowthRate.Text = "7";
            // 
            // btnHowLong
            // 
            this.btnHowLong.BackColor = System.Drawing.SystemColors.Control;
            this.btnHowLong.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHowLong.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowLong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHowLong.Location = new System.Drawing.Point(90, 120);
            this.btnHowLong.Name = "btnHowLong";
            this.btnHowLong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHowLong.Size = new System.Drawing.Size(134, 25);
            this.btnHowLong.TabIndex = 11;
            this.btnHowLong.Text = "How long?";
            this.btnHowLong.UseVisualStyleBackColor = false;
            this.btnHowLong.Click += new System.EventHandler(this.btnHowLong_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Window;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label1.Location = new System.Drawing.Point(18, 12);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(129, 26);
            this.Label1.TabIndex = 17;
            this.Label1.Text = "Yearly Investment:";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.SystemColors.Window;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label3.Location = new System.Drawing.Point(18, 78);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(101, 18);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Target Amt:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Window;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label2.Location = new System.Drawing.Point(18, 46);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(117, 16);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Yearly Growth (%):";
            // 
            // FinancialPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 389);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.txtInvestment);
            this.Controls.Add(this.txtTargetAmt);
            this.Controls.Add(this.txtGrowthRate);
            this.Controls.Add(this.btnHowLong);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Name = "FinancialPlanner";
            this.Text = "Financial Planner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox lstDisplay;
        public System.Windows.Forms.TextBox txtInvestment;
        public System.Windows.Forms.TextBox txtTargetAmt;
        public System.Windows.Forms.TextBox txtGrowthRate;
        public System.Windows.Forms.Button btnHowLong;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Label Label3;
        public System.Windows.Forms.Label Label2;
    }
}