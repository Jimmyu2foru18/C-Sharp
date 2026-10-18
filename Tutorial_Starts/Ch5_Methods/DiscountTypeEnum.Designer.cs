namespace Ch5_Methods
{
    partial class DiscountTypeEnum
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
            this.cboDiscountType = new System.Windows.Forms.ComboBox();
            this.btnComputeRate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 16;
            this.lstDisplay.Location = new System.Drawing.Point(182, 38);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(293, 36);
            this.lstDisplay.TabIndex = 1;
            // 
            // cboDiscountType
            // 
            this.cboDiscountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDiscountType.FormattingEnabled = true;
            this.cboDiscountType.Location = new System.Drawing.Point(12, 15);
            this.cboDiscountType.Name = "cboDiscountType";
            this.cboDiscountType.Size = new System.Drawing.Size(164, 24);
            this.cboDiscountType.TabIndex = 2;
            this.cboDiscountType.Text = "Select Discount Type";
            this.cboDiscountType.SelectedIndexChanged += new System.EventHandler(this.cboDiscountType_SelectedIndexChanged);
            // 
            // btnComputeRate
            // 
            this.btnComputeRate.Location = new System.Drawing.Point(182, 13);
            this.btnComputeRate.Name = "btnComputeRate";
            this.btnComputeRate.Size = new System.Drawing.Size(113, 26);
            this.btnComputeRate.TabIndex = 3;
            this.btnComputeRate.Text = "Compute Rate";
            this.btnComputeRate.UseVisualStyleBackColor = true;
            this.btnComputeRate.Click += new System.EventHandler(this.btnComputeRate_Click);
            // 
            // DiscountTypeEnum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 86);
            this.Controls.Add(this.btnComputeRate);
            this.Controls.Add(this.cboDiscountType);
            this.Controls.Add(this.lstDisplay);
            this.Name = "DiscountTypeEnum";
            this.Text = "DiscountTypeEnum";
            this.Load += new System.EventHandler(this.DiscountTypeEnum_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.ComboBox cboDiscountType;
        private System.Windows.Forms.Button btnComputeRate;
    }
}