namespace Ch7_Arrays
{
    partial class TheaterTicketsWithArray
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
            this.lblNumOfTickets = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hsbNumOfTickets = new System.Windows.Forms.HScrollBar();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbxSection = new System.Windows.Forms.GroupBox();
            this.rdbDefault = new System.Windows.Forms.RadioButton();
            this.rdbSec4 = new System.Windows.Forms.RadioButton();
            this.rdbSec3 = new System.Windows.Forms.RadioButton();
            this.rdbSec2 = new System.Windows.Forms.RadioButton();
            this.rdbSec1 = new System.Windows.Forms.RadioButton();
            this.chkMember = new System.Windows.Forms.CheckBox();
            this.cboShow = new System.Windows.Forms.ComboBox();
            this.gbxSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 14;
            this.lstDisplay.Location = new System.Drawing.Point(12, 134);
            this.lstDisplay.MultiColumn = true;
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDisplay.Size = new System.Drawing.Size(281, 74);
            this.lstDisplay.TabIndex = 48;
            // 
            // lblNumOfTickets
            // 
            this.lblNumOfTickets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumOfTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfTickets.Location = new System.Drawing.Point(249, 16);
            this.lblNumOfTickets.Name = "lblNumOfTickets";
            this.lblNumOfTickets.Size = new System.Drawing.Size(35, 26);
            this.lblNumOfTickets.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "# of Tickets:";
            // 
            // hsbNumOfTickets
            // 
            this.hsbNumOfTickets.LargeChange = 1;
            this.hsbNumOfTickets.Location = new System.Drawing.Point(95, 13);
            this.hsbNumOfTickets.Maximum = 10;
            this.hsbNumOfTickets.Name = "hsbNumOfTickets";
            this.hsbNumOfTickets.Size = new System.Drawing.Size(138, 29);
            this.hsbNumOfTickets.TabIndex = 45;
            this.hsbNumOfTickets.ValueChanged += new System.EventHandler(this.hsbNumOfTickets_ValueChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(208, 104);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 28);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbxSection
            // 
            this.gbxSection.BackColor = System.Drawing.SystemColors.Control;
            this.gbxSection.Controls.Add(this.rdbDefault);
            this.gbxSection.Controls.Add(this.rdbSec4);
            this.gbxSection.Controls.Add(this.rdbSec3);
            this.gbxSection.Controls.Add(this.rdbSec2);
            this.gbxSection.Controls.Add(this.rdbSec1);
            this.gbxSection.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSection.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gbxSection.Location = new System.Drawing.Point(12, 48);
            this.gbxSection.Name = "gbxSection";
            this.gbxSection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbxSection.Size = new System.Drawing.Size(221, 50);
            this.gbxSection.TabIndex = 41;
            this.gbxSection.TabStop = false;
            this.gbxSection.Text = "Section#";
            // 
            // rdbDefault
            // 
            this.rdbDefault.BackColor = System.Drawing.SystemColors.Control;
            this.rdbDefault.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdbDefault.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDefault.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rdbDefault.Location = new System.Drawing.Point(184, 16);
            this.rdbDefault.Name = "rdbDefault";
            this.rdbDefault.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdbDefault.Size = new System.Drawing.Size(37, 17);
            this.rdbDefault.TabIndex = 7;
            this.rdbDefault.Text = "0";
            this.rdbDefault.UseVisualStyleBackColor = false;
            this.rdbDefault.Visible = false;
            // 
            // rdbSec4
            // 
            this.rdbSec4.BackColor = System.Drawing.SystemColors.Control;
            this.rdbSec4.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdbSec4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSec4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rdbSec4.Location = new System.Drawing.Point(144, 16);
            this.rdbSec4.Name = "rdbSec4";
            this.rdbSec4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdbSec4.Size = new System.Drawing.Size(41, 17);
            this.rdbSec4.TabIndex = 6;
            this.rdbSec4.Text = "4";
            this.rdbSec4.UseVisualStyleBackColor = false;
            // 
            // rdbSec3
            // 
            this.rdbSec3.BackColor = System.Drawing.SystemColors.Control;
            this.rdbSec3.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdbSec3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSec3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rdbSec3.Location = new System.Drawing.Point(104, 16);
            this.rdbSec3.Name = "rdbSec3";
            this.rdbSec3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdbSec3.Size = new System.Drawing.Size(33, 17);
            this.rdbSec3.TabIndex = 5;
            this.rdbSec3.Text = "3";
            this.rdbSec3.UseVisualStyleBackColor = false;
            // 
            // rdbSec2
            // 
            this.rdbSec2.BackColor = System.Drawing.SystemColors.Control;
            this.rdbSec2.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdbSec2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSec2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rdbSec2.Location = new System.Drawing.Point(56, 16);
            this.rdbSec2.Name = "rdbSec2";
            this.rdbSec2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdbSec2.Size = new System.Drawing.Size(33, 17);
            this.rdbSec2.TabIndex = 4;
            this.rdbSec2.Text = "2";
            this.rdbSec2.UseVisualStyleBackColor = false;
            // 
            // rdbSec1
            // 
            this.rdbSec1.BackColor = System.Drawing.SystemColors.Control;
            this.rdbSec1.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdbSec1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSec1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rdbSec1.Location = new System.Drawing.Point(8, 16);
            this.rdbSec1.Name = "rdbSec1";
            this.rdbSec1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdbSec1.Size = new System.Drawing.Size(33, 17);
            this.rdbSec1.TabIndex = 3;
            this.rdbSec1.Text = "1";
            this.rdbSec1.UseVisualStyleBackColor = false;
            // 
            // chkMember
            // 
            this.chkMember.BackColor = System.Drawing.SystemColors.Control;
            this.chkMember.Checked = true;
            this.chkMember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMember.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkMember.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMember.ForeColor = System.Drawing.SystemColors.WindowText;
            this.chkMember.Location = new System.Drawing.Point(249, 59);
            this.chkMember.Name = "chkMember";
            this.chkMember.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkMember.Size = new System.Drawing.Size(85, 22);
            this.chkMember.TabIndex = 40;
            this.chkMember.Text = "Member?";
            this.chkMember.UseVisualStyleBackColor = false;
            // 
            // cboShow
            // 
            this.cboShow.BackColor = System.Drawing.SystemColors.Control;
            this.cboShow.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboShow.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboShow.Location = new System.Drawing.Point(12, 104);
            this.cboShow.Name = "cboShow";
            this.cboShow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboShow.Size = new System.Drawing.Size(185, 24);
            this.cboShow.Sorted = true;
            this.cboShow.TabIndex = 39;
            this.cboShow.SelectedIndexChanged += new System.EventHandler(this.cboShow_SelectedIndexChanged);
            // 
            // TheaterTicketsWithArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 232);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.lblNumOfTickets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hsbNumOfTickets);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbxSection);
            this.Controls.Add(this.chkMember);
            this.Controls.Add(this.cboShow);
            this.Name = "TheaterTicketsWithArray";
            this.Text = "TheaterTicketsWithArray";
            this.Load += new System.EventHandler(this.TheaterTicketsWithArray_Load);
            this.gbxSection.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Label lblNumOfTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar hsbNumOfTickets;
        internal System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.GroupBox gbxSection;
        public System.Windows.Forms.RadioButton rdbDefault;
        public System.Windows.Forms.RadioButton rdbSec4;
        public System.Windows.Forms.RadioButton rdbSec3;
        public System.Windows.Forms.RadioButton rdbSec2;
        public System.Windows.Forms.RadioButton rdbSec1;
        public System.Windows.Forms.CheckBox chkMember;
        public System.Windows.Forms.ComboBox cboShow;
    }
}