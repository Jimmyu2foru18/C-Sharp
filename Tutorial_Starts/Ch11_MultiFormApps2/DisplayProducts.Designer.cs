namespace Ch11_MultiFormApps2
{
    partial class DisplayProducts
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
            this.components = new System.ComponentModel.Container();
            this.btnDisplayProducts = new System.Windows.Forms.Button();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.DisplayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cnuBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.cnuForeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPriceLimit = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.displayColorDialog = new System.Windows.Forms.ColorDialog();
            this.DisplayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDisplayProducts
            // 
            this.btnDisplayProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayProducts.Location = new System.Drawing.Point(115, 46);
            this.btnDisplayProducts.Name = "btnDisplayProducts";
            this.btnDisplayProducts.Size = new System.Drawing.Size(118, 32);
            this.btnDisplayProducts.TabIndex = 0;
            this.btnDisplayProducts.Text = "Display Products";
            this.btnDisplayProducts.UseVisualStyleBackColor = true;
            this.btnDisplayProducts.Click += new System.EventHandler(this.btnDisplayProducts_Click);
            // 
            // lstDisplay
            // 
            this.lstDisplay.ContextMenuStrip = this.DisplayContextMenu;
            this.lstDisplay.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 16;
            this.lstDisplay.Location = new System.Drawing.Point(12, 78);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(221, 68);
            this.lstDisplay.TabIndex = 1;
            // 
            // DisplayContextMenu
            // 
            this.DisplayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cnuBackColor,
            this.cnuForeColor});
            this.DisplayContextMenu.Name = "DisplayContextMenu";
            this.DisplayContextMenu.Size = new System.Drawing.Size(170, 70);
            // 
            // cnuBackColor
            // 
            this.cnuBackColor.Name = "cnuBackColor";
            this.cnuBackColor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.cnuBackColor.Size = new System.Drawing.Size(169, 22);
            this.cnuBackColor.Text = "BackColor";
            // 
            // cnuForeColor
            // 
            this.cnuForeColor.Name = "cnuForeColor";
            this.cnuForeColor.Size = new System.Drawing.Size(169, 22);
            this.cnuForeColor.Text = "ForeColor";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Price Limit:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtPriceLimit
            // 
            this.txtPriceLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceLimit.Location = new System.Drawing.Point(13, 50);
            this.txtPriceLimit.Name = "txtPriceLimit";
            this.txtPriceLimit.Size = new System.Drawing.Size(96, 22);
            this.txtPriceLimit.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(57, 152);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 25);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // DisplayProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 184);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtPriceLimit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.btnDisplayProducts);
            this.Name = "DisplayProducts";
            this.Text = "Display Products";
            this.Load += new System.EventHandler(this.DisplayPrices_Load);
            this.DisplayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayProducts;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPriceLimit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ContextMenuStrip DisplayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem cnuBackColor;
        private System.Windows.Forms.ToolStripMenuItem cnuForeColor;
        private System.Windows.Forms.ColorDialog displayColorDialog;
    }
}