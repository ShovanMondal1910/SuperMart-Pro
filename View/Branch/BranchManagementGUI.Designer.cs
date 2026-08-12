namespace SuperMart_Pro.View.Branch
{
    partial class BranchManagementGUI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            mainSplitContainer = new SplitContainer();
            leftPanel = new Panel();
            titleLabel = new Label();
            BranchIDlabel = new Label();
            BranchIDtextBox = new TextBox();
            BranchIDErrorlabel = new Label();
            BranchNamelabel = new Label();
            BranchNametextBox = new TextBox();
            BranchNameErrorlabel = new Label();
            BranchTypelabel = new Label();
            BranchTypecomboBox = new ComboBox();
            BranchTypeErrorlabel = new Label();
            BranchAddresslabel = new Label();
            BranchAddressrichTextBox = new RichTextBox();
            BranchAddressErrorlabel = new Label();
            BranchZiplabel = new Label();
            BranchZiptextBox = new TextBox();
            BranchZipErrorlabel = new Label();
            BranchPhonelabel = new Label();
            BranchPhonetextBox = new TextBox();
            BranchPhoneErrorlabel = new Label();
            BranchEmaillabel = new Label();
            BranchEmailtextBox = new TextBox();
            BranchEmailErrorlabel = new Label();
            ManagerIDlabel = new Label();
            ManagerIDtextBox = new TextBox();
            BranchManagerIDErrorlabel = new Label();
            IsActivecheckBox = new CheckBox();
            Updatebutton = new Button();
            Deletebutton = new Button();
            Clearbutton = new Button();
            rightPanel = new Panel();
            branchesDataGridView = new DataGridView();
            topSearchPanel = new Panel();
            searchLabel = new Label();
            searchTextBox = new TextBox();
            searchButton = new Button();
            refreshButton = new Button();
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).BeginInit();
            mainSplitContainer.Panel1.SuspendLayout();
            mainSplitContainer.Panel2.SuspendLayout();
            mainSplitContainer.SuspendLayout();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)branchesDataGridView).BeginInit();
            topSearchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainSplitContainer
            // 
            mainSplitContainer.Dock = DockStyle.Fill;
            mainSplitContainer.FixedPanel = FixedPanel.Panel1;
            mainSplitContainer.Location = new Point(0, 0);
            mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            mainSplitContainer.Panel1.Controls.Add(leftPanel);
            mainSplitContainer.Panel1MinSize = 420;
            // 
            // mainSplitContainer.Panel2
            // 
            mainSplitContainer.Panel2.Controls.Add(rightPanel);
            mainSplitContainer.Panel2MinSize = 400;
            mainSplitContainer.Size = new Size(1250, 750);
            mainSplitContainer.SplitterDistance = 522;
            mainSplitContainer.TabIndex = 0;
            // 
            // leftPanel
            // 
            leftPanel.AutoScroll = true;
            leftPanel.Controls.Add(titleLabel);
            leftPanel.Controls.Add(BranchIDlabel);
            leftPanel.Controls.Add(BranchIDtextBox);
            leftPanel.Controls.Add(BranchIDErrorlabel);
            leftPanel.Controls.Add(BranchNamelabel);
            leftPanel.Controls.Add(BranchNametextBox);
            leftPanel.Controls.Add(BranchNameErrorlabel);
            leftPanel.Controls.Add(BranchTypelabel);
            leftPanel.Controls.Add(BranchTypecomboBox);
            leftPanel.Controls.Add(BranchTypeErrorlabel);
            leftPanel.Controls.Add(BranchAddresslabel);
            leftPanel.Controls.Add(BranchAddressrichTextBox);
            leftPanel.Controls.Add(BranchAddressErrorlabel);
            leftPanel.Controls.Add(BranchZiplabel);
            leftPanel.Controls.Add(BranchZiptextBox);
            leftPanel.Controls.Add(BranchZipErrorlabel);
            leftPanel.Controls.Add(BranchPhonelabel);
            leftPanel.Controls.Add(BranchPhonetextBox);
            leftPanel.Controls.Add(BranchPhoneErrorlabel);
            leftPanel.Controls.Add(BranchEmaillabel);
            leftPanel.Controls.Add(BranchEmailtextBox);
            leftPanel.Controls.Add(BranchEmailErrorlabel);
            leftPanel.Controls.Add(ManagerIDlabel);
            leftPanel.Controls.Add(ManagerIDtextBox);
            leftPanel.Controls.Add(BranchManagerIDErrorlabel);
            leftPanel.Controls.Add(IsActivecheckBox);
            leftPanel.Controls.Add(Updatebutton);
            leftPanel.Controls.Add(Deletebutton);
            leftPanel.Controls.Add(Clearbutton);
            leftPanel.Dock = DockStyle.Fill;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Padding = new Padding(15);
            leftPanel.Size = new Size(522, 750);
            leftPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.DarkSlateGray;
            titleLabel.Location = new Point(170, 55);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(228, 26);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Branch Details Form";
            // 
            // BranchIDlabel
            // 
            BranchIDlabel.AutoSize = true;
            BranchIDlabel.Location = new Point(59, 114);
            BranchIDlabel.Name = "BranchIDlabel";
            BranchIDlabel.Size = new Size(96, 21);
            BranchIDlabel.TabIndex = 1;
            BranchIDlabel.Text = "Branch ID :";
            // 
            // BranchIDtextBox
            // 
            BranchIDtextBox.Location = new Point(188, 111);
            BranchIDtextBox.Name = "BranchIDtextBox";
            BranchIDtextBox.Size = new Size(295, 29);
            BranchIDtextBox.TabIndex = 2;
            // 
            // BranchIDErrorlabel
            // 
            BranchIDErrorlabel.AutoSize = true;
            BranchIDErrorlabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BranchIDErrorlabel.ForeColor = Color.Red;
            BranchIDErrorlabel.Location = new Point(135, 83);
            BranchIDErrorlabel.Name = "BranchIDErrorlabel";
            BranchIDErrorlabel.Size = new Size(0, 15);
            BranchIDErrorlabel.TabIndex = 3;
            // 
            // BranchNamelabel
            // 
            BranchNamelabel.AutoSize = true;
            BranchNamelabel.Location = new Point(35, 169);
            BranchNamelabel.Name = "BranchNamelabel";
            BranchNamelabel.Size = new Size(120, 21);
            BranchNamelabel.TabIndex = 4;
            BranchNamelabel.Text = "Branch Name :";
            // 
            // BranchNametextBox
            // 
            BranchNametextBox.Location = new Point(188, 163);
            BranchNametextBox.Name = "BranchNametextBox";
            BranchNametextBox.Size = new Size(295, 29);
            BranchNametextBox.TabIndex = 5;
            // 
            // BranchNameErrorlabel
            // 
            BranchNameErrorlabel.AutoSize = true;
            BranchNameErrorlabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BranchNameErrorlabel.ForeColor = Color.Red;
            BranchNameErrorlabel.Location = new Point(135, 135);
            BranchNameErrorlabel.Name = "BranchNameErrorlabel";
            BranchNameErrorlabel.Size = new Size(0, 15);
            BranchNameErrorlabel.TabIndex = 6;
            // 
            // BranchTypelabel
            // 
            BranchTypelabel.AutoSize = true;
            BranchTypelabel.Location = new Point(40, 218);
            BranchTypelabel.Name = "BranchTypelabel";
            BranchTypelabel.Size = new Size(115, 21);
            BranchTypelabel.TabIndex = 7;
            BranchTypelabel.Text = "Branch Type :";
            // 
            // BranchTypecomboBox
            // 
            BranchTypecomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            BranchTypecomboBox.FormattingEnabled = true;
            BranchTypecomboBox.Items.AddRange(new object[] { "Main", "Sub", "Warehouse", "Outlet" });
            BranchTypecomboBox.Location = new Point(188, 215);
            BranchTypecomboBox.Name = "BranchTypecomboBox";
            BranchTypecomboBox.Size = new Size(295, 29);
            BranchTypecomboBox.TabIndex = 8;
            // 
            // BranchTypeErrorlabel
            // 
            BranchTypeErrorlabel.AutoSize = true;
            BranchTypeErrorlabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BranchTypeErrorlabel.ForeColor = Color.Red;
            BranchTypeErrorlabel.Location = new Point(135, 187);
            BranchTypeErrorlabel.Name = "BranchTypeErrorlabel";
            BranchTypeErrorlabel.Size = new Size(0, 15);
            BranchTypeErrorlabel.TabIndex = 9;
            // 
            // BranchAddresslabel
            // 
            BranchAddresslabel.AutoSize = true;
            BranchAddresslabel.Location = new Point(16, 290);
            BranchAddresslabel.Name = "BranchAddresslabel";
            BranchAddresslabel.Size = new Size(139, 21);
            BranchAddresslabel.TabIndex = 10;
            BranchAddresslabel.Text = "Branch Address :";
            // 
            // BranchAddressrichTextBox
            // 
            BranchAddressrichTextBox.Location = new Point(188, 267);
            BranchAddressrichTextBox.Name = "BranchAddressrichTextBox";
            BranchAddressrichTextBox.Size = new Size(295, 65);
            BranchAddressrichTextBox.TabIndex = 11;
            BranchAddressrichTextBox.Text = "";
            // 
            // BranchAddressErrorlabel
            // 
            BranchAddressErrorlabel.AutoSize = true;
            BranchAddressErrorlabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BranchAddressErrorlabel.ForeColor = Color.Red;
            BranchAddressErrorlabel.Location = new Point(135, 275);
            BranchAddressErrorlabel.Name = "BranchAddressErrorlabel";
            BranchAddressErrorlabel.Size = new Size(0, 15);
            BranchAddressErrorlabel.TabIndex = 12;
            // 
            // BranchZiplabel
            // 
            BranchZiplabel.AutoSize = true;
            BranchZiplabel.Location = new Point(53, 360);
            BranchZiplabel.Name = "BranchZiplabel";
            BranchZiplabel.Size = new Size(102, 21);
            BranchZiplabel.TabIndex = 13;
            BranchZiplabel.Text = "Branch Zip :";
            // 
            // BranchZiptextBox
            // 
            BranchZiptextBox.Location = new Point(188, 355);
            BranchZiptextBox.Name = "BranchZiptextBox";
            BranchZiptextBox.Size = new Size(295, 29);
            BranchZiptextBox.TabIndex = 14;
            // 
            // BranchZipErrorlabel
            // 
            BranchZipErrorlabel.AutoSize = true;
            BranchZipErrorlabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BranchZipErrorlabel.ForeColor = Color.Red;
            BranchZipErrorlabel.Location = new Point(135, 327);
            BranchZipErrorlabel.Name = "BranchZipErrorlabel";
            BranchZipErrorlabel.Size = new Size(0, 15);
            BranchZipErrorlabel.TabIndex = 15;
            // 
            // BranchPhonelabel
            // 
            BranchPhonelabel.AutoSize = true;
            BranchPhonelabel.Location = new Point(31, 411);
            BranchPhonelabel.Name = "BranchPhonelabel";
            BranchPhonelabel.Size = new Size(124, 21);
            BranchPhonelabel.TabIndex = 16;
            BranchPhonelabel.Text = "Branch Phone :";
            // 
            // BranchPhonetextBox
            // 
            BranchPhonetextBox.Location = new Point(188, 407);
            BranchPhonetextBox.Name = "BranchPhonetextBox";
            BranchPhonetextBox.Size = new Size(295, 29);
            BranchPhonetextBox.TabIndex = 17;
            // 
            // BranchPhoneErrorlabel
            // 
            BranchPhoneErrorlabel.AutoSize = true;
            BranchPhoneErrorlabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BranchPhoneErrorlabel.ForeColor = Color.Red;
            BranchPhoneErrorlabel.Location = new Point(135, 379);
            BranchPhoneErrorlabel.Name = "BranchPhoneErrorlabel";
            BranchPhoneErrorlabel.Size = new Size(0, 15);
            BranchPhoneErrorlabel.TabIndex = 18;
            // 
            // BranchEmaillabel
            // 
            BranchEmaillabel.AutoSize = true;
            BranchEmaillabel.Location = new Point(37, 464);
            BranchEmaillabel.Name = "BranchEmaillabel";
            BranchEmaillabel.Size = new Size(118, 21);
            BranchEmaillabel.TabIndex = 19;
            BranchEmaillabel.Text = "Branch Email :";
            // 
            // BranchEmailtextBox
            // 
            BranchEmailtextBox.Location = new Point(188, 459);
            BranchEmailtextBox.Name = "BranchEmailtextBox";
            BranchEmailtextBox.Size = new Size(295, 29);
            BranchEmailtextBox.TabIndex = 20;
            // 
            // BranchEmailErrorlabel
            // 
            BranchEmailErrorlabel.AutoSize = true;
            BranchEmailErrorlabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BranchEmailErrorlabel.ForeColor = Color.Red;
            BranchEmailErrorlabel.Location = new Point(135, 431);
            BranchEmailErrorlabel.Name = "BranchEmailErrorlabel";
            BranchEmailErrorlabel.Size = new Size(0, 15);
            BranchEmailErrorlabel.TabIndex = 21;
            // 
            // ManagerIDlabel
            // 
            ManagerIDlabel.AutoSize = true;
            ManagerIDlabel.Location = new Point(48, 519);
            ManagerIDlabel.Name = "ManagerIDlabel";
            ManagerIDlabel.Size = new Size(107, 21);
            ManagerIDlabel.TabIndex = 22;
            ManagerIDlabel.Text = "Manager ID :";
            // 
            // ManagerIDtextBox
            // 
            ManagerIDtextBox.Location = new Point(188, 511);
            ManagerIDtextBox.Name = "ManagerIDtextBox";
            ManagerIDtextBox.Size = new Size(295, 29);
            ManagerIDtextBox.TabIndex = 23;
            // 
            // BranchManagerIDErrorlabel
            // 
            BranchManagerIDErrorlabel.AutoSize = true;
            BranchManagerIDErrorlabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BranchManagerIDErrorlabel.ForeColor = Color.Red;
            BranchManagerIDErrorlabel.Location = new Point(135, 483);
            BranchManagerIDErrorlabel.Name = "BranchManagerIDErrorlabel";
            BranchManagerIDErrorlabel.Size = new Size(0, 15);
            BranchManagerIDErrorlabel.TabIndex = 24;
            // 
            // IsActivecheckBox
            // 
            IsActivecheckBox.AutoSize = true;
            IsActivecheckBox.Checked = true;
            IsActivecheckBox.CheckState = CheckState.Checked;
            IsActivecheckBox.Location = new Point(188, 567);
            IsActivecheckBox.Name = "IsActivecheckBox";
            IsActivecheckBox.Size = new Size(95, 25);
            IsActivecheckBox.TabIndex = 25;
            IsActivecheckBox.Text = "Is Active";
            IsActivecheckBox.UseVisualStyleBackColor = true;
            // 
            // Updatebutton
            // 
            Updatebutton.BackColor = Color.RoyalBlue;
            Updatebutton.FlatStyle = FlatStyle.Flat;
            Updatebutton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            Updatebutton.ForeColor = Color.White;
            Updatebutton.Location = new Point(48, 655);
            Updatebutton.Name = "Updatebutton";
            Updatebutton.Size = new Size(120, 42);
            Updatebutton.TabIndex = 26;
            Updatebutton.Text = "Update";
            Updatebutton.UseVisualStyleBackColor = false;
            Updatebutton.Click += Updatebutton_Click;
            // 
            // Deletebutton
            // 
            Deletebutton.BackColor = Color.Crimson;
            Deletebutton.FlatStyle = FlatStyle.Flat;
            Deletebutton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            Deletebutton.ForeColor = Color.White;
            Deletebutton.Location = new Point(188, 655);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(120, 42);
            Deletebutton.TabIndex = 27;
            Deletebutton.Text = "Delete";
            Deletebutton.UseVisualStyleBackColor = false;
            Deletebutton.Click += Deletebutton_Click;
            // 
            // Clearbutton
            // 
            Clearbutton.BackColor = Color.DarkGoldenrod;
            Clearbutton.FlatStyle = FlatStyle.Flat;
            Clearbutton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            Clearbutton.ForeColor = Color.White;
            Clearbutton.Location = new Point(328, 655);
            Clearbutton.Name = "Clearbutton";
            Clearbutton.Size = new Size(120, 42);
            Clearbutton.TabIndex = 28;
            Clearbutton.Text = "Clear";
            Clearbutton.UseVisualStyleBackColor = false;
            Clearbutton.Click += Clearbutton_Click;
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(branchesDataGridView);
            rightPanel.Controls.Add(topSearchPanel);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(0, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Padding = new Padding(10);
            rightPanel.Size = new Size(724, 750);
            rightPanel.TabIndex = 0;
            // 
            // branchesDataGridView
            // 
            branchesDataGridView.AllowUserToAddRows = false;
            branchesDataGridView.AllowUserToDeleteRows = false;
            branchesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            branchesDataGridView.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            branchesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            branchesDataGridView.ColumnHeadersHeight = 35;
            branchesDataGridView.Dock = DockStyle.Fill;
            branchesDataGridView.EnableHeadersVisualStyles = false;
            branchesDataGridView.Location = new Point(10, 55);
            branchesDataGridView.MultiSelect = false;
            branchesDataGridView.Name = "branchesDataGridView";
            branchesDataGridView.ReadOnly = true;
            branchesDataGridView.RowHeadersWidth = 30;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F);
            branchesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            branchesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            branchesDataGridView.Size = new Size(704, 685);
            branchesDataGridView.TabIndex = 1;
            branchesDataGridView.SelectionChanged += branchesDataGridView_SelectionChanged;
            // 
            // topSearchPanel
            // 
            topSearchPanel.Controls.Add(searchLabel);
            topSearchPanel.Controls.Add(searchTextBox);
            topSearchPanel.Controls.Add(searchButton);
            topSearchPanel.Controls.Add(refreshButton);
            topSearchPanel.Dock = DockStyle.Top;
            topSearchPanel.Location = new Point(10, 10);
            topSearchPanel.Name = "topSearchPanel";
            topSearchPanel.Size = new Size(704, 45);
            topSearchPanel.TabIndex = 0;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            searchLabel.Location = new Point(5, 10);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(77, 22);
            searchLabel.TabIndex = 0;
            searchLabel.Text = "Search :";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(88, 7);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(320, 29);
            searchTextBox.TabIndex = 1;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            searchTextBox.KeyDown += searchTextBox_KeyDown;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.DarkCyan;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(420, 5);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(100, 33);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.DimGray;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(530, 5);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(100, 33);
            refreshButton.TabIndex = 3;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // BranchManagementGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 750);
            Controls.Add(mainSplitContainer);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "BranchManagementGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuperMart Pro - Branch Management";
            Load += BranchManagementGUI_Load;
            mainSplitContainer.Panel1.ResumeLayout(false);
            mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainSplitContainer).EndInit();
            mainSplitContainer.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)branchesDataGridView).EndInit();
            topSearchPanel.ResumeLayout(false);
            topSearchPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label BranchIDlabel;
        private System.Windows.Forms.TextBox BranchIDtextBox;
        private System.Windows.Forms.Label BranchIDErrorlabel;
        private System.Windows.Forms.Label BranchNamelabel;
        private System.Windows.Forms.TextBox BranchNametextBox;
        private System.Windows.Forms.Label BranchNameErrorlabel;
        private System.Windows.Forms.Label BranchTypelabel;
        private System.Windows.Forms.ComboBox BranchTypecomboBox;
        private System.Windows.Forms.Label BranchTypeErrorlabel;
        private System.Windows.Forms.Label BranchAddresslabel;
        private System.Windows.Forms.RichTextBox BranchAddressrichTextBox;
        private System.Windows.Forms.Label BranchAddressErrorlabel;
        private System.Windows.Forms.Label BranchZiplabel;
        private System.Windows.Forms.TextBox BranchZiptextBox;
        private System.Windows.Forms.Label BranchZipErrorlabel;
        private System.Windows.Forms.Label BranchPhonelabel;
        private System.Windows.Forms.TextBox BranchPhonetextBox;
        private System.Windows.Forms.Label BranchPhoneErrorlabel;
        private System.Windows.Forms.Label BranchEmaillabel;
        private System.Windows.Forms.TextBox BranchEmailtextBox;
        private System.Windows.Forms.Label BranchEmailErrorlabel;
        private System.Windows.Forms.Label ManagerIDlabel;
        private System.Windows.Forms.TextBox ManagerIDtextBox;
        private System.Windows.Forms.Label BranchManagerIDErrorlabel;
        private System.Windows.Forms.CheckBox IsActivecheckBox;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel topSearchPanel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridView branchesDataGridView;
    }
}