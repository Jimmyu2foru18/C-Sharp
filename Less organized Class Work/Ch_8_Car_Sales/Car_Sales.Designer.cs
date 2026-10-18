namespace Ch_8_Car_Sales
{
    partial class Car_Sales
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
            this.btnTotalGross = new System.Windows.Forms.Button();
            this.cboSelection = new System.Windows.Forms.ComboBox();
            this.lblManufacturerSelection = new System.Windows.Forms.Label();
            this.btnSpecificGross = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.txtTotalGross = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTotalGross
            // 
            this.btnTotalGross.Location = new System.Drawing.Point(12, 75);
            this.btnTotalGross.Name = "btnTotalGross";
            this.btnTotalGross.Size = new System.Drawing.Size(110, 33);
            this.btnTotalGross.TabIndex = 0;
            this.btnTotalGross.Text = "Total Gross";
            this.btnTotalGross.UseVisualStyleBackColor = true;
            this.btnTotalGross.Click += new System.EventHandler(this.btnTotalGross_Click);
            // 
            // cboSelection
            // 
            this.cboSelection.FormattingEnabled = true;
            this.cboSelection.Location = new System.Drawing.Point(11, 178);
            this.cboSelection.Name = "cboSelection";
            this.cboSelection.Size = new System.Drawing.Size(110, 21);
            this.cboSelection.TabIndex = 1;
            // 
            // lblManufacturerSelection
            // 
            this.lblManufacturerSelection.AutoSize = true;
            this.lblManufacturerSelection.Location = new System.Drawing.Point(12, 153);
            this.lblManufacturerSelection.Name = "lblManufacturerSelection";
            this.lblManufacturerSelection.Size = new System.Drawing.Size(117, 13);
            this.lblManufacturerSelection.TabIndex = 2;
            this.lblManufacturerSelection.Text = "Manufacturer Selection";
            // 
            // btnSpecificGross
            // 
            this.btnSpecificGross.Location = new System.Drawing.Point(12, 205);
            this.btnSpecificGross.Name = "btnSpecificGross";
            this.btnSpecificGross.Size = new System.Drawing.Size(110, 36);
            this.btnSpecificGross.TabIndex = 3;
            this.btnSpecificGross.Text = "Specific Gross";
            this.btnSpecificGross.UseVisualStyleBackColor = true;
            this.btnSpecificGross.Click += new System.EventHandler(this.btnSpecificGross_Click);
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(143, 17);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(307, 251);
            this.lstResults.TabIndex = 4;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(12, 20);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(109, 33);
            this.btnInfo.TabIndex = 5;
            this.btnInfo.Text = "Load Info.";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // txtTotalGross
            // 
            this.txtTotalGross.Location = new System.Drawing.Point(15, 114);
            this.txtTotalGross.Name = "txtTotalGross";
            this.txtTotalGross.Size = new System.Drawing.Size(105, 20);
            this.txtTotalGross.TabIndex = 6;
            // 
            // Car_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(462, 281);
            this.Controls.Add(this.txtTotalGross);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnSpecificGross);
            this.Controls.Add(this.lblManufacturerSelection);
            this.Controls.Add(this.cboSelection);
            this.Controls.Add(this.btnTotalGross);
            this.Name = "Car_Sales";
            this.Text = "C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTotalGross;
        private System.Windows.Forms.ComboBox cboSelection;
        private System.Windows.Forms.Label lblManufacturerSelection;
        private System.Windows.Forms.Button btnSpecificGross;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.TextBox txtTotalGross;
    }
}

