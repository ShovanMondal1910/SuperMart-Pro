using SuperMart_Pro.Controllers;
using SuperMart_Pro.IDGenarator;
using SuperMart_Pro.Models;
using SuperMart_Pro.Utils;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SuperMart_Pro.View.Branch
{
    public partial class BranchManagementGUI : Form
    {
        public BranchManagementGUI()
        {
            InitializeComponent();
            ApplyRoundedStyles();
        }

        private void BranchManagementGUI_Load(object sender, EventArgs e)
        {
            LoadBranchData();
            ClearFields();
        }

        private void ApplyRoundedStyles()
        {
            RoundedControlHelper.ApplyRoundedCorners(BranchIDtextBox, 10);
            RoundedControlHelper.ApplyRoundedCorners(BranchNametextBox, 10);
            RoundedControlHelper.ApplyRoundedCorners(BranchTypecomboBox, 10);
            RoundedControlHelper.ApplyRoundedCorners(BranchAddressrichTextBox, 10);
            RoundedControlHelper.ApplyRoundedCorners(BranchZiptextBox, 10);
            RoundedControlHelper.ApplyRoundedCorners(BranchPhonetextBox, 10);
            RoundedControlHelper.ApplyRoundedCorners(BranchEmailtextBox, 10);
            RoundedControlHelper.ApplyRoundedCorners(ManagerIDtextBox, 10);
            RoundedControlHelper.ApplyRoundedCorners(searchTextBox, 10);
            RoundedControlHelper.ApplyRoundedCorners(Updatebutton, 10);
            RoundedControlHelper.ApplyRoundedCorners(Deletebutton, 10);
            RoundedControlHelper.ApplyRoundedCorners(Clearbutton, 10);
            RoundedControlHelper.ApplyRoundedCorners(searchButton, 8);
            RoundedControlHelper.ApplyRoundedCorners(refreshButton, 8);
        }

        /// <summary>
        /// Loads branch records into DataGridView.
        /// </summary>
        public void LoadBranchData(string? keyword = null)
        {
            List<Models.Branch> branches = string.IsNullOrWhiteSpace(keyword)
                ? BranchController.GetAllBranches()
                : BranchController.SearchBranches(keyword);

            branchesDataGridView.DataSource = null;
            branchesDataGridView.DataSource = branches;

            SetColumnHeader("BranchID", "Branch ID");
            SetColumnHeader("BranchName", "Branch Name");
            SetColumnHeader("BranchType", "Type");
            SetColumnHeader("BranchAddress", "Address");
            SetColumnHeader("BranchZip", "Zip");
            SetColumnHeader("BranchPhone", "Phone");
            SetColumnHeader("BranchEmail", "Email");
            SetColumnHeader("IsActive", "Active");
            SetColumnHeader("ManagerID", "Manager ID");

            SetColumnVisible("CreatedBy", false);
            SetColumnVisible("CreatedAt", false);
            SetColumnVisible("UpdatedBy", false);
            SetColumnVisible("UpdatedAt", false);

            branchesDataGridView.ClearSelection();
        }

        private void SetColumnHeader(string colName, string headerText)
        {
            if (branchesDataGridView.Columns[colName] != null)
                branchesDataGridView.Columns[colName]!.HeaderText = headerText;
        }

        private void SetColumnVisible(string colName, bool visible)
        {
            if (branchesDataGridView.Columns[colName] != null)
                branchesDataGridView.Columns[colName]!.Visible = visible;
        }

        /// <summary>
        /// Automatically populates form input fields when a user selects a branch in the data table.
        /// </summary>
        private void branchesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (branchesDataGridView.SelectedRows.Count > 0)
            {
                var row = branchesDataGridView.SelectedRows[0];
                if (row.DataBoundItem is Models.Branch branch)
                {
                    BranchIDtextBox.Text = branch.BranchID;
                    BranchIDtextBox.ReadOnly = true;

                    BranchNametextBox.Text = branch.BranchName;
                    BranchTypecomboBox.SelectedItem = branch.BranchType;
                    BranchAddressrichTextBox.Text = branch.BranchAddress;
                    BranchZiptextBox.Text = branch.BranchZip;
                    BranchPhonetextBox.Text = branch.BranchPhone;
                    BranchEmailtextBox.Text = branch.BranchEmail;
                    ManagerIDtextBox.Text = branch.ManagerID;
                    IsActivecheckBox.Checked = branch.IsActive;

                    ClearErrorLabels();
                }
            }
            else
            {
                ClearInputsOnly();
            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BranchIDtextBox.Text))
            {
                MessageBox.Show("Please select a branch from the table to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs(isEditMode: true)) return;

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

            if (BranchController.UpdateBranch(branch, out string errorMessage))
            {
                MessageBox.Show("Branch updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBranchData();
                ClearFields();
            }
            else
            {
                MessageBox.Show($"Failed to update branch: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            string branchId = BranchIDtextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(branchId))
            {
                MessageBox.Show("Please select a branch from the table to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show($"Are you sure you want to delete Branch '{branchId}'?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                if (BranchController.DeleteBranch(branchId, out string errorMessage))
                {
                    MessageBox.Show("Branch deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBranchData();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show($"Failed to delete branch: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            LoadBranchData(searchTextBox.Text.Trim());
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadBranchData(searchTextBox.Text.Trim());
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
            LoadBranchData();
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                searchButton_Click(sender, e);
            }
        }

        private void ClearFields()
        {
            branchesDataGridView.ClearSelection();
            ClearInputsOnly();
        }

        private void ClearInputsOnly()
        {
            BranchIDtextBox.Clear();
            BranchIDtextBox.ReadOnly = true;
            BranchNametextBox.Clear();
            BranchTypecomboBox.SelectedIndex = -1;
            BranchAddressrichTextBox.Clear();
            BranchZiptextBox.Clear();
            BranchPhonetextBox.Clear();
            BranchEmailtextBox.Clear();
            ManagerIDtextBox.Clear();
            IsActivecheckBox.Checked = true;
            ClearErrorLabels();
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

        private bool ValidateInputs(bool isEditMode)
        {
            ClearErrorLabels();
            bool isValid = true;
            string currentID = BranchIDtextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(currentID))
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

            string address = BranchAddressrichTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(address))
            {
                BranchAddressErrorlabel.Text = "* Branch Address is required.";
                isValid = false;
            }
            else if (!isEditMode && BranchController.IsAddressExists(address))
            {
                BranchAddressErrorlabel.Text = "* Branch Address already exists.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(BranchZiptextBox.Text))
            {
                BranchZipErrorlabel.Text = "* Branch Zip is required.";
                isValid = false;
            }

            string phone = BranchPhonetextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(phone))
            {
                BranchPhoneErrorlabel.Text = "* Branch Phone is required.";
                isValid = false;
            }
            else if (!Regex.IsMatch(phone, @"^\+?[0-9\s\-]{7,15}$"))
            {
                BranchPhoneErrorlabel.Text = "* Invalid Branch Phone.";
                isValid = false;
            }
            else if (!isEditMode && BranchController.IsPhoneExists(phone))
            {
                BranchPhoneErrorlabel.Text = "* Branch Phone already exists.";
                isValid = false;
            }

            string email = BranchEmailtextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(email))
            {
                BranchEmailErrorlabel.Text = "* Branch Email is required.";
                isValid = false;
            }
            else if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                BranchEmailErrorlabel.Text = "* Invalid Branch Email.";
                isValid = false;
            }
            else if (!isEditMode && BranchController.IsEmailExists(email))
            {
                BranchEmailErrorlabel.Text = "* Branch Email already exists.";
                isValid = false;
            }

            string mgrID = ManagerIDtextBox.Text.Trim();
            if (!string.IsNullOrWhiteSpace(mgrID) && !isEditMode && BranchController.IsManagerIDExists(mgrID))
            {
                BranchManagerIDErrorlabel.Text = "* Manager ID already assigned.";
                isValid = false;
            }

            return isValid;
        }
    }
}
