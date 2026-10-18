namespace Ch_3_Number_Guessing_Game_
{
    partial class Ch_4_Guessing_Game
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
            this.lblEnterNum = new System.Windows.Forms.Label();
            this.txtEnterNum = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblEnterNum
            // 
            this.lblEnterNum.AutoSize = true;
            this.lblEnterNum.Location = new System.Drawing.Point(9, 66);
            this.lblEnterNum.Name = "lblEnterNum";
            this.lblEnterNum.Size = new System.Drawing.Size(54, 13);
            this.lblEnterNum.TabIndex = 0;
            this.lblEnterNum.Text = "Enter a #:";
            // 
            // txtEnterNum
            // 
            this.txtEnterNum.Location = new System.Drawing.Point(69, 59);
            this.txtEnterNum.Name = "txtEnterNum";
            this.txtEnterNum.Size = new System.Drawing.Size(151, 20);
            this.txtEnterNum.TabIndex = 1;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(69, 95);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(151, 50);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(69, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(151, 41);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click_1);
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(242, 16);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(275, 121);
            this.lstResults.TabIndex = 4;
            // 
            // Ch_4_Guessing_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 182);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtEnterNum);
            this.Controls.Add(this.lblEnterNum);
            this.Name = "Ch_4_Guessing_Game";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterNum;
        private System.Windows.Forms.TextBox txtEnterNum;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.ListBox lstResults;
    }
}

