namespace TestApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Username setup
            usernameLabel.Text = "Username";
            usernameInput.TabIndex = 0;
            usernameInput.Focus();
            var username = usernameInput.Text.ToLower();
            // Password setup
            passwordLabel.Text = "Password";
            passwordInput.TabIndex = 1;
            passwordInput.PasswordChar = '*';
            var password = passwordInput.Text;
            // Login button
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";

        }
    }
}
