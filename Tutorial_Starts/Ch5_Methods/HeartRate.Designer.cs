namespace Ch5_Methods
{
    partial class HeartRate
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
            this.txtRestingRate = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.btnTrainingRate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRestingRate
            // 
            this.txtRestingRate.AcceptsReturn = true;
            this.txtRestingRate.BackColor = System.Drawing.SystemColors.Window;
            this.txtRestingRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRestingRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRestingRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestingRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRestingRate.Location = new System.Drawing.Point(242, 24);
            this.txtRestingRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRestingRate.MaxLength = 0;
            this.txtRestingRate.Name = "txtRestingRate";
            this.txtRestingRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRestingRate.Size = new System.Drawing.Size(82, 33);
            this.txtRestingRate.TabIndex = 39;
            // 
            // txtAge
            // 
            this.txtAge.AcceptsReturn = true;
            this.txtAge.BackColor = System.Drawing.SystemColors.Window;
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAge.Location = new System.Drawing.Point(242, 70);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAge.MaxLength = 0;
            this.txtAge.Name = "txtAge";
            this.txtAge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAge.Size = new System.Drawing.Size(82, 33);
            this.txtAge.TabIndex = 38;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.SystemColors.Window;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label5.Location = new System.Drawing.Point(16, 24);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(221, 29);
            this.Label5.TabIndex = 37;
            this.Label5.Text = "Resting Heart Rate:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.SystemColors.Window;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label4.Location = new System.Drawing.Point(16, 70);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(62, 29);
            this.Label4.TabIndex = 36;
            this.Label4.Text = "Age:";
            // 
            // lstResults
            // 
            this.lstResults.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 25;
            this.lstResults.Location = new System.Drawing.Point(351, 116);
            this.lstResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(446, 79);
            this.lstResults.TabIndex = 35;
            // 
            // btnTrainingRate
            // 
            this.btnTrainingRate.BackColor = System.Drawing.SystemColors.Control;
            this.btnTrainingRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTrainingRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainingRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTrainingRate.Location = new System.Drawing.Point(132, 116);
            this.btnTrainingRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTrainingRate.Name = "btnTrainingRate";
            this.btnTrainingRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTrainingRate.Size = new System.Drawing.Size(194, 82);
            this.btnTrainingRate.TabIndex = 34;
            this.btnTrainingRate.Text = "Compute Training Rate";
            this.btnTrainingRate.UseVisualStyleBackColor = false;
            this.btnTrainingRate.Click += new System.EventHandler(this.btnTrainingRate_Click_1);
            // 
            // HeartRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 211);
            this.Controls.Add(this.txtRestingRate);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnTrainingRate);
            this.Name = "HeartRate";
            this.Text = "HeartRate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtRestingRate;
        public System.Windows.Forms.TextBox txtAge;
        public System.Windows.Forms.Label Label5;
        public System.Windows.Forms.Label Label4;
        private System.Windows.Forms.ListBox lstResults;
        public System.Windows.Forms.Button btnTrainingRate;
    }
}