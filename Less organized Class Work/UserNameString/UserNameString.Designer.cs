namespace UserNameString
{
    partial class Form1
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
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.UserNameR = new System.Windows.Forms.TextBox();
            this.CreateUserName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(31, 64);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(57, 13);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "FirstName:";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(31, 22);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(58, 13);
            this.LastName.TabIndex = 1;
            this.LastName.Text = "LastName:";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(67, 97);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(21, 13);
            this.Id.TabIndex = 2;
            this.Id.Text = "ID:";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(31, 179);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(63, 13);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "User Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(101, 57);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(105, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(101, 22);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(105, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(100, 94);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(105, 20);
            this.txtId.TabIndex = 6;
            // 
            // UserNameR
            // 
            this.UserNameR.Location = new System.Drawing.Point(100, 172);
            this.UserNameR.Name = "UserNameR";
            this.UserNameR.Size = new System.Drawing.Size(105, 20);
            this.UserNameR.TabIndex = 7;
            // 
            // CreateUserName
            // 
            this.CreateUserName.Location = new System.Drawing.Point(100, 130);
            this.CreateUserName.Name = "CreateUserName";
            this.CreateUserName.Size = new System.Drawing.Size(105, 24);
            this.CreateUserName.TabIndex = 8;
            this.CreateUserName.Text = "Create User Name";
            this.CreateUserName.UseVisualStyleBackColor = true;
            this.CreateUserName.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 218);
            this.Controls.Add(this.CreateUserName);
            this.Controls.Add(this.UserNameR);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Name = "Form1";
            this.Text = "UserNameStr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox UserNameR;
        private System.Windows.Forms.Button CreateUserName;
    }
}

