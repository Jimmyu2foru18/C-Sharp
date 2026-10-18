namespace Ch7_Arrays
{
    partial class LookUpUsingArray
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
            this.btnDisplayUnitsSold = new System.Windows.Forms.Button();
            this.lblUnitsSold = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonthName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisplayUnitsSold
            // 
            this.btnDisplayUnitsSold.Location = new System.Drawing.Point(115, 47);
            this.btnDisplayUnitsSold.Name = "btnDisplayUnitsSold";
            this.btnDisplayUnitsSold.Size = new System.Drawing.Size(105, 24);
            this.btnDisplayUnitsSold.TabIndex = 9;
            this.btnDisplayUnitsSold.Text = "Display Units Sold";
            this.btnDisplayUnitsSold.UseVisualStyleBackColor = true;
            this.btnDisplayUnitsSold.Click += new System.EventHandler(this.btnDisplayUnitsSold_Click);
            // 
            // lblUnitsSold
            // 
            this.lblUnitsSold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUnitsSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitsSold.Location = new System.Drawing.Point(115, 74);
            this.lblUnitsSold.Name = "lblUnitsSold";
            this.lblUnitsSold.Size = new System.Drawing.Size(105, 24);
            this.lblUnitsSold.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Units Sold:";
            // 
            // txtMonthName
            // 
            this.txtMonthName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthName.Location = new System.Drawing.Point(115, 19);
            this.txtMonthName.Name = "txtMonthName";
            this.txtMonthName.Size = new System.Drawing.Size(105, 22);
            this.txtMonthName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Month:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(129, 108);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // LookUpUsingArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 143);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisplayUnitsSold);
            this.Controls.Add(this.lblUnitsSold);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMonthName);
            this.Controls.Add(this.label5);
            this.Name = "LookUpUsingArray";
            this.Text = "LookUpUsingArray";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayUnitsSold;
        private System.Windows.Forms.Label lblUnitsSold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonthName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
    }
}