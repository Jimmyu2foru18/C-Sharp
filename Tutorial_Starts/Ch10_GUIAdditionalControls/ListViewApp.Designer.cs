namespace Ch10_GUIAdditionalControls
{
    partial class ListViewApp
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
            this.lblNumOfTickets = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hsbNumOfTickets = new System.Windows.Forms.HScrollBar();
            this.lblAmtDue = new System.Windows.Forms.Label();
            this.btnComputePrice = new System.Windows.Forms.Button();
            this.lblcurrentCell = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAvgPrice = new System.Windows.Forms.Label();
            this.btnComputeAvg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumOfTickets
            // 
            this.lblNumOfTickets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumOfTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfTickets.Location = new System.Drawing.Point(255, 18);
            this.lblNumOfTickets.Name = "lblNumOfTickets";
            this.lblNumOfTickets.Size = new System.Drawing.Size(35, 26);
            this.lblNumOfTickets.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "# of Tickets:";
            // 
            // hsbNumOfTickets
            // 
            this.hsbNumOfTickets.LargeChange = 1;
            this.hsbNumOfTickets.Location = new System.Drawing.Point(101, 15);
            this.hsbNumOfTickets.Maximum = 10;
            this.hsbNumOfTickets.Name = "hsbNumOfTickets";
            this.hsbNumOfTickets.Size = new System.Drawing.Size(138, 29);
            this.hsbNumOfTickets.TabIndex = 48;
            this.hsbNumOfTickets.ValueChanged += new System.EventHandler(this.hsbNumOfTickets_ValueChanged);
            // 
            // lblAmtDue
            // 
            this.lblAmtDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmtDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmtDue.Location = new System.Drawing.Point(145, 213);
            this.lblAmtDue.Name = "lblAmtDue";
            this.lblAmtDue.Size = new System.Drawing.Size(64, 30);
            this.lblAmtDue.TabIndex = 53;
            // 
            // btnComputePrice
            // 
            this.btnComputePrice.BackColor = System.Drawing.SystemColors.Control;
            this.btnComputePrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnComputePrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputePrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnComputePrice.Location = new System.Drawing.Point(21, 210);
            this.btnComputePrice.Name = "btnComputePrice";
            this.btnComputePrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnComputePrice.Size = new System.Drawing.Size(118, 34);
            this.btnComputePrice.TabIndex = 52;
            this.btnComputePrice.Text = "Compute Price";
            this.btnComputePrice.UseVisualStyleBackColor = false;
            this.btnComputePrice.Click += new System.EventHandler(this.btnComputePrice_Click);
            // 
            // lblcurrentCell
            // 
            this.lblcurrentCell.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcurrentCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurrentCell.Location = new System.Drawing.Point(145, 254);
            this.lblcurrentCell.Name = "lblcurrentCell";
            this.lblcurrentCell.Size = new System.Drawing.Size(145, 33);
            this.lblcurrentCell.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 31);
            this.label2.TabIndex = 55;
            this.label2.Text = "current Cell:";
            // 
            // lblAvgPrice
            // 
            this.lblAvgPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAvgPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgPrice.Location = new System.Drawing.Point(425, 256);
            this.lblAvgPrice.Name = "lblAvgPrice";
            this.lblAvgPrice.Size = new System.Drawing.Size(62, 25);
            this.lblAvgPrice.TabIndex = 56;
            this.lblAvgPrice.Visible = false;
            // 
            // btnComputeAvg
            // 
            this.btnComputeAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputeAvg.Location = new System.Drawing.Point(307, 253);
            this.btnComputeAvg.Name = "btnComputeAvg";
            this.btnComputeAvg.Size = new System.Drawing.Size(108, 33);
            this.btnComputeAvg.TabIndex = 57;
            this.btnComputeAvg.Text = "Comptue Avg";
            this.btnComputeAvg.UseVisualStyleBackColor = true;
            this.btnComputeAvg.Visible = false;
            // 
            // ListViewApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 299);
            this.Controls.Add(this.btnComputeAvg);
            this.Controls.Add(this.lblAvgPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblcurrentCell);
            this.Controls.Add(this.lblAmtDue);
            this.Controls.Add(this.btnComputePrice);
            this.Controls.Add(this.lblNumOfTickets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hsbNumOfTickets);
            this.Name = "ListViewApp";
            this.Text = "ListView Example";
            this.Load += new System.EventHandler(this.ListView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumOfTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar hsbNumOfTickets;
        private System.Windows.Forms.Label lblAmtDue;
        public System.Windows.Forms.Button btnComputePrice;
        private System.Windows.Forms.Label lblcurrentCell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAvgPrice;
        private System.Windows.Forms.Button btnComputeAvg;
    }
}

