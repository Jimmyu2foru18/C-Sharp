namespace Ch_6_Exercise_6_1
{
    partial class Icecream
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
            this.lblNumScoops = new System.Windows.Forms.Label();
            this.scrollBarScoops = new System.Windows.Forms.HScrollBar();
            this.comboBoxSundae = new System.Windows.Forms.ComboBox();
            this.checkBoxNuts = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblScoops = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumScoops
            // 
            this.lblNumScoops.AutoSize = true;
            this.lblNumScoops.Location = new System.Drawing.Point(12, 9);
            this.lblNumScoops.Name = "lblNumScoops";
            this.lblNumScoops.Size = new System.Drawing.Size(98, 13);
            this.lblNumScoops.TabIndex = 0;
            this.lblNumScoops.Text = "Number of Scoops:";
            // 
            // scrollBarScoops
            // 
            this.scrollBarScoops.Location = new System.Drawing.Point(15, 31);
            this.scrollBarScoops.Name = "scrollBarScoops";
            this.scrollBarScoops.Size = new System.Drawing.Size(130, 37);
            this.scrollBarScoops.TabIndex = 1;
            // 
            // comboBoxSundae
            // 
            this.comboBoxSundae.FormattingEnabled = true;
            this.comboBoxSundae.Location = new System.Drawing.Point(15, 81);
            this.comboBoxSundae.Name = "comboBoxSundae";
            this.comboBoxSundae.Size = new System.Drawing.Size(130, 21);
            this.comboBoxSundae.TabIndex = 3;
            // 
            // checkBoxNuts
            // 
            this.checkBoxNuts.AutoSize = true;
            this.checkBoxNuts.Location = new System.Drawing.Point(151, 85);
            this.checkBoxNuts.Name = "checkBoxNuts";
            this.checkBoxNuts.Size = new System.Drawing.Size(54, 17);
            this.checkBoxNuts.TabIndex = 4;
            this.checkBoxNuts.Text = "Nuts?";
            this.checkBoxNuts.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 108);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(130, 42);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Compute Amt";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(15, 156);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 29);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(120, 156);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(85, 29);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(156, 123);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 13);
            this.lblResults.TabIndex = 8;
            // 
            // lblScoops
            // 
            this.lblScoops.AutoSize = true;
            this.lblScoops.Location = new System.Drawing.Point(159, 39);
            this.lblScoops.Name = "lblScoops";
            this.lblScoops.Size = new System.Drawing.Size(0, 13);
            this.lblScoops.TabIndex = 9;
            // 
            // Icecream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 197);
            this.Controls.Add(this.lblScoops);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.checkBoxNuts);
            this.Controls.Add(this.comboBoxSundae);
            this.Controls.Add(this.scrollBarScoops);
            this.Controls.Add(this.lblNumScoops);
            this.Name = "Icecream";
            this.Text = "Ice Cream";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumScoops;
        private System.Windows.Forms.HScrollBar scrollBarScoops;
        private System.Windows.Forms.ComboBox comboBoxSundae;
        private System.Windows.Forms.CheckBox checkBoxNuts;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblScoops;
    }
}

