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
                branchAddress: BranchAddresstextBox.Text.Trim(),
                branchZip: BranchZiptextBox.Text.Trim(),
                branchPhone: BranchPhonetextBox.Text.Trim(),
                branchEmail: BranchEmailtextBox.Text.Trim(),
                isActive: IsActivecheckBox.Checked,
                managerID: ManagerIDtextBox.Text.Trim()
            );

            // TODO: pass branch to controller
            MessageBox.Show("Branch saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
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

        // Validates user inputs and shows appropriate messages
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(BranchIDtextBox.Text))
            {
                MessageBox.Show("Branch ID is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BranchIDtextBox.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(BranchNametextBox.Text))
            {
                MessageBox.Show("Branch Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BranchNametextBox.Focus(); return false;
            }
            if (BranchTypecomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Branch Type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BranchTypecomboBox.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(BranchPhonetextBox.Text))
            {
                MessageBox.Show("Branch Phone is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BranchPhonetextBox.Focus(); return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(BranchPhonetextBox.Text.Trim(), @"^\+?[0-9\s\-]{7,15}$"))
            {
                MessageBox.Show("Branch Phone is not valid.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BranchPhonetextBox.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(BranchEmailtextBox.Text))
            {
                MessageBox.Show("Branch Email is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BranchEmailtextBox.Focus(); return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(BranchEmailtextBox.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Branch Email is not valid.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BranchEmailtextBox.Focus(); return false;
            }
            if (string.IsNullOrWhiteSpace(BranchAddresstextBox.Text))
            {
                MessageBox.Show("Branch Address is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BranchAddresstextBox.Focus(); return false;
            }
            return true;
        }

        // Clears all input fields and resets the form to its initial state
        private void ClearFields()
        {
            BranchIDtextBox.Clear();
            BranchNametextBox.Clear();
            BranchTypecomboBox.SelectedIndex = -1;
            BranchAddresstextBox.Clear();
            BranchZiptextBox.Clear();
            BranchPhonetextBox.Clear();
            BranchEmailtextBox.Clear();
            ManagerIDtextBox.Clear();
            IsActivecheckBox.Checked = false;
            BranchIDtextBox.Focus();
        }

    }
}
