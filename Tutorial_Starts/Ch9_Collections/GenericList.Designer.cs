namespace Ch9_Collections
{
    partial class GenericList
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
            this.cboProdNumber = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.ItemHeight = 14;
            this.lstDisplay.Location = new System.Drawing.Point(21, 39);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(274, 46);
            this.lstDisplay.TabIndex = 8;
            // 
            // cboProdNumber
            // 
            this.cboProdNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProdNumber.FormattingEnabled = true;
            this.cboProdNumber.Location = new System.Drawing.Point(21, 12);
            this.cboProdNumber.Name = "cboProdNumber";
            this.cboProdNumber.Size = new System.Drawing.Size(119, 24);
            this.cboProdNumber.Sorted = true;
            this.cboProdNumber.TabIndex = 12;
            this.cboProdNumber.Text = "Select Product#";
            this.cboProdNumber.SelectedIndexChanged += new System.EventHandler(this.cboProdNumber_SelectedIndexChanged);
            // 
            // GenericList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 100);
            this.Controls.Add(this.cboProdNumber);
            this.Controls.Add(this.lstDisplay);
            this.Name = "GenericList";
            this.Text = "Generic List to Find Sales";
            this.Load += new System.EventHandler(this.GenericList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.ComboBox cboProdNumber;
    }
}

