using SuperMart_Pro.Models;
using System;
using System.Windows.Forms;

namespace SuperMart_Pro.View.Branch
{
    public partial class DeleteBranchGUI : Form
    {
        public DeleteBranchGUI()
        {
            InitializeComponent();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            string searchId = SearchtextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchId))
            {
                MessageBox.Show("Please enter a Branch ID to search.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // TODO: load branch from controller/service by searchId and populate fields
            MessageBox.Show($"Search for branch '{searchId}' not yet implemented.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Delete button click event handler with confirmation dialog
        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BranchIDtextBox.Text))
            {
                MessageBox.Show("Please search and load a branch before deleting.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete branch '{BranchNametextBox.Text}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                // TODO: pass branchID to controller/service layer for deletion
                MessageBox.Show("Branch deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

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
            SearchtextBox.Clear();
            SearchtextBox.Focus();
        }
    }
}
