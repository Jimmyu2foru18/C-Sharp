namespace Ch11_MultiFormApps2
{
    partial class ProductsMain
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
            this.btnLookUp = new System.Windows.Forms.Button();
            this.btnDisplayPrices = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLookUp
            // 
            this.btnLookUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookUp.Location = new System.Drawing.Point(42, 72);
            this.btnLookUp.Name = "btnLookUp";
            this.btnLookUp.Size = new System.Drawing.Size(119, 28);
            this.btnLookUp.TabIndex = 0;
            this.btnLookUp.Text = "Look Up Price";
            this.btnLookUp.UseVisualStyleBackColor = true;
            // 
            // btnDisplayPrices
            // 
            this.btnDisplayPrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayPrices.Location = new System.Drawing.Point(42, 106);
            this.btnDisplayPrices.Name = "btnDisplayPrices";
            this.btnDisplayPrices.Size = new System.Drawing.Size(118, 26);
            this.btnDisplayPrices.TabIndex = 1;
            this.btnDisplayPrices.Text = "Display Products";
            this.btnDisplayPrices.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(42, 154);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 25);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // ProductsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 192);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplayPrices);
            this.Controls.Add(this.btnLookUp);
            this.Name = "ProductsMain";
            this.Text = "Products Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLookUp;
        private System.Windows.Forms.Button btnDisplayPrices;
        private System.Windows.Forms.Button btnExit;
    }
}