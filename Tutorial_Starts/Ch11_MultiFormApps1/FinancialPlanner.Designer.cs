namespace MultiFormApps1
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
            this.txtInvestment = new System.Windows.Forms.TextBox();
            this.txtTargetAmt = new System.Windows.Forms.TextBox();
            this.txtGrowthRate = new System.Windows.Forms.TextBox();
            this.btnHowlong = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnUnhideDisplayForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInvestment
            // 
            this.txtInvestment.AcceptsReturn = true;
            this.txtInvestment.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvestment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvestment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInvestment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvestment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInvestment.Location = new System.Drawing.Point(166, 17);
            this.txtInvestment.MaxLength = 0;
            this.txtInvestment.Name = "txtInvestment";
            this.txtInvestment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtInvestment.Size = new System.Drawing.Size(62, 22);
            this.txtInvestment.TabIndex = 23;
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
            this.txtTargetAmt.Location = new System.Drawing.Point(166, 81);
            this.txtTargetAmt.MaxLength = 0;
            this.txtTargetAmt.Name = "txtTargetAmt";
            this.txtTargetAmt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTargetAmt.Size = new System.Drawing.Size(62, 22);
            this.txtTargetAmt.TabIndex = 21;
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
            this.txtGrowthRate.Location = new System.Drawing.Point(166, 49);
            this.txtGrowthRate.MaxLength = 0;
            this.txtGrowthRate.Name = "txtGrowthRate";
            this.txtGrowthRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGrowthRate.Size = new System.Drawing.Size(62, 22);
            this.txtGrowthRate.TabIndex = 19;
            this.txtGrowthRate.Text = "7";
            // 
            // btnHowlong
            // 
            this.btnHowlong.BackColor = System.Drawing.SystemColors.Control;
            this.btnHowlong.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHowlong.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowlong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHowlong.Location = new System.Drawing.Point(257, 18);
            this.btnHowlong.Name = "btnHowlong";
            this.btnHowlong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHowlong.Size = new System.Drawing.Size(144, 25);
            this.btnHowlong.TabIndex = 18;
            this.btnHowlong.Text = "How Long?";
            this.btnHowlong.UseVisualStyleBackColor = false;
            this.btnHowlong.Click += new System.EventHandler(this.btnHowlong_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Window;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label1.Location = new System.Drawing.Point(22, 17);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(129, 26);
            this.Label1.TabIndex = 24;
            this.Label1.Text = "Yearly Investment:";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.SystemColors.Window;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label3.Location = new System.Drawing.Point(22, 83);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(101, 18);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "Target Amt:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Window;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label2.Location = new System.Drawing.Point(22, 51);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(117, 16);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "Yearly Growth (%):";
            // 
            // btnUnhideDisplayForm
            // 
            this.btnUnhideDisplayForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnhideDisplayForm.Location = new System.Drawing.Point(257, 49);
            this.btnUnhideDisplayForm.Name = "btnUnhideDisplayForm";
            this.btnUnhideDisplayForm.Size = new System.Drawing.Size(144, 28);
            this.btnUnhideDisplayForm.TabIndex = 26;
            this.btnUnhideDisplayForm.Text = "Unhide Display Form";
            this.btnUnhideDisplayForm.UseVisualStyleBackColor = true;
            this.btnUnhideDisplayForm.Click += new System.EventHandler(this.btnUnhideDisplayForm_Click);
            // 
            // FinancialPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 117);
            this.Controls.Add(this.btnUnhideDisplayForm);
            this.Controls.Add(this.txtInvestment);
            this.Controls.Add(this.txtTargetAmt);
            this.Controls.Add(this.txtGrowthRate);
            this.Controls.Add(this.btnHowlong);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Name = "FinancialPlanner";
            this.Text = "Financial Planner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtInvestment;
        public System.Windows.Forms.TextBox txtTargetAmt;
        public System.Windows.Forms.TextBox txtGrowthRate;
        public System.Windows.Forms.Button btnHowlong;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Label Label3;
        public System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button btnUnhideDisplayForm;
    }
}

