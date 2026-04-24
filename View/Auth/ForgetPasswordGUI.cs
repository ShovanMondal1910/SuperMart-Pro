using SuperMart_Pro.Models;
using System;
using System.Windows.Forms;

namespace SuperMart_Pro.View.Auth
{
    public partial class ForgetPasswordGUI : Form
    {
        // The user found after username lookup — set after successful Validate
        private User? _verifiedUser = null;

        public ForgetPasswordGUI()
        {
            InitializeComponent();
        }

        // ─── Form Load ────────────────────────────────────────────────────────

        private void ForgetPasswordGUI_Load(object sender, EventArgs e)
        {
            SetNewPasswordSectionEnabled(false);
            NewPasswordtextBox.PasswordChar        = '*';
            ConfirmNewPasswordtextBox.PasswordChar = '*';
        }

        // ─── Step 1: Validate security questions ─────────────────────────────

        private void Validatebutton_Click_1(object sender, EventArgs e)
        {
            _verifiedUser = null;
            SetNewPasswordSectionEnabled(false);

            // Username
            string username = UserNametextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter your Username.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserNametextBox.Focus();
                return;
            }

            // Security questions selected
            if (FirstSecurityQuestioncomboBox.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(FirstSecurityQuestioncomboBox.SelectedItem?.ToString()))
            {
                MessageBox.Show("Please select the First Security Question.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FirstSecurityQuestioncomboBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(FirstSecurityAnswertextBox.Text))
            {
                MessageBox.Show("Please enter the First Security Answer.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FirstSecurityAnswertextBox.Focus();
                return;
            }

            if (SecondSecurityQuestioncomboBox.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(SecondSecurityQuestioncomboBox.SelectedItem?.ToString()))
            {
                MessageBox.Show("Please select the Second Security Question.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SecondSecurityQuestioncomboBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(SecondSecurityAnswertextBox.Text))
            {
                MessageBox.Show("Please enter the Second Security Answer.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SecondSecurityAnswertextBox.Focus();
                return;
            }

            // TODO: replace LoginGUI.FindUser() with UserService.FindByUsername(username)
            User? user = LoginGUI.FindUser(username);

            if (user == null)
            {
                MessageBox.Show("No account found with that username.", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserNametextBox.Focus();
                return;
            }

            // Verify security questions and answers (case-insensitive)
            string q1 = FirstSecurityQuestioncomboBox.SelectedItem!.ToString()!;
            string a1 = FirstSecurityAnswertextBox.Text.Trim();
            string q2 = SecondSecurityQuestioncomboBox.SelectedItem!.ToString()!;
            string a2 = SecondSecurityAnswertextBox.Text.Trim();

            bool q1Match = string.Equals(q1, user.SecurityQuestion1, StringComparison.OrdinalIgnoreCase)
                        && string.Equals(a1, user.SecurityAnswer1,   StringComparison.OrdinalIgnoreCase);

            bool q2Match = string.Equals(q2, user.SecurityQuestion2, StringComparison.OrdinalIgnoreCase)
                        && string.Equals(a2, user.SecurityAnswer2,   StringComparison.OrdinalIgnoreCase);

            if (!q1Match || !q2Match)
            {
                MessageBox.Show("Security questions or answers do not match. Please try again.",
                    "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FirstSecurityAnswertextBox.Clear();
                SecondSecurityAnswertextBox.Clear();
                FirstSecurityAnswertextBox.Focus();
                return;
            }

            _verifiedUser = user;
            SetNewPasswordSectionEnabled(true);
            MessageBox.Show("Identity verified. Please enter your new password.",
                "Verified", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NewPasswordtextBox.Focus();
        }

        // ─── Step 2: Change password ──────────────────────────────────────────

        private void ChangePasswordbutton_Click(object sender, EventArgs e)
        {
            if (_verifiedUser == null)
            {
                MessageBox.Show("Please validate your identity first.", "Not Verified",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newPassword     = NewPasswordtextBox.Text;
            string confirmPassword = ConfirmNewPasswordtextBox.Text;

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("New Password is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewPasswordtextBox.Focus();
                return;
            }

            if (newPassword.Length < 8)
            {
                MessageBox.Show("New Password must be at least 8 characters.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewPasswordtextBox.Focus();
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New Password and Confirm Password do not match.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ConfirmNewPasswordtextBox.Clear();
                ConfirmNewPasswordtextBox.Focus();
                return;
            }

            if (newPassword == _verifiedUser.PasswordHash)
            {
                MessageBox.Show("New Password must be different from the current password.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewPasswordtextBox.Clear();
                ConfirmNewPasswordtextBox.Clear();
                NewPasswordtextBox.Focus();
                return;
            }

            // TODO: replace with UserService.UpdatePassword(_verifiedUser.UserID, newPassword)
            _verifiedUser.PasswordHash = newPassword;

            MessageBox.Show("Password changed successfully. Please log in with your new password.",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        // ─── Cancel ───────────────────────────────────────────────────────────

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ─── Helper ───────────────────────────────────────────────────────────

        private void SetNewPasswordSectionEnabled(bool enabled)
        {
            NewPasswordtextBox.Enabled        = enabled;
            ConfirmNewPasswordtextBox.Enabled = enabled;
            ChangePasswordbutton.Enabled      = enabled;

            if (!enabled)
            {
                NewPasswordtextBox.Clear();
                ConfirmNewPasswordtextBox.Clear();
            }
        }
    }
}
