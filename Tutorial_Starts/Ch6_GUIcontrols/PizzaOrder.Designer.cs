namespace Ch5_GUIcontrols
{
    partial class PizzaOrder
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
            this.grbSize = new System.Windows.Forms.GroupBox();
            this.rdbDefault = new System.Windows.Forms.RadioButton();
            this.rdbLarge = new System.Windows.Forms.RadioButton();
            this.rdbMedium = new System.Windows.Forms.RadioButton();
            this.rdbSmall = new System.Windows.Forms.RadioButton();
            this.lstToppings = new System.Windows.Forms.ListBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.grbSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSize
            // 
            this.grbSize.Controls.Add(this.rdbDefault);
            this.grbSize.Controls.Add(this.rdbLarge);
            this.grbSize.Controls.Add(this.rdbMedium);
            this.grbSize.Controls.Add(this.rdbSmall);
            this.grbSize.Location = new System.Drawing.Point(17, 14);
            this.grbSize.Name = "grbSize";
            this.grbSize.Size = new System.Drawing.Size(242, 43);
            this.grbSize.TabIndex = 0;
            this.grbSize.TabStop = false;
            this.grbSize.Text = "Size";
            // 
            // rdbDefault
            // 
            this.rdbDefault.AutoSize = true;
            this.rdbDefault.Location = new System.Drawing.Point(186, 19);
            this.rdbDefault.Name = "rdbDefault";
            this.rdbDefault.Size = new System.Drawing.Size(59, 17);
            this.rdbDefault.TabIndex = 3;
            this.rdbDefault.TabStop = true;
            this.rdbDefault.Text = "Default";
            this.rdbDefault.UseVisualStyleBackColor = true;
            this.rdbDefault.Visible = false;
            // 
            // rdbLarge
            // 
            this.rdbLarge.AutoSize = true;
            this.rdbLarge.Location = new System.Drawing.Point(133, 16);
            this.rdbLarge.Name = "rdbLarge";
            this.rdbLarge.Size = new System.Drawing.Size(52, 17);
            this.rdbLarge.TabIndex = 2;
            this.rdbLarge.TabStop = true;
            this.rdbLarge.Text = "Large";
            this.rdbLarge.UseVisualStyleBackColor = true;
            // 
            // rdbMedium
            // 
            this.rdbMedium.AutoSize = true;
            this.rdbMedium.Location = new System.Drawing.Point(65, 16);
            this.rdbMedium.Name = "rdbMedium";
            this.rdbMedium.Size = new System.Drawing.Size(62, 17);
            this.rdbMedium.TabIndex = 1;
            this.rdbMedium.TabStop = true;
            this.rdbMedium.Text = "Medium";
            this.rdbMedium.UseVisualStyleBackColor = true;
            // 
            // rdbSmall
            // 
            this.rdbSmall.AutoSize = true;
            this.rdbSmall.Location = new System.Drawing.Point(9, 16);
            this.rdbSmall.Name = "rdbSmall";
            this.rdbSmall.Size = new System.Drawing.Size(50, 17);
            this.rdbSmall.TabIndex = 0;
            this.rdbSmall.TabStop = true;
            this.rdbSmall.Text = "Small";
            this.rdbSmall.UseVisualStyleBackColor = true;
            // 
            // lstToppings
            // 
            this.lstToppings.FormattingEnabled = true;
            this.lstToppings.Location = new System.Drawing.Point(17, 63);
            this.lstToppings.Name = "lstToppings";
            this.lstToppings.Size = new System.Drawing.Size(150, 95);
            this.lstToppings.TabIndex = 1;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(193, 65);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(109, 25);
            this.btnCompute.TabIndex = 2;
            this.btnCompute.Text = "Compute Price";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(317, 67);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(63, 22);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstDisplay
            // 
            this.lstDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 14;
            this.lstDisplay.Location = new System.Drawing.Point(193, 96);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(185, 88);
            this.lstDisplay.TabIndex = 4;
            // 
            // PizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 198);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.lstToppings);
            this.Controls.Add(this.grbSize);
            this.Name = "PizzaOrder";
            this.Text = "PizzaOrder";
            this.Load += new System.EventHandler(this.PizzaOrder_Load);
            this.grbSize.ResumeLayout(false);
            this.grbSize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSize;
        private System.Windows.Forms.RadioButton rdbDefault;
        private System.Windows.Forms.RadioButton rdbLarge;
        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.RadioButton rdbSmall;
        private System.Windows.Forms.ListBox lstToppings;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstDisplay;
    }
}