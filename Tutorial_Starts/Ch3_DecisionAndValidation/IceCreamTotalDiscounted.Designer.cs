namespace Ch3_DecisionAndValidation
{
    partial class IceCreamTotalDiscounted
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
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtScoops = new System.Windows.Forms.TextBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.btnComputeTotal = new System.Windows.Forms.Button();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstOutput
            // 
            this.lstOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOutput.ItemHeight = 14;
            this.lstOutput.Location = new System.Drawing.Point(159, 12);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(182, 88);
            this.lstOutput.TabIndex = 54;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(10, 10);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(77, 24);
            this.Label3.TabIndex = 53;
            this.Label3.Text = "# of Scoops::";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtScoops
            // 
            this.txtScoops.Location = new System.Drawing.Point(93, 13);
            this.txtScoops.Name = "txtScoops";
            this.txtScoops.Size = new System.Drawing.Size(60, 20);
            this.txtScoops.TabIndex = 52;
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(266, 116);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 23);
            this.cmdExit.TabIndex = 51;
            this.cmdExit.Text = "Exit";
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(175, 116);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(69, 24);
            this.cmdClear.TabIndex = 50;
            this.cmdClear.Text = "Clear";
            // 
            // btnComputeTotal
            // 
            this.btnComputeTotal.Location = new System.Drawing.Point(72, 116);
            this.btnComputeTotal.Name = "btnComputeTotal";
            this.btnComputeTotal.Size = new System.Drawing.Size(84, 24);
            this.btnComputeTotal.TabIndex = 49;
            this.btnComputeTotal.Text = "Compute Total";
            this.btnComputeTotal.Click += new System.EventHandler(this.btnComputeTotal_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(93, 39);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(60, 20);
            this.txtUnitPrice.TabIndex = 48;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(10, 39);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(82, 24);
            this.Label1.TabIndex = 47;
            this.Label1.Text = "Unit Price:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IceCreamTotalDiscounted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 153);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtScoops);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.btnComputeTotal);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.Label1);
            this.Name = "IceCreamTotalDiscounted";
            this.Text = "Icecream Total with Discount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox lstOutput;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtScoops;
        internal System.Windows.Forms.Button cmdExit;
        internal System.Windows.Forms.Button cmdClear;
        internal System.Windows.Forms.Button btnComputeTotal;
        internal System.Windows.Forms.TextBox txtUnitPrice;
        internal System.Windows.Forms.Label Label1;
    }
}

