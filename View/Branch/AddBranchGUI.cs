using SuperMart_Pro.Models;
using System;
using System.Windows.Forms;

namespace SuperMart_Pro.View.Branch
{
    public partial class AddBranchGUI : Form
    {
        public AddBranchGUI()
        {
            InitializeComponent();
            GenerateAndSetBranchID();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (!ValidateInputs())
            {
                return;
            }

            var branch = new Models.Branch(
                branchID: BranchIDtextBox.Text.Trim(),
                branchName: BranchNametextBox.Text.Trim(),
                branchType: BranchTypecomboBox.SelectedItem?.ToString() ?? string.Empty,
                branchAddress: BranchAddressrichTextBox.Text.Trim(),
                branchZip: BranchZiptextBox.Text.Trim(),
                branchPhone: BranchPhonetextBox.Text.Trim(),
                branchEmail: BranchEmailtextBox.Text.Trim(),
                isActive: IsActivecheckBox.Checked,
                managerID: ManagerIDtextBox.Text.Trim()
            );

            if (Controllers.BranchController.AddBranch(branch, out string errorMessage))
            {
                MessageBox.Show("Branch saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show($"Failed to save branch: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clears all input fields
        private void Clearbutton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Closes the form without saving
        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Validates user inputs and sets error labels accordingly
        private bool ValidateInputs()
        {
            ClearErrorLabels();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(BranchIDtextBox.Text))
            {
                BranchIDErrorlabel.Text = "* Branch ID is required.";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(BranchNametextBox.Text))
            {
                BranchNameErrorlabel.Text = "* Branch Name is required.";
                isValid = false;
            }
            if (BranchTypecomboBox.SelectedIndex == -1)
            {
                BranchTypeErrorlabel.Text = "* Branch Type is required.";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(BranchAddressrichTextBox.Text))
            {
                BranchAddressErrorlabel.Text = "* Branch Address is required.";
                isValid = false;
            }
            else if (Controllers.BranchController.IsAddressExists(BranchAddressrichTextBox.Text.Trim()))
            {
                BranchAddressErrorlabel.Text = "* Branch Address already exists.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(BranchZiptextBox.Text))
            {
                BranchZipErrorlabel.Text = "* Branch Zip is required.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(BranchPhonetextBox.Text))
            {
                BranchPhoneErrorlabel.Text = "* Branch Phone is required.";
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(BranchPhonetextBox.Text.Trim(), @"^\+?[0-9\s\-]{7,15}$"))
            {
                BranchPhoneErrorlabel.Text = "* Invalid Branch Phone.";
                isValid = false;
            }
            else if (Controllers.BranchController.IsPhoneExists(BranchPhonetextBox.Text.Trim()))
            {
                BranchPhoneErrorlabel.Text = "* Branch Phone already exists.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(BranchEmailtextBox.Text))
            {
                BranchEmailErrorlabel.Text = "* Branch Email is required.";
                isValid = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(BranchEmailtextBox.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                BranchEmailErrorlabel.Text = "* Invalid Branch Email.";
                isValid = false;
            }
            else if (Controllers.BranchController.IsEmailExists(BranchEmailtextBox.Text.Trim()))
            {
                BranchEmailErrorlabel.Text = "* Branch Email already exists.";
                isValid = false;
            }

            if (!string.IsNullOrWhiteSpace(ManagerIDtextBox.Text) && Controllers.BranchController.IsManagerIDExists(ManagerIDtextBox.Text.Trim()))
            {
                BranchManagerIDErrorlabel.Text = "* Manager ID already assigned.";
                isValid = false;
            }

            return isValid;
        }

        // Clears all input fields and resets error labels
        private void ClearFields()
        {
            ClearErrorLabels();
            GenerateAndSetBranchID();
            BranchNametextBox.Clear();
            BranchTypecomboBox.SelectedIndex = -1;
            BranchAddressrichTextBox.Clear();
            BranchZiptextBox.Clear();
            BranchPhonetextBox.Clear();
            BranchEmailtextBox.Clear();
            ManagerIDtextBox.Clear();
            IsActivecheckBox.Checked = false;
            BranchNametextBox.Focus();
        }

        private void ClearErrorLabels()
        {
            BranchIDErrorlabel.Text = string.Empty;
            BranchNameErrorlabel.Text = string.Empty;
            BranchTypeErrorlabel.Text = string.Empty;
            BranchAddressErrorlabel.Text = string.Empty;
            BranchZipErrorlabel.Text = string.Empty;
            BranchPhoneErrorlabel.Text = string.Empty;
            BranchEmailErrorlabel.Text = string.Empty;
            BranchManagerIDErrorlabel.Text = string.Empty;
        }

        private void GenerateAndSetBranchID()
        {
            BranchIDtextBox.Text = SuperMart_Pro.IDGenarator.BranchIDGenarator.GenerateBranchID();
        }

    }
}
