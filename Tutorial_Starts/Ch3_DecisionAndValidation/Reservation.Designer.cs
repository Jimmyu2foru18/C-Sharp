namespace Ch3_DecisionAndValidation
{
    partial class Reservation
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
            this.btnComputeDiscount = new System.Windows.Forms.Button();
            this.txtdiscountType = new System.Windows.Forms.TextBox();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnComputeDiscount
            // 
            this.btnComputeDiscount.BackColor = System.Drawing.SystemColors.Control;
            this.btnComputeDiscount.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnComputeDiscount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputeDiscount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnComputeDiscount.Location = new System.Drawing.Point(109, 48);
            this.btnComputeDiscount.Name = "btnComputeDiscount";
            this.btnComputeDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnComputeDiscount.Size = new System.Drawing.Size(138, 25);
            this.btnComputeDiscount.TabIndex = 15;
            this.btnComputeDiscount.Text = "Compute Discount";
            this.btnComputeDiscount.UseVisualStyleBackColor = false;
            this.btnComputeDiscount.Click += new System.EventHandler(this.btnComputeDiscount_Click);
            // 
            // txtdiscountType
            // 
            this.txtdiscountType.AcceptsReturn = true;
            this.txtdiscountType.BackColor = System.Drawing.SystemColors.Window;
            this.txtdiscountType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdiscountType.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscountType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtdiscountType.Location = new System.Drawing.Point(163, 17);
            this.txtdiscountType.MaxLength = 0;
            this.txtdiscountType.Name = "txtdiscountType";
            this.txtdiscountType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtdiscountType.Size = new System.Drawing.Size(84, 25);
            this.txtdiscountType.TabIndex = 14;
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.BackColor = System.Drawing.Color.White;
            this.lblDiscountPercent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiscountPercent.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDiscountPercent.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountPercent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDiscountPercent.Location = new System.Drawing.Point(163, 86);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDiscountPercent.Size = new System.Drawing.Size(49, 23);
            this.lblDiscountPercent.TabIndex = 16;
            this.lblDiscountPercent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(21, 86);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(136, 22);
            this.Label3.TabIndex = 13;
            this.Label3.Text = "Discount Percent:";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(21, 22);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(136, 23);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Discount Type:";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 125);
            this.Controls.Add(this.btnComputeDiscount);
            this.Controls.Add(this.txtdiscountType);
            this.Controls.Add(this.lblDiscountPercent);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnComputeDiscount;
        public System.Windows.Forms.TextBox txtdiscountType;
        public System.Windows.Forms.Label lblDiscountPercent;
        public System.Windows.Forms.Label Label3;
        public System.Windows.Forms.Label Label1;
    }
}