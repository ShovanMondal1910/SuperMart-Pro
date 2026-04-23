using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SuperMart_Pro.View.Auth;

namespace SuperMart_Pro.View.Auth
{
    public partial class LoginGUI : Form
    {
        public string username = "Shovan";
        public string password = "12345";
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            UserNameErrorlabel.Text = "";
            PasswordErrorlabel.Text = "";

            if (UserNametextBox.Text == "" && PasswordtextBox.Text == "")
            {
                UserNameErrorlabel.Text = "Username is required";
                PasswordErrorlabel.Text = "Password is required";
            }
            else if (UserNametextBox.Text == "")
            {
                UserNameErrorlabel.Text = "Username is required";
            }
            else if (PasswordtextBox.Text == "")
            {
                PasswordErrorlabel.Text = "Password is required";
            }
            else if (UserNametextBox.Text != username || PasswordtextBox.Text != password)
            {
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // You can add code here to open the main application window after successful login
                Close();
            }
        }
        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ForgetPasswordlabel_Click(object sender, EventArgs e)
        {
            ForgetPasswordGUI forgetPasswordGUI = new ForgetPasswordGUI();
            this.Hide();
            forgetPasswordGUI.ShowDialog();
            this.Show();
        }
    }
}
