namespace Ch2_DataTypes
{
    partial class GraduationDate
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
            this.dtpGradTime = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.dtpGradDate = new System.Windows.Forms.DateTimePicker();
            this.Label1 = new System.Windows.Forms.Label();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnDisplayGradInfo = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpGradTime
            // 
            this.dtpGradTime.CustomFormat = "";
            this.dtpGradTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGradTime.Location = new System.Drawing.Point(127, 44);
            this.dtpGradTime.Name = "dtpGradTime";
            this.dtpGradTime.Size = new System.Drawing.Size(99, 20);
            this.dtpGradTime.TabIndex = 38;
            this.dtpGradTime.Value = new System.DateTime(2014, 1, 19, 14, 30, 0, 0);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.Location = new System.Drawing.Point(264, 74);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 32);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // dtpGradDate
            // 
            this.dtpGradDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGradDate.Location = new System.Drawing.Point(125, 12);
            this.dtpGradDate.Name = "dtpGradDate";
            this.dtpGradDate.Size = new System.Drawing.Size(152, 20);
            this.dtpGradDate.TabIndex = 36;
            this.dtpGradDate.Value = new System.DateTime(2017, 5, 12, 0, 0, 0, 0);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.Window;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label1.Location = new System.Drawing.Point(19, 18);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(97, 14);
            this.Label1.TabIndex = 33;
            this.Label1.Text = "Graduation Date:";
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.ItemHeight = 14;
            this.lstDisplay.Location = new System.Drawing.Point(12, 112);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(426, 256);
            this.lstDisplay.TabIndex = 35;
            // 
            // btnDisplayGradInfo
            // 
            this.btnDisplayGradInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDisplayGradInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDisplayGradInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayGradInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDisplayGradInfo.Location = new System.Drawing.Point(127, 74);
            this.btnDisplayGradInfo.Name = "btnDisplayGradInfo";
            this.btnDisplayGradInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDisplayGradInfo.Size = new System.Drawing.Size(113, 32);
            this.btnDisplayGradInfo.TabIndex = 32;
            this.btnDisplayGradInfo.Text = "Graduation Info";
            this.btnDisplayGradInfo.UseVisualStyleBackColor = false;

            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(19, 44);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(102, 24);
            this.Label2.TabIndex = 34;
            this.Label2.Text = "Graduation Time:";
            // 
            // GraduationDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 378);
            this.Controls.Add(this.dtpGradTime);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dtpGradDate);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.btnDisplayGradInfo);
            this.Controls.Add(this.Label2);
            this.Name = "GraduationDate";
            this.Text = "GraduationDate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpGradTime;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.DateTimePicker dtpGradDate;
        public System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ListBox lstDisplay;
        public System.Windows.Forms.Button btnDisplayGradInfo;
        public System.Windows.Forms.Label Label2;
    }
}