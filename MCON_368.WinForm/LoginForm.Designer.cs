namespace MCON_368.WinForm
{
    partial class LoginForm
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
            userNameInput = new TextBox();
            passwordInput = new TextBox();
            userNameLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            cancelButton = new Button();
            welcomeLoginLabel = new Label();
            SuspendLayout();
            // 
            // userNameInput
            // 
            userNameInput.Location = new Point(48, 183);
            userNameInput.Name = "userNameInput";
            userNameInput.PlaceholderText = "Username";
            userNameInput.Size = new Size(337, 27);
            userNameInput.TabIndex = 1;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(48, 237);
            passwordInput.Name = "passwordInput";
            passwordInput.PlaceholderText = "Password";
            passwordInput.Size = new Size(337, 27);
            passwordInput.TabIndex = 2;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(48, 160);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(80, 20);
            userNameLabel.TabIndex = 3;
            userNameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(48, 214);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(76, 20);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(255, 128, 0);
            loginButton.Location = new Point(48, 294);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(338, 29);
            loginButton.TabIndex = 5;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(255, 128, 0);
            cancelButton.Location = new Point(48, 329);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(338, 29);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // welcomeLoginLabel
            // 
            welcomeLoginLabel.AutoSize = true;
            welcomeLoginLabel.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLoginLabel.Location = new Point(48, 51);
            welcomeLoginLabel.Name = "welcomeLoginLabel";
            welcomeLoginLabel.Size = new Size(308, 36);
            welcomeLoginLabel.TabIndex = 7;
            welcomeLoginLabel.Text = "Log In To Your Account";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 400);
            Controls.Add(welcomeLoginLabel);
            Controls.Add(cancelButton);
            Controls.Add(loginButton);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Controls.Add(passwordInput);
            Controls.Add(userNameInput);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox userNameInput;
        private TextBox passwordInput;
        private Label userNameLabel;
        private Label passwordLabel;
        private Button loginButton;
        private Button cancelButton;
        private Label welcomeLoginLabel;
    }
}