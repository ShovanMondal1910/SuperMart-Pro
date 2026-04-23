using SuperMart_Pro.Models;
using System;
using System.Windows.Forms;

namespace SuperMart_Pro.View.Admin
{
    public partial class AddAdminGUI : Form
    {
        public AddAdminGUI()
        {
            InitializeComponent();
        }

        private void BrowsePhotobutton_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
                PhotopictureBox.Image = System.Drawing.Image.FromFile(dlg.FileName);
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var admin = new Models.Admin(
                userID: UserIDtextBox.Text.Trim(),
                fullName: FullNametextBox.Text.Trim(),
                dateOfBirth: DateOfBirthdatePicker.Value,
                gender: MaleradioButton.Checked ? "Male" : "Female",
                photo: Array.Empty<byte>(),
                phoneNumber: PhoneNumbertextBox.Text.Trim(),
                email: EmailtextBox.Text.Trim(),
                address: AddressrichTextBox.Text.Trim(),
                username: UsernametextBox.Text.Trim(),
                passwordHash: PasswordtextBox.Text.Trim(),
                isActive: IsActivecheckBox.Checked,
                branchID: BranchIDtextBox.Text.Trim(),
                securityQuestion1: FirstSecurityQuestioncomboBox.SelectedItem?.ToString() ?? string.Empty,
                securityAnswer1: FirstSecurityAnswertextBox.Text.Trim(),
                securityQuestion2: SecondSecurityQuestioncomboBox.SelectedItem?.ToString() ?? string.Empty,
                securityAnswer2: SecondSecurityAnswertextBox.Text.Trim(),
                adminID: AdminIDtextBox.Text.Trim(),
                adminType: (AdminType)(AdminTypecomboBox.SelectedIndex + 1),
                lastLogin: null,
                lastLogout: null,
                canManageUsers: CanManageUserscheckBox.Checked,
                canManageBranches: CanManageBranchescheckBox.Checked,
                canViewReports: CanViewReportscheckBox.Checked,
                createdAt: DateTime.Now,
                createdBy: Environment.UserName,
                updatedAt: DateTime.Now,
                updatedBy: Environment.UserName,
                deletedAt: null,
                deletedBy: string.Empty
            );

            // TODO: pass admin to controller/service layer
            MessageBox.Show("Admin saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidateInputs()
        {
            // --- Left column (top to bottom) ---

            // User ID
            if (string.IsNullOrWhiteSpace(UserIDtextBox.Text))
            {
                MessageBox.Show("User ID is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserIDtextBox.Focus();
                return false;
            }

            // Full Name
            if (string.IsNullOrWhiteSpace(FullNametextBox.Text))
            {
                MessageBox.Show("Full Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FullNametextBox.Focus();
                return false;
            }

            // Date of Birth – must be in the past
            if (DateOfBirthdatePicker.Value.Date >= DateTime.Today)
            {
                MessageBox.Show("Date of Birth must be in the past.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DateOfBirthdatePicker.Focus();
                return false;
            }

            // Gender
            if (!MaleradioButton.Checked && !FemaleradioButton.Checked)
            {
                MessageBox.Show("Please select a Gender.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MaleradioButton.Focus();
                return false;
            }

            // Phone Number
            if (string.IsNullOrWhiteSpace(PhoneNumbertextBox.Text))
            {
                MessageBox.Show("Phone Number is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PhoneNumbertextBox.Focus();
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(PhoneNumbertextBox.Text.Trim(), @"^\+?[0-9\s\-]{7,15}$"))
            {
                MessageBox.Show("Phone Number is not valid.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PhoneNumbertextBox.Focus();
                return false;
            }

            // Email
            if (string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                MessageBox.Show("Email is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmailtextBox.Focus();
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(EmailtextBox.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email address is not valid.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmailtextBox.Focus();
                return false;
            }

            // Address
            if (string.IsNullOrWhiteSpace(AddressrichTextBox.Text))
            {
                MessageBox.Show("Address is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddressrichTextBox.Focus();
                return false;
            }

            // --- Right column (top to bottom) ---

            // Username
            if (string.IsNullOrWhiteSpace(UsernametextBox.Text))
            {
                MessageBox.Show("Username is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UsernametextBox.Focus();
                return false;
            }

            // Password
            if (string.IsNullOrWhiteSpace(PasswordtextBox.Text))
            {
                MessageBox.Show("Password is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PasswordtextBox.Focus();
                return false;
            }
            if (PasswordtextBox.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PasswordtextBox.Focus();
                return false;
            }

            // Branch ID
            if (string.IsNullOrWhiteSpace(BranchIDtextBox.Text))
            {
                MessageBox.Show("Branch ID is required. Use the Search button to select a branch.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BranchIDtextBox.Focus();
                return false;
            }

            // First Security Question
            if (FirstSecurityQuestioncomboBox.SelectedIndex == -1 || string.IsNullOrWhiteSpace(FirstSecurityQuestioncomboBox.SelectedItem?.ToString()))
            {
                MessageBox.Show("Please select a First Security Question.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FirstSecurityQuestioncomboBox.Focus();
                return false;
            }

            // First Security Answer
            if (string.IsNullOrWhiteSpace(FirstSecurityAnswertextBox.Text))
            {
                MessageBox.Show("First Security Answer is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FirstSecurityAnswertextBox.Focus();
                return false;
            }

            // Second Security Question
            if (SecondSecurityQuestioncomboBox.SelectedIndex == -1 || string.IsNullOrWhiteSpace(SecondSecurityQuestioncomboBox.SelectedItem?.ToString()))
            {
                MessageBox.Show("Please select a Second Security Question.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SecondSecurityQuestioncomboBox.Focus();
                return false;
            }

            // Second Security Answer
            if (string.IsNullOrWhiteSpace(SecondSecurityAnswertextBox.Text))
            {
                MessageBox.Show("Second Security Answer is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SecondSecurityAnswertextBox.Focus();
                return false;
            }

            // Both security questions must be different
            if (FirstSecurityQuestioncomboBox.SelectedItem?.ToString() == SecondSecurityQuestioncomboBox.SelectedItem?.ToString())
            {
                MessageBox.Show("First and Second Security Questions must be different.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SecondSecurityQuestioncomboBox.Focus();
                return false;
            }

            // Admin ID
            if (string.IsNullOrWhiteSpace(AdminIDtextBox.Text))
            {
                MessageBox.Show("Admin ID is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AdminIDtextBox.Focus();
                return false;
            }

            // Admin Type
            if (AdminTypecomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Admin Type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AdminTypecomboBox.Focus();
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            AdminIDtextBox.Clear();
            UserIDtextBox.Clear();
            FullNametextBox.Clear();
            DateOfBirthdatePicker.Value = DateTime.Today;
            MaleradioButton.Checked = false;
            FemaleradioButton.Checked = false;
            PhotopictureBox.Image = null;
            PhoneNumbertextBox.Clear();
            EmailtextBox.Clear();
            AddressrichTextBox.Clear();
            UsernametextBox.Clear();
            PasswordtextBox.Clear();
            AdminTypecomboBox.SelectedIndex = -1;
            IsActivecheckBox.Checked = false;
            BranchIDtextBox.Clear();
            BranchNametextBox.Clear();
            CanManageUserscheckBox.Checked = false;
            CanManageBranchescheckBox.Checked = false;
            CanViewReportscheckBox.Checked = false;
            AdminIDtextBox.Focus();
        }

        private void BranchIDsearchbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
