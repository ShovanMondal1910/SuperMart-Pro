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
                adminID: AdminIDtextBox.Text.Trim(),
                adminType: (AdminType)(AdminTypecomboBox.SelectedIndex + 1),
                userID: UserIDtextBox.Text.Trim(),
                fullName: FullNametextBox.Text.Trim(),
                dateOfBirth: DateOfBirthdatePicker.Value,
                gender: GendercomboBox.SelectedItem?.ToString() ?? string.Empty,
                photo: Array.Empty<byte>(),
                phoneNumber: PhoneNumbertextBox.Text.Trim(),
                email: EmailtextBox.Text.Trim(),
                address: AddresstextBox.Text.Trim(),
                username: UsernametextBox.Text.Trim(),
                passwordHash: PasswordtextBox.Text.Trim(),
                securityQuestion1: FirstSecurityQuestioncomboBox.SelectedItem?.ToString() ?? string.Empty,
                securityAnswer1: FirstSecurityAnswertextBox.Text.Trim(),
                securityQuestion2: SecondSecurityQuestioncomboBox.SelectedItem?.ToString() ?? string.Empty,
                securityAnswer2: SecondSecurityAnswertextBox.Text.Trim(),
                isActive: IsActivecheckBox.Checked,
                branchID: BranchIDtextBox.Text.Trim(),
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
            if (string.IsNullOrWhiteSpace(AdminIDtextBox.Text))
            { 
                MessageBox.Show("Admin ID is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); AdminIDtextBox.Focus(); 
                return false; 
            }
            if (string.IsNullOrWhiteSpace(UserIDtextBox.Text))
            { 
                MessageBox.Show("User ID is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); UserIDtextBox.Focus(); 
                return false;
            }
            if (string.IsNullOrWhiteSpace(FullNametextBox.Text))
            {   
                MessageBox.Show("Full Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); FullNametextBox.Focus(); 
                return false; 
            }
            if (GendercomboBox.SelectedIndex == -1)
            { 
                MessageBox.Show("Please select a Gender.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); GendercomboBox.Focus(); 
                return false; 
            }
            if (AdminTypecomboBox.SelectedIndex == -1)
            { 
                MessageBox.Show("Please select an Admin Type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); AdminTypecomboBox.Focus(); 
                return false; 
            }
            if (string.IsNullOrWhiteSpace(UsernametextBox.Text))
            { 
                MessageBox.Show("Username is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); UsernametextBox.Focus(); 
                return false; 
            }
            if (string.IsNullOrWhiteSpace(PasswordtextBox.Text))
            {
                MessageBox.Show("Password is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); PasswordtextBox.Focus(); 
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
            GendercomboBox.SelectedIndex = -1;
            PhotopictureBox.Image = null;
            PhoneNumbertextBox.Clear();
            EmailtextBox.Clear();
            AddresstextBox.Clear();
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
    }
}
