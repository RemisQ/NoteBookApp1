namespace NoteBookApp.WinForms
{
    partial class CreateAccountForm
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
            this.createAccountLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.lastnameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.AutoSize = true;
            this.createAccountLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createAccountLabel.ForeColor = System.Drawing.Color.Yellow;
            this.createAccountLabel.Location = new System.Drawing.Point(112, 23);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(189, 32);
            this.createAccountLabel.TabIndex = 0;
            this.createAccountLabel.Text = "Create Account";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(112, 94);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(112, 150);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(58, 15);
            this.lastnameLabel.TabIndex = 2;
            this.lastnameLabel.Text = "Lastname";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(112, 209);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(60, 15);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(112, 264);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 15);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // createAccountButton
            // 
            this.createAccountButton.BackColor = System.Drawing.Color.Yellow;
            this.createAccountButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createAccountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.createAccountButton.Location = new System.Drawing.Point(186, 327);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(157, 31);
            this.createAccountButton.TabIndex = 5;
            this.createAccountButton.Text = "Create account";
            this.createAccountButton.UseVisualStyleBackColor = false;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(186, 91);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(157, 23);
            this.nameBox.TabIndex = 6;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(186, 261);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(157, 23);
            this.passwordBox.TabIndex = 7;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(186, 206);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(157, 23);
            this.usernameBox.TabIndex = 8;
            // 
            // lastnameBox
            // 
            this.lastnameBox.Location = new System.Drawing.Point(186, 147);
            this.lastnameBox.Name = "lastnameBox";
            this.lastnameBox.Size = new System.Drawing.Size(157, 23);
            this.lastnameBox.TabIndex = 9;
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.lastnameBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.createAccountLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CreateAccountForm";
            this.Text = "CreateAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label createAccountLabel;
        private Label nameLabel;
        private Label lastnameLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button createAccountButton;
        private TextBox nameBox;
        private TextBox passwordBox;
        private TextBox usernameBox;
        private TextBox lastnameBox;
    }
}