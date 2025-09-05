namespace TestApp
{
    partial class Login
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
            usernameInput = new TextBox();
            usernameLabel = new Label();
            loginButton = new Button();
            passwordInput = new TextBox();
            passwordLabel = new Label();
            SuspendLayout();
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(521, 111);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(208, 27);
            usernameInput.TabIndex = 0;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(521, 88);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(50, 20);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "label1";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(635, 220);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 29);
            loginButton.TabIndex = 2;
            loginButton.Text = "button1";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(521, 175);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(208, 27);
            passwordInput.TabIndex = 3;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(521, 152);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(50, 20);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(passwordLabel);
            Controls.Add(passwordInput);
            Controls.Add(loginButton);
            Controls.Add(usernameLabel);
            Controls.Add(usernameInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameInput;
        private Label usernameLabel;
        private Button loginButton;
        private TextBox passwordInput;
        private Label passwordLabel;
    }
}
