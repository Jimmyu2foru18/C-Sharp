namespace Ch_5_Method_Writing_HW
{
    partial class Ch_5_Hotel_Discount
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
            this.btnCompute = new System.Windows.Forms.Button();
            this.cbDiscount = new System.Windows.Forms.ComboBox();
            this.cbPets = new System.Windows.Forms.ComboBox();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblPets = new System.Windows.Forms.Label();
            this.lblWeekend = new System.Windows.Forms.Label();
            this.cbWeek = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(53, 92);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(171, 63);
            this.btnCompute.TabIndex = 0;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // cbDiscount
            // 
            this.cbDiscount.FormattingEnabled = true;
            this.cbDiscount.Location = new System.Drawing.Point(103, 6);
            this.cbDiscount.Name = "cbDiscount";
            this.cbDiscount.Size = new System.Drawing.Size(121, 21);
            this.cbDiscount.TabIndex = 1;
            // 
            // cbPets
            // 
            this.cbPets.FormattingEnabled = true;
            this.cbPets.Location = new System.Drawing.Point(103, 35);
            this.cbPets.Name = "cbPets";
            this.cbPets.Size = new System.Drawing.Size(121, 21);
            this.cbPets.TabIndex = 2;
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(10, 161);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(214, 199);
            this.lstResults.TabIndex = 3;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(23, 9);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(55, 13);
            this.lblDiscount.TabIndex = 4;
            this.lblDiscount.Text = "Discount?";
            // 
            // lblPets
            // 
            this.lblPets.AutoSize = true;
            this.lblPets.Location = new System.Drawing.Point(44, 43);
            this.lblPets.Name = "lblPets";
            this.lblPets.Size = new System.Drawing.Size(34, 13);
            this.lblPets.TabIndex = 5;
            this.lblPets.Text = "Pets?";
            // 
            // lblWeekend
            // 
            this.lblWeekend.AutoSize = true;
            this.lblWeekend.Location = new System.Drawing.Point(18, 73);
            this.lblWeekend.Name = "lblWeekend";
            this.lblWeekend.Size = new System.Drawing.Size(60, 13);
            this.lblWeekend.TabIndex = 6;
            this.lblWeekend.Text = "Weekend?";
            // 
            // cbWeek
            // 
            this.cbWeek.FormattingEnabled = true;
            this.cbWeek.Location = new System.Drawing.Point(103, 65);
            this.cbWeek.Name = "cbWeek";
            this.cbWeek.Size = new System.Drawing.Size(121, 21);
            this.cbWeek.TabIndex = 7;
            // 
            // Ch_5_Hotel_Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 378);
            this.Controls.Add(this.cbWeek);
            this.Controls.Add(this.lblWeekend);
            this.Controls.Add(this.lblPets);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.cbPets);
            this.Controls.Add(this.cbDiscount);
            this.Controls.Add(this.btnCompute);
            this.Name = "Ch_5_Hotel_Discount";
            this.Text = "Hotel Discount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.ComboBox cbDiscount;
        private System.Windows.Forms.ComboBox cbPets;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblPets;
        private System.Windows.Forms.Label lblWeekend;
        private System.Windows.Forms.ComboBox cbWeek;
    }
}

