namespace SuperMart_Pro.View.Cashier
{
    partial class UpdateCashierGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Headerpanel = new Panel();
            SearchgroupBox = new GroupBox();
            UserSearchbutton = new Button();
            SearchUserTextBox = new TextBox();
            AddressrichTextBox = new RichTextBox();
            FemaleradioButton = new RadioButton();
            MaleradioButton = new RadioButton();
            Addresslabel = new Label();
            EmailtextBox = new TextBox();
            Emaillabel = new Label();
            PhoneNumbertextBox = new TextBox();
            PhoneNumberlabel = new Label();
            BrowsePhotobutton = new Button();
            PhotopictureBox = new PictureBox();
            Photolabel = new Label();
            Genderlabel = new Label();
            DateOfBirthdatePicker = new DateTimePicker();
            DateOfBirthlabel = new Label();
            FullNametextBox = new TextBox();
            FullNamelabel = new Label();
            UserIDtextBox = new TextBox();
            UserIDlabel = new Label();
            BranchIDsearchbutton = new Button();
            BranchNametextBox = new TextBox();
            BranchNamelabel = new Label();
            BranchIDtextBox = new TextBox();
            BranchIDlabel = new Label();
            IsActivecheckBox = new CheckBox();
            PasswordtextBox = new TextBox();
            Passwordlabel = new Label();
            UsernametextBox = new TextBox();
            Usernamelabel = new Label();
            CanManageStockcheckBox = new CheckBox();
            CanProcessReturnscheckBox = new CheckBox();
            CanProcessSalescheckBox = new CheckBox();
            CashierTypecomboBox = new ComboBox();
            CashierTypelabel = new Label();
            CashierIDtextBox = new TextBox();
            CashierIDlabel = new Label();
            Cancelbutton = new Button();
            Clearbutton = new Button();
            Savebutton = new Button();
            SearchgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PhotopictureBox).BeginInit();
            SuspendLayout();
            // 
            // Headerpanel
            // 
            Headerpanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Headerpanel.BackColor = Color.Tomato;
            Headerpanel.Location = new Point(2, 0);
            Headerpanel.Name = "Headerpanel";
            Headerpanel.Size = new Size(1231, 96);
            Headerpanel.TabIndex = 50;
            // 
            // SearchgroupBox
            // 
            SearchgroupBox.Anchor = AnchorStyles.None;
            SearchgroupBox.Controls.Add(UserSearchbutton);
            SearchgroupBox.Controls.Add(SearchUserTextBox);
            SearchgroupBox.Location = new Point(351, 114);
            SearchgroupBox.Name = "SearchgroupBox";
            SearchgroupBox.Size = new Size(545, 86);
            SearchgroupBox.TabIndex = 115;
            SearchgroupBox.TabStop = false;
            SearchgroupBox.Text = "Search by UserID/Phone number/UserName";
            // 
            // UserSearchbutton
            // 
            UserSearchbutton.Anchor = AnchorStyles.None;
            UserSearchbutton.Location = new Point(393, 38);
            UserSearchbutton.Name = "UserSearchbutton";
            UserSearchbutton.Size = new Size(75, 29);
            UserSearchbutton.TabIndex = 87;
            UserSearchbutton.Text = "Search";
            UserSearchbutton.UseVisualStyleBackColor = true;
            UserSearchbutton.Click += UserSearchbutton_Click;
            // 
            // SearchUserTextBox
            // 
            SearchUserTextBox.Anchor = AnchorStyles.None;
            SearchUserTextBox.Location = new Point(72, 38);
            SearchUserTextBox.Name = "SearchUserTextBox";
            SearchUserTextBox.Size = new Size(280, 29);
            SearchUserTextBox.TabIndex = 86;
            // 
            // AddressrichTextBox
            // 
            AddressrichTextBox.Anchor = AnchorStyles.None;
            AddressrichTextBox.Location = new Point(244, 755);
            AddressrichTextBox.Name = "AddressrichTextBox";
            AddressrichTextBox.Size = new Size(275, 81);
            AddressrichTextBox.TabIndex = 114;
            AddressrichTextBox.Text = "";
            // 
            // FemaleradioButton
            // 
            FemaleradioButton.Anchor = AnchorStyles.None;
            FemaleradioButton.AutoSize = true;
            FemaleradioButton.Location = new Point(362, 394);
            FemaleradioButton.Name = "FemaleradioButton";
            FemaleradioButton.Size = new Size(81, 25);
            FemaleradioButton.TabIndex = 113;
            FemaleradioButton.TabStop = true;
            FemaleradioButton.Text = "Female";
            FemaleradioButton.UseVisualStyleBackColor = true;
            // 
            // MaleradioButton
            // 
            MaleradioButton.Anchor = AnchorStyles.None;
            MaleradioButton.AutoSize = true;
            MaleradioButton.Location = new Point(244, 392);
            MaleradioButton.Name = "MaleradioButton";
            MaleradioButton.Size = new Size(64, 25);
            MaleradioButton.TabIndex = 112;
            MaleradioButton.TabStop = true;
            MaleradioButton.Text = "Male";
            MaleradioButton.UseVisualStyleBackColor = true;
            // 
            // Addresslabel
            // 
            Addresslabel.Anchor = AnchorStyles.None;
            Addresslabel.AutoSize = true;
            Addresslabel.Location = new Point(135, 757);
            Addresslabel.Name = "Addresslabel";
            Addresslabel.Size = new Size(82, 21);
            Addresslabel.TabIndex = 111;
            Addresslabel.Text = "Address :";
            // 
            // EmailtextBox
            // 
            EmailtextBox.Anchor = AnchorStyles.None;
            EmailtextBox.Location = new Point(244, 697);
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(280, 29);
            EmailtextBox.TabIndex = 110;
            // 
            // Emaillabel
            // 
            Emaillabel.Anchor = AnchorStyles.None;
            Emaillabel.AutoSize = true;
            Emaillabel.Location = new Point(164, 697);
            Emaillabel.Name = "Emaillabel";
            Emaillabel.Size = new Size(60, 21);
            Emaillabel.TabIndex = 109;
            Emaillabel.Text = "Email :";
            // 
            // PhoneNumbertextBox
            // 
            PhoneNumbertextBox.Anchor = AnchorStyles.None;
            PhoneNumbertextBox.Location = new Point(244, 640);
            PhoneNumbertextBox.Name = "PhoneNumbertextBox";
            PhoneNumbertextBox.Size = new Size(280, 29);
            PhoneNumbertextBox.TabIndex = 108;
            // 
            // PhoneNumberlabel
            // 
            PhoneNumberlabel.Anchor = AnchorStyles.None;
            PhoneNumberlabel.AutoSize = true;
            PhoneNumberlabel.Location = new Point(97, 643);
            PhoneNumberlabel.Name = "PhoneNumberlabel";
            PhoneNumberlabel.Size = new Size(131, 21);
            PhoneNumberlabel.TabIndex = 107;
            PhoneNumberlabel.Text = "Phone Number :";
            // 
            // BrowsePhotobutton
            // 
            BrowsePhotobutton.Anchor = AnchorStyles.None;
            BrowsePhotobutton.Location = new Point(429, 519);
            BrowsePhotobutton.Name = "BrowsePhotobutton";
            BrowsePhotobutton.Size = new Size(90, 30);
            BrowsePhotobutton.TabIndex = 106;
            BrowsePhotobutton.Text = "Browse";
            BrowsePhotobutton.UseVisualStyleBackColor = true;
            BrowsePhotobutton.Click += BrowsePhotobutton_Click;
            // 
            // PhotopictureBox
            // 
            PhotopictureBox.Anchor = AnchorStyles.None;
            PhotopictureBox.BorderStyle = BorderStyle.FixedSingle;
            PhotopictureBox.Location = new Point(244, 444);
            PhotopictureBox.Name = "PhotopictureBox";
            PhotopictureBox.Size = new Size(156, 180);
            PhotopictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PhotopictureBox.TabIndex = 105;
            PhotopictureBox.TabStop = false;
            // 
            // Photolabel
            // 
            Photolabel.Anchor = AnchorStyles.None;
            Photolabel.AutoSize = true;
            Photolabel.Location = new Point(164, 519);
            Photolabel.Name = "Photolabel";
            Photolabel.Size = new Size(64, 21);
            Photolabel.TabIndex = 104;
            Photolabel.Text = "Photo :";
            // 
            // Genderlabel
            // 
            Genderlabel.Anchor = AnchorStyles.None;
            Genderlabel.AutoSize = true;
            Genderlabel.Location = new Point(154, 393);
            Genderlabel.Name = "Genderlabel";
            Genderlabel.Size = new Size(74, 21);
            Genderlabel.TabIndex = 103;
            Genderlabel.Text = "Gender :";
            // 
            // DateOfBirthdatePicker
            // 
            DateOfBirthdatePicker.Anchor = AnchorStyles.None;
            DateOfBirthdatePicker.Format = DateTimePickerFormat.Short;
            DateOfBirthdatePicker.Location = new Point(244, 335);
            DateOfBirthdatePicker.Name = "DateOfBirthdatePicker";
            DateOfBirthdatePicker.Size = new Size(280, 29);
            DateOfBirthdatePicker.TabIndex = 102;
            // 
            // DateOfBirthlabel
            // 
            DateOfBirthlabel.Anchor = AnchorStyles.None;
            DateOfBirthlabel.AutoSize = true;
            DateOfBirthlabel.Location = new Point(113, 337);
            DateOfBirthlabel.Name = "DateOfBirthlabel";
            DateOfBirthlabel.Size = new Size(115, 21);
            DateOfBirthlabel.TabIndex = 101;
            DateOfBirthlabel.Text = "Date of Birth :";
            // 
            // FullNametextBox
            // 
            FullNametextBox.Anchor = AnchorStyles.None;
            FullNametextBox.Location = new Point(244, 273);
            FullNametextBox.Name = "FullNametextBox";
            FullNametextBox.Size = new Size(280, 29);
            FullNametextBox.TabIndex = 100;
            // 
            // FullNamelabel
            // 
            FullNamelabel.Anchor = AnchorStyles.None;
            FullNamelabel.AutoSize = true;
            FullNamelabel.Location = new Point(133, 277);
            FullNamelabel.Name = "FullNamelabel";
            FullNamelabel.Size = new Size(95, 21);
            FullNamelabel.TabIndex = 99;
            FullNamelabel.Text = "Full Name :";
            // 
            // UserIDtextBox
            // 
            UserIDtextBox.Anchor = AnchorStyles.None;
            UserIDtextBox.Location = new Point(244, 216);
            UserIDtextBox.Name = "UserIDtextBox";
            UserIDtextBox.ReadOnly = true;
            UserIDtextBox.Size = new Size(280, 29);
            UserIDtextBox.TabIndex = 98;
            // 
            // UserIDlabel
            // 
            UserIDlabel.Anchor = AnchorStyles.None;
            UserIDlabel.AutoSize = true;
            UserIDlabel.Location = new Point(150, 221);
            UserIDlabel.Name = "UserIDlabel";
            UserIDlabel.Size = new Size(78, 21);
            UserIDlabel.TabIndex = 97;
            UserIDlabel.Text = "User ID :";
            // 
            // BranchIDsearchbutton
            // 
            BranchIDsearchbutton.Anchor = AnchorStyles.None;
            BranchIDsearchbutton.Location = new Point(1059, 384);
            BranchIDsearchbutton.Name = "BranchIDsearchbutton";
            BranchIDsearchbutton.Size = new Size(75, 29);
            BranchIDsearchbutton.TabIndex = 125;
            BranchIDsearchbutton.Text = "Search";
            BranchIDsearchbutton.UseVisualStyleBackColor = true;
            BranchIDsearchbutton.Click += BranchIDsearchbutton_Click;
            // 
            // BranchNametextBox
            // 
            BranchNametextBox.Anchor = AnchorStyles.None;
            BranchNametextBox.Location = new Point(758, 443);
            BranchNametextBox.Name = "BranchNametextBox";
            BranchNametextBox.ReadOnly = true;
            BranchNametextBox.Size = new Size(280, 29);
            BranchNametextBox.TabIndex = 124;
            // 
            // BranchNamelabel
            // 
            BranchNamelabel.Anchor = AnchorStyles.None;
            BranchNamelabel.AutoSize = true;
            BranchNamelabel.Location = new Point(611, 447);
            BranchNamelabel.Name = "BranchNamelabel";
            BranchNamelabel.Size = new Size(120, 21);
            BranchNamelabel.TabIndex = 123;
            BranchNamelabel.Text = "Branch Name :";
            // 
            // BranchIDtextBox
            // 
            BranchIDtextBox.Anchor = AnchorStyles.None;
            BranchIDtextBox.Location = new Point(758, 384);
            BranchIDtextBox.Name = "BranchIDtextBox";
            BranchIDtextBox.Size = new Size(280, 29);
            BranchIDtextBox.TabIndex = 122;
            // 
            // BranchIDlabel
            // 
            BranchIDlabel.Anchor = AnchorStyles.None;
            BranchIDlabel.AutoSize = true;
            BranchIDlabel.Location = new Point(635, 387);
            BranchIDlabel.Name = "BranchIDlabel";
            BranchIDlabel.Size = new Size(96, 21);
            BranchIDlabel.TabIndex = 121;
            BranchIDlabel.Text = "Branch ID :";
            // 
            // IsActivecheckBox
            // 
            IsActivecheckBox.Anchor = AnchorStyles.None;
            IsActivecheckBox.AutoSize = true;
            IsActivecheckBox.Location = new Point(758, 337);
            IsActivecheckBox.Name = "IsActivecheckBox";
            IsActivecheckBox.Size = new Size(95, 25);
            IsActivecheckBox.TabIndex = 120;
            IsActivecheckBox.Text = "Is Active";
            IsActivecheckBox.UseVisualStyleBackColor = true;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.Anchor = AnchorStyles.None;
            PasswordtextBox.Location = new Point(758, 277);
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.PasswordChar = '*';
            PasswordtextBox.ReadOnly = true;
            PasswordtextBox.Size = new Size(280, 29);
            PasswordtextBox.TabIndex = 119;
            // 
            // Passwordlabel
            // 
            Passwordlabel.Anchor = AnchorStyles.None;
            Passwordlabel.AutoSize = true;
            Passwordlabel.Location = new Point(638, 280);
            Passwordlabel.Name = "Passwordlabel";
            Passwordlabel.Size = new Size(93, 21);
            Passwordlabel.TabIndex = 118;
            Passwordlabel.Text = "Password :";
            // 
            // UsernametextBox
            // 
            UsernametextBox.Anchor = AnchorStyles.None;
            UsernametextBox.Location = new Point(758, 220);
            UsernametextBox.Name = "UsernametextBox";
            UsernametextBox.ReadOnly = true;
            UsernametextBox.Size = new Size(280, 29);
            UsernametextBox.TabIndex = 117;
            // 
            // Usernamelabel
            // 
            Usernamelabel.Anchor = AnchorStyles.None;
            Usernamelabel.AutoSize = true;
            Usernamelabel.Location = new Point(638, 223);
            Usernamelabel.Name = "Usernamelabel";
            Usernamelabel.Size = new Size(93, 21);
            Usernamelabel.TabIndex = 116;
            Usernamelabel.Text = "Username :";
            // 
            // CanManageStockcheckBox
            // 
            CanManageStockcheckBox.Anchor = AnchorStyles.None;
            CanManageStockcheckBox.AutoSize = true;
            CanManageStockcheckBox.Location = new Point(758, 716);
            CanManageStockcheckBox.Name = "CanManageStockcheckBox";
            CanManageStockcheckBox.Size = new Size(171, 25);
            CanManageStockcheckBox.TabIndex = 132;
            CanManageStockcheckBox.Text = "Can Manage Stock";
            CanManageStockcheckBox.UseVisualStyleBackColor = true;
            // 
            // CanProcessReturnscheckBox
            // 
            CanProcessReturnscheckBox.Anchor = AnchorStyles.None;
            CanProcessReturnscheckBox.AutoSize = true;
            CanProcessReturnscheckBox.Location = new Point(758, 670);
            CanProcessReturnscheckBox.Name = "CanProcessReturnscheckBox";
            CanProcessReturnscheckBox.Size = new Size(187, 25);
            CanProcessReturnscheckBox.TabIndex = 131;
            CanProcessReturnscheckBox.Text = "Can Process Returns";
            CanProcessReturnscheckBox.UseVisualStyleBackColor = true;
            // 
            // CanProcessSalescheckBox
            // 
            CanProcessSalescheckBox.Anchor = AnchorStyles.None;
            CanProcessSalescheckBox.AutoSize = true;
            CanProcessSalescheckBox.Location = new Point(758, 624);
            CanProcessSalescheckBox.Name = "CanProcessSalescheckBox";
            CanProcessSalescheckBox.Size = new Size(168, 25);
            CanProcessSalescheckBox.TabIndex = 130;
            CanProcessSalescheckBox.Text = "Can Process Sales";
            CanProcessSalescheckBox.UseVisualStyleBackColor = true;
            // 
            // CashierTypecomboBox
            // 
            CashierTypecomboBox.Anchor = AnchorStyles.None;
            CashierTypecomboBox.FormattingEnabled = true;
            CashierTypecomboBox.Items.AddRange(new object[] { "SaleCashier", "StockKeeper", "Accountant" });
            CashierTypecomboBox.Location = new Point(758, 564);
            CashierTypecomboBox.Name = "CashierTypecomboBox";
            CashierTypecomboBox.Size = new Size(280, 29);
            CashierTypecomboBox.TabIndex = 129;
            // 
            // CashierTypelabel
            // 
            CashierTypelabel.Anchor = AnchorStyles.None;
            CashierTypelabel.AutoSize = true;
            CashierTypelabel.Location = new Point(634, 567);
            CashierTypelabel.Name = "CashierTypelabel";
            CashierTypelabel.Size = new Size(118, 21);
            CashierTypelabel.TabIndex = 128;
            CashierTypelabel.Text = "Cashier Type :";
            // 
            // CashierIDtextBox
            // 
            CashierIDtextBox.Anchor = AnchorStyles.None;
            CashierIDtextBox.Location = new Point(758, 508);
            CashierIDtextBox.Name = "CashierIDtextBox";
            CashierIDtextBox.ReadOnly = true;
            CashierIDtextBox.Size = new Size(280, 29);
            CashierIDtextBox.TabIndex = 127;
            // 
            // CashierIDlabel
            // 
            CashierIDlabel.Anchor = AnchorStyles.None;
            CashierIDlabel.AutoSize = true;
            CashierIDlabel.Location = new Point(649, 516);
            CashierIDlabel.Name = "CashierIDlabel";
            CashierIDlabel.Size = new Size(99, 21);
            CashierIDlabel.TabIndex = 126;
            CashierIDlabel.Text = "Cashier ID :";
            // 
            // Cancelbutton
            // 
            Cancelbutton.Anchor = AnchorStyles.None;
            Cancelbutton.BackColor = Color.Red;
            Cancelbutton.ForeColor = Color.White;
            Cancelbutton.Location = new Point(963, 773);
            Cancelbutton.Name = "Cancelbutton";
            Cancelbutton.Size = new Size(124, 41);
            Cancelbutton.TabIndex = 135;
            Cancelbutton.Text = "Cancel";
            Cancelbutton.UseVisualStyleBackColor = false;
            Cancelbutton.Click += Cancelbutton_Click;
            // 
            // Clearbutton
            // 
            Clearbutton.Anchor = AnchorStyles.None;
            Clearbutton.BackColor = Color.Tan;
            Clearbutton.Location = new Point(810, 773);
            Clearbutton.Name = "Clearbutton";
            Clearbutton.Size = new Size(124, 41);
            Clearbutton.TabIndex = 134;
            Clearbutton.Text = "Clear";
            Clearbutton.UseVisualStyleBackColor = false;
            Clearbutton.Click += Clearbutton_Click;
            // 
            // Savebutton
            // 
            Savebutton.Anchor = AnchorStyles.None;
            Savebutton.BackColor = Color.OliveDrab;
            Savebutton.ForeColor = Color.White;
            Savebutton.Location = new Point(657, 773);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(124, 41);
            Savebutton.TabIndex = 133;
            Savebutton.Text = "Save";
            Savebutton.UseVisualStyleBackColor = false;
            Savebutton.Click += Savebutton_Click;
            // 
            // UpdateCashierGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 857);
            Controls.Add(Cancelbutton);
            Controls.Add(Clearbutton);
            Controls.Add(Savebutton);
            Controls.Add(CanManageStockcheckBox);
            Controls.Add(CanProcessReturnscheckBox);
            Controls.Add(CanProcessSalescheckBox);
            Controls.Add(CashierTypecomboBox);
            Controls.Add(CashierTypelabel);
            Controls.Add(CashierIDtextBox);
            Controls.Add(CashierIDlabel);
            Controls.Add(BranchIDsearchbutton);
            Controls.Add(BranchNametextBox);
            Controls.Add(BranchNamelabel);
            Controls.Add(BranchIDtextBox);
            Controls.Add(BranchIDlabel);
            Controls.Add(IsActivecheckBox);
            Controls.Add(PasswordtextBox);
            Controls.Add(Passwordlabel);
            Controls.Add(UsernametextBox);
            Controls.Add(Usernamelabel);
            Controls.Add(SearchgroupBox);
            Controls.Add(AddressrichTextBox);
            Controls.Add(FemaleradioButton);
            Controls.Add(MaleradioButton);
            Controls.Add(Addresslabel);
            Controls.Add(EmailtextBox);
            Controls.Add(Emaillabel);
            Controls.Add(PhoneNumbertextBox);
            Controls.Add(PhoneNumberlabel);
            Controls.Add(BrowsePhotobutton);
            Controls.Add(PhotopictureBox);
            Controls.Add(Photolabel);
            Controls.Add(Genderlabel);
            Controls.Add(DateOfBirthdatePicker);
            Controls.Add(DateOfBirthlabel);
            Controls.Add(FullNametextBox);
            Controls.Add(FullNamelabel);
            Controls.Add(UserIDtextBox);
            Controls.Add(UserIDlabel);
            Controls.Add(Headerpanel);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "UpdateCashierGUI";
            Text = "UpdateCashierGUI";
            SearchgroupBox.ResumeLayout(false);
            SearchgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PhotopictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Headerpanel;
        private GroupBox SearchgroupBox;
        private RichTextBox AddressrichTextBox;
        private RadioButton FemaleradioButton;
        private RadioButton MaleradioButton;
        private Label Addresslabel;
        private TextBox EmailtextBox;
        private Label Emaillabel;
        private TextBox PhoneNumbertextBox;
        private Label PhoneNumberlabel;
        private Button BrowsePhotobutton;
        private PictureBox PhotopictureBox;
        private Label Photolabel;
        private Label Genderlabel;
        private DateTimePicker DateOfBirthdatePicker;
        private Label DateOfBirthlabel;
        private TextBox FullNametextBox;
        private Label FullNamelabel;
        private TextBox UserIDtextBox;
        private Label UserIDlabel;
        private Button BranchIDsearchbutton;
        private TextBox BranchNametextBox;
        private Label BranchNamelabel;
        private TextBox BranchIDtextBox;
        private Label BranchIDlabel;
        private CheckBox IsActivecheckBox;
        private TextBox PasswordtextBox;
        private Label Passwordlabel;
        private TextBox UsernametextBox;
        private Label Usernamelabel;
        private CheckBox CanManageStockcheckBox;
        private CheckBox CanProcessReturnscheckBox;
        private CheckBox CanProcessSalescheckBox;
        private ComboBox CashierTypecomboBox;
        private Label CashierTypelabel;
        private TextBox CashierIDtextBox;
        private Label CashierIDlabel;
        private Button Cancelbutton;
        private Button Clearbutton;
        private Button Savebutton;
        private Button UserSearchbutton;
        private TextBox SearchUserTextBox;
    }
}