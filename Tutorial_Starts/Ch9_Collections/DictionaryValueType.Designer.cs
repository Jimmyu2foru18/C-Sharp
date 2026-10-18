namespace Ch9_Collections
{
    partial class DictionaryValueType
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
            this.cboProdNumber = new System.Windows.Forms.ComboBox();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTotalPrice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboProdNumber
            // 
            this.cboProdNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProdNumber.FormattingEnabled = true;
            this.cboProdNumber.Location = new System.Drawing.Point(22, 14);
            this.cboProdNumber.Name = "cboProdNumber";
            this.cboProdNumber.Size = new System.Drawing.Size(119, 24);
            this.cboProdNumber.Sorted = true;
            this.cboProdNumber.TabIndex = 14;
            this.cboProdNumber.Text = "Select Product#";
            this.cboProdNumber.SelectedIndexChanged += new System.EventHandler(this.cboProdNumber_SelectedIndexChanged);
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.ItemHeight = 14;
            this.lstDisplay.Location = new System.Drawing.Point(22, 41);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(215, 74);
            this.lstDisplay.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "btnDisplayAll";
            this.button1.Location = new System.Drawing.Point(153, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 26);
            this.button1.TabIndex = 15;
            this.button1.Text = "Display All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // btnTotalPrice
            // 
            this.btnTotalPrice.Location = new System.Drawing.Point(242, 15);
            this.btnTotalPrice.Name = "btnTotalPrice";
            this.btnTotalPrice.Size = new System.Drawing.Size(81, 26);
            this.btnTotalPrice.TabIndex = 16;
            this.btnTotalPrice.Text = "Total Price";
            this.btnTotalPrice.UseVisualStyleBackColor = true;
            this.btnTotalPrice.Click += new System.EventHandler(this.btnTotalPrice_Click);
            // 
            // DictionaryValueType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 117);
            this.Controls.Add(this.btnTotalPrice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboProdNumber);
            this.Controls.Add(this.lstDisplay);
            this.Name = "DictionaryValueType";
            this.Text = "DictionaryValueType";
            this.Load += new System.EventHandler(this.DictionaryValueType_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProdNumber;
        internal System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTotalPrice;
    }
}