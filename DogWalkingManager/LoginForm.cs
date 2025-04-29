using DogWalkingManager.Services;
using System;
using System.Windows.Forms;

namespace DogWalkingManager.Forms
{
    /// <summary>
    /// Login form for user authentication.
    /// </summary>
    public partial class LoginForm : Form
    {
        private readonly AuthenticationService _authenticationService;

        public LoginForm()
        {
            InitializeComponent();
            _authenticationService = new AuthenticationService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_authenticationService.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim()))
            {
                Hide();
                var mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
