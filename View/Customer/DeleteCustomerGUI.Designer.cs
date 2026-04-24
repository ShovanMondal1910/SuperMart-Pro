namespace SuperMart_Pro.View.Customer
{
    partial class DeleteCustomerGUI
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
            UserSearchbutton = new Button();
            SearchgroupBox = new GroupBox();
            SearchUserTextBox = new TextBox();
            AddressrichTextBox = new RichTextBox();
            FemaleradioButton = new RadioButton();
            MaleradioButton = new RadioButton();
            BranchIDsearchbutton = new Button();
            Cancelbutton = new Button();
            Clearbutton = new Button();
            Savebutton = new Button();
            CustomerTypecomboBox = new ComboBox();
            CustomerTypelabel = new Label();
            CustomerIDtextBox = new TextBox();
            CustomerIDlabel = new Label();
            BranchNametextBox = new TextBox();
            BranchNamelabel = new Label();
            BranchIDtextBox = new TextBox();
            BranchIDlabel = new Label();
            IsActivecheckBox = new CheckBox();
            PasswordtextBox = new TextBox();
            Passwordlabel = new Label();
            UsernametextBox = new TextBox();
            Usernamelabel = new Label();
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
            SearchgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PhotopictureBox).BeginInit();
            SuspendLayout();
            // 
            // UserSearchbutton
            // 
            UserSearchbutton.Anchor = AnchorStyles.None;
            UserSearchbutton.Location = new Point(418, 30);
            UserSearchbutton.Name = "UserSearchbutton";
            UserSearchbutton.Size = new Size(75, 29);
            UserSearchbutton.TabIndex = 87;
            UserSearchbutton.Text = "Search";
            UserSearchbutton.UseVisualStyleBackColor = true;
            UserSearchbutton.Click += UserSearchbutton_Click;
            // 
            // SearchgroupBox
            // 
            SearchgroupBox.Anchor = AnchorStyles.None;
            SearchgroupBox.Controls.Add(UserSearchbutton);
            SearchgroupBox.Controls.Add(SearchUserTextBox);
            SearchgroupBox.Location = new Point(312, 25);
            SearchgroupBox.Name = "SearchgroupBox";
            SearchgroupBox.Size = new Size(525, 86);
            SearchgroupBox.TabIndex = 185;
            SearchgroupBox.TabStop = false;
            SearchgroupBox.Text = "Search by UserID/Phone number/UserName";
            // 
            // SearchUserTextBox
            // 
            SearchUserTextBox.Anchor = AnchorStyles.None;
            SearchUserTextBox.Location = new Point(69, 30);
            SearchUserTextBox.Name = "SearchUserTextBox";
            SearchUserTextBox.Size = new Size(280, 29);
            SearchUserTextBox.TabIndex = 86;
            // 
            // AddressrichTextBox
            // 
            AddressrichTextBox.Anchor = AnchorStyles.None;
            AddressrichTextBox.Location = new Point(191, 660);
            AddressrichTextBox.Name = "AddressrichTextBox";
            AddressrichTextBox.ReadOnly = true;
            AddressrichTextBox.Size = new Size(275, 81);
            AddressrichTextBox.TabIndex = 184;
            AddressrichTextBox.Text = "";
            // 
            // FemaleradioButton
            // 
            FemaleradioButton.Anchor = AnchorStyles.None;
            FemaleradioButton.AutoSize = true;
            FemaleradioButton.Enabled = false;
            FemaleradioButton.Location = new Point(309, 299);
            FemaleradioButton.Name = "FemaleradioButton";
            FemaleradioButton.Size = new Size(81, 25);
            FemaleradioButton.TabIndex = 183;
            FemaleradioButton.TabStop = true;
            FemaleradioButton.Text = "Female";
            FemaleradioButton.UseVisualStyleBackColor = true;
            // 
            // MaleradioButton
            // 
            MaleradioButton.Anchor = AnchorStyles.None;
            MaleradioButton.AutoSize = true;
            MaleradioButton.Enabled = false;
            MaleradioButton.Location = new Point(191, 297);
            MaleradioButton.Name = "MaleradioButton";
            MaleradioButton.Size = new Size(64, 25);
            MaleradioButton.TabIndex = 182;
            MaleradioButton.TabStop = true;
            MaleradioButton.Text = "Male";
            MaleradioButton.UseVisualStyleBackColor = true;
            // 
            // BranchIDsearchbutton
            // 
            BranchIDsearchbutton.Anchor = AnchorStyles.None;
            BranchIDsearchbutton.Location = new Point(1049, 290);
            BranchIDsearchbutton.Name = "BranchIDsearchbutton";
            BranchIDsearchbutton.Size = new Size(75, 29);
            BranchIDsearchbutton.TabIndex = 173;
            BranchIDsearchbutton.Text = "Search";
            BranchIDsearchbutton.UseVisualStyleBackColor = true;
            // 
            // Cancelbutton
            // 
            Cancelbutton.Anchor = AnchorStyles.None;
            Cancelbutton.BackColor = Color.Red;
            Cancelbutton.ForeColor = Color.White;
            Cancelbutton.Location = new Point(934, 529);
            Cancelbutton.Name = "Cancelbutton";
            Cancelbutton.Size = new Size(124, 41);
            Cancelbutton.TabIndex = 172;
            Cancelbutton.Text = "Cancel";
            Cancelbutton.UseVisualStyleBackColor = false;
            Cancelbutton.Click += Cancelbutton_Click;
            // 
            // Clearbutton
            // 
            Clearbutton.Anchor = AnchorStyles.None;
            Clearbutton.BackColor = Color.Tan;
            Clearbutton.Location = new Point(781, 529);
            Clearbutton.Name = "Clearbutton";
            Clearbutton.Size = new Size(124, 41);
            Clearbutton.TabIndex = 171;
            Clearbutton.Text = "Clear";
            Clearbutton.UseVisualStyleBackColor = false;
            Clearbutton.Click += Clearbutton_Click;
            // 
            // Savebutton
            // 
            Savebutton.Anchor = AnchorStyles.None;
            Savebutton.BackColor = Color.OliveDrab;
            Savebutton.ForeColor = Color.White;
            Savebutton.Location = new Point(628, 529);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(124, 41);
            Savebutton.TabIndex = 170;
            Savebutton.Text = "Save";
            Savebutton.UseVisualStyleBackColor = false;
            Savebutton.Click += Savebutton_Click;
            // 
            // CustomerTypecomboBox
            // 
            CustomerTypecomboBox.Anchor = AnchorStyles.None;
            CustomerTypecomboBox.Enabled = false;
            CustomerTypecomboBox.FormattingEnabled = true;
            CustomerTypecomboBox.Items.AddRange(new object[] { "Regular", "Premium", "VIP" });
            CustomerTypecomboBox.Location = new Point(739, 464);
            CustomerTypecomboBox.Name = "CustomerTypecomboBox";
            CustomerTypecomboBox.Size = new Size(280, 29);
            CustomerTypecomboBox.TabIndex = 169;
            // 
            // CustomerTypelabel
            // 
            CustomerTypelabel.Anchor = AnchorStyles.None;
            CustomerTypelabel.AutoSize = true;
            CustomerTypelabel.Location = new Point(590, 467);
            CustomerTypelabel.Name = "CustomerTypelabel";
            CustomerTypelabel.Size = new Size(135, 21);
            CustomerTypelabel.TabIndex = 168;
            CustomerTypelabel.Text = "Customer Type :";
            // 
            // CustomerIDtextBox
            // 
            CustomerIDtextBox.Anchor = AnchorStyles.None;
            CustomerIDtextBox.Location = new Point(739, 408);
            CustomerIDtextBox.Name = "CustomerIDtextBox";
            CustomerIDtextBox.ReadOnly = true;
            CustomerIDtextBox.Size = new Size(280, 29);
            CustomerIDtextBox.TabIndex = 167;
            // 
            // CustomerIDlabel
            // 
            CustomerIDlabel.Anchor = AnchorStyles.None;
            CustomerIDlabel.AutoSize = true;
            CustomerIDlabel.Location = new Point(609, 416);
            CustomerIDlabel.Name = "CustomerIDlabel";
            CustomerIDlabel.Size = new Size(116, 21);
            CustomerIDlabel.TabIndex = 166;
            CustomerIDlabel.Text = "Customer ID :";
            // 
            // BranchNametextBox
            // 
            BranchNametextBox.Anchor = AnchorStyles.None;
            BranchNametextBox.Location = new Point(739, 350);
            BranchNametextBox.Name = "BranchNametextBox";
            BranchNametextBox.ReadOnly = true;
            BranchNametextBox.Size = new Size(280, 29);
            BranchNametextBox.TabIndex = 165;
            // 
            // BranchNamelabel
            // 
            BranchNamelabel.Anchor = AnchorStyles.None;
            BranchNamelabel.AutoSize = true;
            BranchNamelabel.Location = new Point(592, 354);
            BranchNamelabel.Name = "BranchNamelabel";
            BranchNamelabel.Size = new Size(120, 21);
            BranchNamelabel.TabIndex = 164;
            BranchNamelabel.Text = "Branch Name :";
            // 
            // BranchIDtextBox
            // 
            BranchIDtextBox.Anchor = AnchorStyles.None;
            BranchIDtextBox.Location = new Point(739, 291);
            BranchIDtextBox.Name = "BranchIDtextBox";
            BranchIDtextBox.ReadOnly = true;
            BranchIDtextBox.Size = new Size(280, 29);
            BranchIDtextBox.TabIndex = 163;
            // 
            // BranchIDlabel
            // 
            BranchIDlabel.Anchor = AnchorStyles.None;
            BranchIDlabel.AutoSize = true;
            BranchIDlabel.Location = new Point(616, 294);
            BranchIDlabel.Name = "BranchIDlabel";
            BranchIDlabel.Size = new Size(96, 21);
            BranchIDlabel.TabIndex = 162;
            BranchIDlabel.Text = "Branch ID :";
            // 
            // IsActivecheckBox
            // 
            IsActivecheckBox.Anchor = AnchorStyles.None;
            IsActivecheckBox.AutoSize = true;
            IsActivecheckBox.Enabled = false;
            IsActivecheckBox.Location = new Point(739, 244);
            IsActivecheckBox.Name = "IsActivecheckBox";
            IsActivecheckBox.Size = new Size(95, 25);
            IsActivecheckBox.TabIndex = 161;
            IsActivecheckBox.Text = "Is Active";
            IsActivecheckBox.UseVisualStyleBackColor = true;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.Anchor = AnchorStyles.None;
            PasswordtextBox.Location = new Point(739, 184);
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.PasswordChar = '*';
            PasswordtextBox.ReadOnly = true;
            PasswordtextBox.Size = new Size(280, 29);
            PasswordtextBox.TabIndex = 160;
            // 
            // Passwordlabel
            // 
            Passwordlabel.Anchor = AnchorStyles.None;
            Passwordlabel.AutoSize = true;
            Passwordlabel.Location = new Point(619, 187);
            Passwordlabel.Name = "Passwordlabel";
            Passwordlabel.Size = new Size(93, 21);
            Passwordlabel.TabIndex = 159;
            Passwordlabel.Text = "Password :";
            // 
            // UsernametextBox
            // 
            UsernametextBox.Anchor = AnchorStyles.None;
            UsernametextBox.Location = new Point(739, 127);
            UsernametextBox.Name = "UsernametextBox";
            UsernametextBox.ReadOnly = true;
            UsernametextBox.Size = new Size(280, 29);
            UsernametextBox.TabIndex = 158;
            // 
            // Usernamelabel
            // 
            Usernamelabel.Anchor = AnchorStyles.None;
            Usernamelabel.AutoSize = true;
            Usernamelabel.Location = new Point(619, 130);
            Usernamelabel.Name = "Usernamelabel";
            Usernamelabel.Size = new Size(93, 21);
            Usernamelabel.TabIndex = 157;
            Usernamelabel.Text = "Username :";
            // 
            // Addresslabel
            // 
            Addresslabel.Anchor = AnchorStyles.None;
            Addresslabel.AutoSize = true;
            Addresslabel.Location = new Point(79, 663);
            Addresslabel.Name = "Addresslabel";
            Addresslabel.Size = new Size(82, 21);
            Addresslabel.TabIndex = 156;
            Addresslabel.Text = "Address :";
            // 
            // EmailtextBox
            // 
            EmailtextBox.Anchor = AnchorStyles.None;
            EmailtextBox.Location = new Point(191, 603);
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.ReadOnly = true;
            EmailtextBox.Size = new Size(280, 29);
            EmailtextBox.TabIndex = 155;
            // 
            // Emaillabel
            // 
            Emaillabel.Anchor = AnchorStyles.None;
            Emaillabel.AutoSize = true;
            Emaillabel.Location = new Point(108, 603);
            Emaillabel.Name = "Emaillabel";
            Emaillabel.Size = new Size(60, 21);
            Emaillabel.TabIndex = 154;
            Emaillabel.Text = "Email :";
            // 
            // PhoneNumbertextBox
            // 
            PhoneNumbertextBox.Anchor = AnchorStyles.None;
            PhoneNumbertextBox.Location = new Point(191, 546);
            PhoneNumbertextBox.Name = "PhoneNumbertextBox";
            PhoneNumbertextBox.ReadOnly = true;
            PhoneNumbertextBox.Size = new Size(280, 29);
            PhoneNumbertextBox.TabIndex = 153;
            // 
            // PhoneNumberlabel
            // 
            PhoneNumberlabel.Anchor = AnchorStyles.None;
            PhoneNumberlabel.AutoSize = true;
            PhoneNumberlabel.Location = new Point(41, 549);
            PhoneNumberlabel.Name = "PhoneNumberlabel";
            PhoneNumberlabel.Size = new Size(131, 21);
            PhoneNumberlabel.TabIndex = 152;
            PhoneNumberlabel.Text = "Phone Number :";
            // 
            // BrowsePhotobutton
            // 
            BrowsePhotobutton.Anchor = AnchorStyles.None;
            BrowsePhotobutton.Location = new Point(376, 425);
            BrowsePhotobutton.Name = "BrowsePhotobutton";
            BrowsePhotobutton.Size = new Size(90, 30);
            BrowsePhotobutton.TabIndex = 151;
            BrowsePhotobutton.Text = "Browse";
            BrowsePhotobutton.UseVisualStyleBackColor = true;
            // 
            // PhotopictureBox
            // 
            PhotopictureBox.Anchor = AnchorStyles.None;
            PhotopictureBox.BorderStyle = BorderStyle.FixedSingle;
            PhotopictureBox.Location = new Point(191, 350);
            PhotopictureBox.Name = "PhotopictureBox";
            PhotopictureBox.Size = new Size(156, 180);
            PhotopictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PhotopictureBox.TabIndex = 150;
            PhotopictureBox.TabStop = false;
            // 
            // Photolabel
            // 
            Photolabel.Anchor = AnchorStyles.None;
            Photolabel.AutoSize = true;
            Photolabel.Location = new Point(108, 425);
            Photolabel.Name = "Photolabel";
            Photolabel.Size = new Size(64, 21);
            Photolabel.TabIndex = 149;
            Photolabel.Text = "Photo :";
            // 
            // Genderlabel
            // 
            Genderlabel.Anchor = AnchorStyles.None;
            Genderlabel.AutoSize = true;
            Genderlabel.Location = new Point(98, 299);
            Genderlabel.Name = "Genderlabel";
            Genderlabel.Size = new Size(74, 21);
            Genderlabel.TabIndex = 148;
            Genderlabel.Text = "Gender :";
            // 
            // DateOfBirthdatePicker
            // 
            DateOfBirthdatePicker.Anchor = AnchorStyles.None;
            DateOfBirthdatePicker.Enabled = false;
            DateOfBirthdatePicker.Format = DateTimePickerFormat.Short;
            DateOfBirthdatePicker.Location = new Point(191, 241);
            DateOfBirthdatePicker.Name = "DateOfBirthdatePicker";
            DateOfBirthdatePicker.Size = new Size(280, 29);
            DateOfBirthdatePicker.TabIndex = 147;
            // 
            // DateOfBirthlabel
            // 
            DateOfBirthlabel.Anchor = AnchorStyles.None;
            DateOfBirthlabel.AutoSize = true;
            DateOfBirthlabel.Location = new Point(57, 243);
            DateOfBirthlabel.Name = "DateOfBirthlabel";
            DateOfBirthlabel.Size = new Size(115, 21);
            DateOfBirthlabel.TabIndex = 146;
            DateOfBirthlabel.Text = "Date of Birth :";
            // 
            // FullNametextBox
            // 
            FullNametextBox.Anchor = AnchorStyles.None;
            FullNametextBox.Location = new Point(191, 179);
            FullNametextBox.Name = "FullNametextBox";
            FullNametextBox.ReadOnly = true;
            FullNametextBox.Size = new Size(280, 29);
            FullNametextBox.TabIndex = 145;
            // 
            // FullNamelabel
            // 
            FullNamelabel.Anchor = AnchorStyles.None;
            FullNamelabel.AutoSize = true;
            FullNamelabel.Location = new Point(77, 183);
            FullNamelabel.Name = "FullNamelabel";
            FullNamelabel.Size = new Size(95, 21);
            FullNamelabel.TabIndex = 144;
            FullNamelabel.Text = "Full Name :";
            // 
            // UserIDtextBox
            // 
            UserIDtextBox.Anchor = AnchorStyles.None;
            UserIDtextBox.Location = new Point(191, 122);
            UserIDtextBox.Name = "UserIDtextBox";
            UserIDtextBox.ReadOnly = true;
            UserIDtextBox.Size = new Size(280, 29);
            UserIDtextBox.TabIndex = 143;
            // 
            // UserIDlabel
            // 
            UserIDlabel.Anchor = AnchorStyles.None;
            UserIDlabel.AutoSize = true;
            UserIDlabel.Location = new Point(94, 127);
            UserIDlabel.Name = "UserIDlabel";
            UserIDlabel.Size = new Size(78, 21);
            UserIDlabel.TabIndex = 142;
            UserIDlabel.Text = "User ID :";
            // 
            // DeleteCustomerGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 764);
            Controls.Add(SearchgroupBox);
            Controls.Add(AddressrichTextBox);
            Controls.Add(FemaleradioButton);
            Controls.Add(MaleradioButton);
            Controls.Add(BranchIDsearchbutton);
            Controls.Add(Cancelbutton);
            Controls.Add(Clearbutton);
            Controls.Add(Savebutton);
            Controls.Add(CustomerTypecomboBox);
            Controls.Add(CustomerTypelabel);
            Controls.Add(CustomerIDtextBox);
            Controls.Add(CustomerIDlabel);
            Controls.Add(BranchNametextBox);
            Controls.Add(BranchNamelabel);
            Controls.Add(BranchIDtextBox);
            Controls.Add(BranchIDlabel);
            Controls.Add(IsActivecheckBox);
            Controls.Add(PasswordtextBox);
            Controls.Add(Passwordlabel);
            Controls.Add(UsernametextBox);
            Controls.Add(Usernamelabel);
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
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "DeleteCustomerGUI";
            Text = "DeleteCustomerGUI";
            SearchgroupBox.ResumeLayout(false);
            SearchgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PhotopictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UserSearchbutton;
        private GroupBox SearchgroupBox;
        private TextBox SearchUserTextBox;
        private RichTextBox AddressrichTextBox;
        private RadioButton FemaleradioButton;
        private RadioButton MaleradioButton;
        private Button BranchIDsearchbutton;
        private Button Cancelbutton;
        private Button Clearbutton;
        private Button Savebutton;
        private ComboBox CustomerTypecomboBox;
        private Label CustomerTypelabel;
        private TextBox CustomerIDtextBox;
        private Label CustomerIDlabel;
        private TextBox BranchNametextBox;
        private Label BranchNamelabel;
        private TextBox BranchIDtextBox;
        private Label BranchIDlabel;
        private CheckBox IsActivecheckBox;
        private TextBox PasswordtextBox;
        private Label Passwordlabel;
        private TextBox UsernametextBox;
        private Label Usernamelabel;
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
    }
}