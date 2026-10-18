using System.Collections.Generic;
using System.Windows.Forms;

namespace Exercises_Ch1
{
    partial class MilesPerGallon
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
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.gallonsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.lblMilesDriven = new System.Windows.Forms.Label();
            this.lblGallonsUsed = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // milesTextBox
            // 
            this.milesTextBox.Location = new System.Drawing.Point(75, 40);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(100, 20);
            this.milesTextBox.TabIndex = 0;
            // 
            // gallonsTextBox
            // 
            this.gallonsTextBox.Location = new System.Drawing.Point(75, 76);
            this.gallonsTextBox.Name = "gallonsTextBox";
            this.gallonsTextBox.Size = new System.Drawing.Size(100, 20);
            this.gallonsTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(75, 117);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(65, 160);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 3;
            // 
            // lblMilesDriven
            // 
            this.lblMilesDriven.AutoSize = true;
            this.lblMilesDriven.Location = new System.Drawing.Point(4, 47);
            this.lblMilesDriven.Name = "lblMilesDriven";
            this.lblMilesDriven.Size = new System.Drawing.Size(68, 13);
            this.lblMilesDriven.TabIndex = 4;
            this.lblMilesDriven.Text = "Miles Driven:";
            // 
            // lblGallonsUsed
            // 
            this.lblGallonsUsed.AutoSize = true;
            this.lblGallonsUsed.Location = new System.Drawing.Point(4, 79);
            this.lblGallonsUsed.Name = "lblGallonsUsed";
            this.lblGallonsUsed.Size = new System.Drawing.Size(73, 13);
            this.lblGallonsUsed.TabIndex = 5;
            this.lblGallonsUsed.Text = "Gallons Used:";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(12, 160);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(45, 13);
            this.lblResults.TabIndex = 6;
            this.lblResults.Text = "Results:";
            // 
            // MilesPerGallon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 195);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblGallonsUsed);
            this.Controls.Add(this.lblMilesDriven);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.gallonsTextBox);
            this.Controls.Add(this.milesTextBox);
            this.Name = "MilesPerGallon";
            this.Text = "Miles Per Gallon Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.TextBox gallonsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label resultLabel;
        private Label lblMilesDriven;
        private Label lblGallonsUsed;
        private Label lblResults;
    }
}

