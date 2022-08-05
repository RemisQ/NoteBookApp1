namespace NoteBookApp.WinForms
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.guestButton = new System.Windows.Forms.Button();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.guestLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Yellow;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.loginButton.Location = new System.Drawing.Point(81, 211);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(82, 31);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.SystemColors.Window;
            this.usernameBox.Location = new System.Drawing.Point(81, 102);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.PlaceholderText = "Enter username";
            this.usernameBox.Size = new System.Drawing.Size(181, 23);
            this.usernameBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(81, 158);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PlaceholderText = "Enter password";
            this.passwordBox.Size = new System.Drawing.Size(181, 23);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LogoLabel.ForeColor = System.Drawing.Color.Yellow;
            this.LogoLabel.Location = new System.Drawing.Point(81, 43);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(198, 32);
            this.LogoLabel.TabIndex = 4;
            this.LogoLabel.Text = "@NoteBookApp";
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signUpButton.ForeColor = System.Drawing.Color.Red;
            this.signUpButton.Location = new System.Drawing.Point(445, 124);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(122, 23);
            this.signUpButton.TabIndex = 5;
            this.signUpButton.Text = "Sign Up!";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // guestButton
            // 
            this.guestButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guestButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guestButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guestButton.Location = new System.Drawing.Point(445, 172);
            this.guestButton.Name = "guestButton";
            this.guestButton.Size = new System.Drawing.Size(122, 23);
            this.guestButton.TabIndex = 6;
            this.guestButton.Text = "Visit as a guest";
            this.guestButton.UseVisualStyleBackColor = false;
            this.guestButton.Click += new System.EventHandler(this.guestButton_Click);
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signUpLabel.ForeColor = System.Drawing.Color.Purple;
            this.signUpLabel.Location = new System.Drawing.Point(425, 102);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(176, 19);
            this.signUpLabel.TabIndex = 7;
            this.signUpLabel.Text = "Don\'t have an account yet?";
            // 
            // guestLabel
            // 
            this.guestLabel.AutoSize = true;
            this.guestLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guestLabel.ForeColor = System.Drawing.Color.Purple;
            this.guestLabel.Location = new System.Drawing.Point(491, 150);
            this.guestLabel.Name = "guestLabel";
            this.guestLabel.Size = new System.Drawing.Size(22, 19);
            this.guestLabel.TabIndex = 0;
            this.guestLabel.Text = "or";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(658, 295);
            this.Controls.Add(this.guestLabel);
            this.Controls.Add(this.signUpLabel);
            this.Controls.Add(this.guestButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.LogoLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.loginButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button loginButton;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private Label LogoLabel;
        private Button signUpButton;
        private Button guestButton;
        private Label signUpLabel;
        private Label guestLabel;
    }
}