namespace Ch9_Collections
{
    partial class DictionaryArrayType
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
            this.lstDisplay.Location = new System.Drawing.Point(21, 50);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(215, 60);
            this.lstDisplay.TabIndex = 16;
            // 
            // cboProdNumber
            // 
            this.cboProdNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProdNumber.FormattingEnabled = true;
            this.cboProdNumber.Location = new System.Drawing.Point(21, 23);
            this.cboProdNumber.Name = "cboProdNumber";
            this.cboProdNumber.Size = new System.Drawing.Size(119, 24);
            this.cboProdNumber.Sorted = true;
            this.cboProdNumber.TabIndex = 17;
            this.cboProdNumber.Text = "Select Product#";
            this.cboProdNumber.SelectedIndexChanged += new System.EventHandler(this.cboProdNumber_SelectedIndexChanged);
            // 
            // DictionaryArrayType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 121);
            this.Controls.Add(this.cboProdNumber);
            this.Controls.Add(this.lstDisplay);
            this.Name = "DictionaryArrayType";
            this.Text = "DictionaryArrayType";
            this.Load += new System.EventHandler(this.DictionaryArrayType_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.ComboBox cboProdNumber;
    }
}