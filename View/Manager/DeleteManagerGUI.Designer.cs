namespace SuperMart_Pro.View.Manager
{
    partial class DeleteManagerGUI
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
            CanViewBranchReportscheckBox = new CheckBox();
            CanApprovePurchasescheckBox = new CheckBox();
            CanManageInventoryescheckBox = new CheckBox();
            CanManageStuffcheckBox = new CheckBox();
            Cancelbutton = new Button();
            Clearbutton = new Button();
            Savebutton = new Button();
            ManagerTypecomboBox = new ComboBox();
            ManagerTypelabel = new Label();
            ManagerIDtextBox = new TextBox();
            ManagerIDlabel = new Label();
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
            SearchgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PhotopictureBox).BeginInit();
            SuspendLayout();
            // 
            // UserSearchbutton
            // 
            UserSearchbutton.Anchor = AnchorStyles.None;
            UserSearchbutton.Location = new Point(515, 29);
            UserSearchbutton.Name = "UserSearchbutton";
            UserSearchbutton.Size = new Size(75, 29);
            UserSearchbutton.TabIndex = 85;
            UserSearchbutton.Text = "Search";
            UserSearchbutton.UseVisualStyleBackColor = true;
            UserSearchbutton.Click += UserSearchbutton_Click;
            // 
            // SearchgroupBox
            // 
            SearchgroupBox.Anchor = AnchorStyles.None;
            SearchgroupBox.Controls.Add(UserSearchbutton);
            SearchgroupBox.Controls.Add(SearchUserTextBox);
            SearchgroupBox.Location = new Point(292, 24);
            SearchgroupBox.Name = "SearchgroupBox";
            SearchgroupBox.Size = new Size(498, 86);
            SearchgroupBox.TabIndex = 185;
            SearchgroupBox.TabStop = false;
            SearchgroupBox.Text = "Search by UserID/Phone number/UserName";
            // 
            // SearchUserTextBox
            // 
            SearchUserTextBox.Anchor = AnchorStyles.None;
            SearchUserTextBox.Location = new Point(182, 30);
            SearchUserTextBox.Name = "SearchUserTextBox";
            SearchUserTextBox.Size = new Size(280, 29);
            SearchUserTextBox.TabIndex = 67;
            // 
            // CanViewBranchReportscheckBox
            // 
            CanViewBranchReportscheckBox.Anchor = AnchorStyles.None;
            CanViewBranchReportscheckBox.AutoSize = true;
            CanViewBranchReportscheckBox.Location = new Point(718, 654);
            CanViewBranchReportscheckBox.Name = "CanViewBranchReportscheckBox";
            CanViewBranchReportscheckBox.Size = new Size(224, 25);
            CanViewBranchReportscheckBox.TabIndex = 184;
            CanViewBranchReportscheckBox.Text = "Can View Branch Reports";
            CanViewBranchReportscheckBox.UseVisualStyleBackColor = true;
            // 
            // CanApprovePurchasescheckBox
            // 
            CanApprovePurchasescheckBox.Anchor = AnchorStyles.None;
            CanApprovePurchasescheckBox.AutoSize = true;
            CanApprovePurchasescheckBox.Location = new Point(718, 611);
            CanApprovePurchasescheckBox.Name = "CanApprovePurchasescheckBox";
            CanApprovePurchasescheckBox.Size = new Size(210, 25);
            CanApprovePurchasescheckBox.TabIndex = 183;
            CanApprovePurchasescheckBox.Text = "Can Approve Purchases";
            CanApprovePurchasescheckBox.UseVisualStyleBackColor = true;
            // 
            // CanManageInventoryescheckBox
            // 
            CanManageInventoryescheckBox.Anchor = AnchorStyles.None;
            CanManageInventoryescheckBox.AutoSize = true;
            CanManageInventoryescheckBox.Location = new Point(718, 567);
            CanManageInventoryescheckBox.Name = "CanManageInventoryescheckBox";
            CanManageInventoryescheckBox.Size = new Size(198, 25);
            CanManageInventoryescheckBox.TabIndex = 182;
            CanManageInventoryescheckBox.Text = "Can Manage Inventory";
            CanManageInventoryescheckBox.UseVisualStyleBackColor = true;
            // 
            // CanManageStuffcheckBox
            // 
            CanManageStuffcheckBox.Anchor = AnchorStyles.None;
            CanManageStuffcheckBox.AutoSize = true;
            CanManageStuffcheckBox.Location = new Point(718, 522);
            CanManageStuffcheckBox.Name = "CanManageStuffcheckBox";
            CanManageStuffcheckBox.Size = new Size(164, 25);
            CanManageStuffcheckBox.TabIndex = 181;
            CanManageStuffcheckBox.Text = "Can Manage Stuff";
            CanManageStuffcheckBox.UseVisualStyleBackColor = true;
            // 
            // Cancelbutton
            // 
            Cancelbutton.Anchor = AnchorStyles.None;
            Cancelbutton.BackColor = Color.Red;
            Cancelbutton.ForeColor = Color.White;
            Cancelbutton.Location = new Point(874, 717);
            Cancelbutton.Name = "Cancelbutton";
            Cancelbutton.Size = new Size(124, 41);
            Cancelbutton.TabIndex = 180;
            Cancelbutton.Text = "Cancel";
            Cancelbutton.UseVisualStyleBackColor = false;
            Cancelbutton.Click += Cancelbutton_Click;
            // 
            // Clearbutton
            // 
            Clearbutton.Anchor = AnchorStyles.None;
            Clearbutton.BackColor = Color.Tan;
            Clearbutton.Location = new Point(721, 717);
            Clearbutton.Name = "Clearbutton";
            Clearbutton.Size = new Size(124, 41);
            Clearbutton.TabIndex = 179;
            Clearbutton.Text = "Clear";
            Clearbutton.UseVisualStyleBackColor = false;
            Clearbutton.Click += Clearbutton_Click;
            // 
            // Savebutton
            // 
            Savebutton.Anchor = AnchorStyles.None;
            Savebutton.BackColor = Color.OliveDrab;
            Savebutton.ForeColor = Color.White;
            Savebutton.Location = new Point(568, 717);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(124, 41);
            Savebutton.TabIndex = 178;
            Savebutton.Text = "Save";
            Savebutton.UseVisualStyleBackColor = false;
            Savebutton.Click += Savebutton_Click;
            // 
            // ManagerTypecomboBox
            // 
            ManagerTypecomboBox.Anchor = AnchorStyles.None;
            ManagerTypecomboBox.FormattingEnabled = true;
            ManagerTypecomboBox.Items.AddRange(new object[] { "BranchManager", "RegionalManager" });
            ManagerTypecomboBox.Location = new Point(718, 460);
            ManagerTypecomboBox.Name = "ManagerTypecomboBox";
            ManagerTypecomboBox.Size = new Size(280, 29);
            ManagerTypecomboBox.TabIndex = 177;
            // 
            // ManagerTypelabel
            // 
            ManagerTypelabel.Anchor = AnchorStyles.None;
            ManagerTypelabel.AutoSize = true;
            ManagerTypelabel.Location = new Point(571, 463);
            ManagerTypelabel.Name = "ManagerTypelabel";
            ManagerTypelabel.Size = new Size(126, 21);
            ManagerTypelabel.TabIndex = 176;
            ManagerTypelabel.Text = "Manager Type :";
            // 
            // ManagerIDtextBox
            // 
            ManagerIDtextBox.Anchor = AnchorStyles.None;
            ManagerIDtextBox.Location = new Point(718, 404);
            ManagerIDtextBox.Name = "ManagerIDtextBox";
            ManagerIDtextBox.ReadOnly = true;
            ManagerIDtextBox.Size = new Size(280, 29);
            ManagerIDtextBox.TabIndex = 175;
            // 
            // ManagerIDlabel
            // 
            ManagerIDlabel.Anchor = AnchorStyles.None;
            ManagerIDlabel.AutoSize = true;
            ManagerIDlabel.Location = new Point(594, 412);
            ManagerIDlabel.Name = "ManagerIDlabel";
            ManagerIDlabel.Size = new Size(107, 21);
            ManagerIDlabel.TabIndex = 174;
            ManagerIDlabel.Text = "Manager ID :";
            // 
            // BranchIDsearchbutton
            // 
            BranchIDsearchbutton.Anchor = AnchorStyles.None;
            BranchIDsearchbutton.Location = new Point(1029, 281);
            BranchIDsearchbutton.Name = "BranchIDsearchbutton";
            BranchIDsearchbutton.Size = new Size(75, 29);
            BranchIDsearchbutton.TabIndex = 173;
            BranchIDsearchbutton.Text = "Search";
            BranchIDsearchbutton.UseVisualStyleBackColor = true;
            // 
            // BranchNametextBox
            // 
            BranchNametextBox.Anchor = AnchorStyles.None;
            BranchNametextBox.Location = new Point(718, 341);
            BranchNametextBox.Name = "BranchNametextBox";
            BranchNametextBox.ReadOnly = true;
            BranchNametextBox.Size = new Size(280, 29);
            BranchNametextBox.TabIndex = 172;
            // 
            // BranchNamelabel
            // 
            BranchNamelabel.Anchor = AnchorStyles.None;
            BranchNamelabel.AutoSize = true;
            BranchNamelabel.Location = new Point(571, 345);
            BranchNamelabel.Name = "BranchNamelabel";
            BranchNamelabel.Size = new Size(120, 21);
            BranchNamelabel.TabIndex = 171;
            BranchNamelabel.Text = "Branch Name :";
            // 
            // BranchIDtextBox
            // 
            BranchIDtextBox.Anchor = AnchorStyles.None;
            BranchIDtextBox.Location = new Point(718, 282);
            BranchIDtextBox.Name = "BranchIDtextBox";
            BranchIDtextBox.Size = new Size(280, 29);
            BranchIDtextBox.TabIndex = 170;
            // 
            // BranchIDlabel
            // 
            BranchIDlabel.Anchor = AnchorStyles.None;
            BranchIDlabel.AutoSize = true;
            BranchIDlabel.Location = new Point(595, 285);
            BranchIDlabel.Name = "BranchIDlabel";
            BranchIDlabel.Size = new Size(96, 21);
            BranchIDlabel.TabIndex = 169;
            BranchIDlabel.Text = "Branch ID :";
            // 
            // IsActivecheckBox
            // 
            IsActivecheckBox.Anchor = AnchorStyles.None;
            IsActivecheckBox.AutoSize = true;
            IsActivecheckBox.Location = new Point(718, 235);
            IsActivecheckBox.Name = "IsActivecheckBox";
            IsActivecheckBox.Size = new Size(95, 25);
            IsActivecheckBox.TabIndex = 168;
            IsActivecheckBox.Text = "Is Active";
            IsActivecheckBox.UseVisualStyleBackColor = true;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.Anchor = AnchorStyles.None;
            PasswordtextBox.Location = new Point(718, 175);
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.PasswordChar = '*';
            PasswordtextBox.ReadOnly = true;
            PasswordtextBox.Size = new Size(280, 29);
            PasswordtextBox.TabIndex = 167;
            // 
            // Passwordlabel
            // 
            Passwordlabel.Anchor = AnchorStyles.None;
            Passwordlabel.AutoSize = true;
            Passwordlabel.Location = new Point(598, 178);
            Passwordlabel.Name = "Passwordlabel";
            Passwordlabel.Size = new Size(93, 21);
            Passwordlabel.TabIndex = 166;
            Passwordlabel.Text = "Password :";
            // 
            // UsernametextBox
            // 
            UsernametextBox.Anchor = AnchorStyles.None;
            UsernametextBox.Location = new Point(718, 118);
            UsernametextBox.Name = "UsernametextBox";
            UsernametextBox.ReadOnly = true;
            UsernametextBox.Size = new Size(280, 29);
            UsernametextBox.TabIndex = 165;
            // 
            // Usernamelabel
            // 
            Usernamelabel.Anchor = AnchorStyles.None;
            Usernamelabel.AutoSize = true;
            Usernamelabel.Location = new Point(598, 121);
            Usernamelabel.Name = "Usernamelabel";
            Usernamelabel.Size = new Size(93, 21);
            Usernamelabel.TabIndex = 164;
            Usernamelabel.Text = "Username :";
            // 
            // AddressrichTextBox
            // 
            AddressrichTextBox.Anchor = AnchorStyles.None;
            AddressrichTextBox.Location = new Point(167, 651);
            AddressrichTextBox.Name = "AddressrichTextBox";
            AddressrichTextBox.ReadOnly = true;
            AddressrichTextBox.Size = new Size(275, 81);
            AddressrichTextBox.TabIndex = 163;
            AddressrichTextBox.Text = "";
            // 
            // FemaleradioButton
            // 
            FemaleradioButton.Anchor = AnchorStyles.None;
            FemaleradioButton.AutoSize = true;
            FemaleradioButton.Location = new Point(285, 290);
            FemaleradioButton.Name = "FemaleradioButton";
            FemaleradioButton.Size = new Size(81, 25);
            FemaleradioButton.TabIndex = 162;
            FemaleradioButton.TabStop = true;
            FemaleradioButton.Text = "Female";
            FemaleradioButton.UseVisualStyleBackColor = true;
            // 
            // MaleradioButton
            // 
            MaleradioButton.Anchor = AnchorStyles.None;
            MaleradioButton.AutoSize = true;
            MaleradioButton.Location = new Point(167, 288);
            MaleradioButton.Name = "MaleradioButton";
            MaleradioButton.Size = new Size(64, 25);
            MaleradioButton.TabIndex = 161;
            MaleradioButton.TabStop = true;
            MaleradioButton.Text = "Male";
            MaleradioButton.UseVisualStyleBackColor = true;
            // 
            // Addresslabel
            // 
            Addresslabel.Anchor = AnchorStyles.None;
            Addresslabel.AutoSize = true;
            Addresslabel.Location = new Point(58, 654);
            Addresslabel.Name = "Addresslabel";
            Addresslabel.Size = new Size(82, 21);
            Addresslabel.TabIndex = 160;
            Addresslabel.Text = "Address :";
            // 
            // EmailtextBox
            // 
            EmailtextBox.Anchor = AnchorStyles.None;
            EmailtextBox.Location = new Point(167, 594);
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.ReadOnly = true;
            EmailtextBox.Size = new Size(280, 29);
            EmailtextBox.TabIndex = 159;
            // 
            // Emaillabel
            // 
            Emaillabel.Anchor = AnchorStyles.None;
            Emaillabel.AutoSize = true;
            Emaillabel.Location = new Point(87, 594);
            Emaillabel.Name = "Emaillabel";
            Emaillabel.Size = new Size(60, 21);
            Emaillabel.TabIndex = 158;
            Emaillabel.Text = "Email :";
            // 
            // PhoneNumbertextBox
            // 
            PhoneNumbertextBox.Anchor = AnchorStyles.None;
            PhoneNumbertextBox.Location = new Point(167, 537);
            PhoneNumbertextBox.Name = "PhoneNumbertextBox";
            PhoneNumbertextBox.ReadOnly = true;
            PhoneNumbertextBox.Size = new Size(280, 29);
            PhoneNumbertextBox.TabIndex = 157;
            // 
            // PhoneNumberlabel
            // 
            PhoneNumberlabel.Anchor = AnchorStyles.None;
            PhoneNumberlabel.AutoSize = true;
            PhoneNumberlabel.Location = new Point(20, 540);
            PhoneNumberlabel.Name = "PhoneNumberlabel";
            PhoneNumberlabel.Size = new Size(131, 21);
            PhoneNumberlabel.TabIndex = 156;
            PhoneNumberlabel.Text = "Phone Number :";
            // 
            // BrowsePhotobutton
            // 
            BrowsePhotobutton.Anchor = AnchorStyles.None;
            BrowsePhotobutton.Location = new Point(352, 416);
            BrowsePhotobutton.Name = "BrowsePhotobutton";
            BrowsePhotobutton.Size = new Size(90, 30);
            BrowsePhotobutton.TabIndex = 155;
            BrowsePhotobutton.Text = "Browse";
            BrowsePhotobutton.UseVisualStyleBackColor = true;
            // 
            // PhotopictureBox
            // 
            PhotopictureBox.Anchor = AnchorStyles.None;
            PhotopictureBox.BorderStyle = BorderStyle.FixedSingle;
            PhotopictureBox.Location = new Point(167, 341);
            PhotopictureBox.Name = "PhotopictureBox";
            PhotopictureBox.Size = new Size(156, 180);
            PhotopictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PhotopictureBox.TabIndex = 154;
            PhotopictureBox.TabStop = false;
            // 
            // Photolabel
            // 
            Photolabel.Anchor = AnchorStyles.None;
            Photolabel.AutoSize = true;
            Photolabel.Location = new Point(87, 416);
            Photolabel.Name = "Photolabel";
            Photolabel.Size = new Size(64, 21);
            Photolabel.TabIndex = 153;
            Photolabel.Text = "Photo :";
            // 
            // Genderlabel
            // 
            Genderlabel.Anchor = AnchorStyles.None;
            Genderlabel.AutoSize = true;
            Genderlabel.Location = new Point(77, 290);
            Genderlabel.Name = "Genderlabel";
            Genderlabel.Size = new Size(74, 21);
            Genderlabel.TabIndex = 152;
            Genderlabel.Text = "Gender :";
            // 
            // DateOfBirthdatePicker
            // 
            DateOfBirthdatePicker.Anchor = AnchorStyles.None;
            DateOfBirthdatePicker.Format = DateTimePickerFormat.Short;
            DateOfBirthdatePicker.Location = new Point(167, 232);
            DateOfBirthdatePicker.Name = "DateOfBirthdatePicker";
            DateOfBirthdatePicker.Size = new Size(280, 29);
            DateOfBirthdatePicker.TabIndex = 151;
            // 
            // DateOfBirthlabel
            // 
            DateOfBirthlabel.Anchor = AnchorStyles.None;
            DateOfBirthlabel.AutoSize = true;
            DateOfBirthlabel.Location = new Point(36, 234);
            DateOfBirthlabel.Name = "DateOfBirthlabel";
            DateOfBirthlabel.Size = new Size(115, 21);
            DateOfBirthlabel.TabIndex = 150;
            DateOfBirthlabel.Text = "Date of Birth :";
            // 
            // FullNametextBox
            // 
            FullNametextBox.Anchor = AnchorStyles.None;
            FullNametextBox.Location = new Point(167, 170);
            FullNametextBox.Name = "FullNametextBox";
            FullNametextBox.Size = new Size(280, 29);
            FullNametextBox.TabIndex = 149;
            // 
            // FullNamelabel
            // 
            FullNamelabel.Anchor = AnchorStyles.None;
            FullNamelabel.AutoSize = true;
            FullNamelabel.Location = new Point(56, 174);
            FullNamelabel.Name = "FullNamelabel";
            FullNamelabel.Size = new Size(95, 21);
            FullNamelabel.TabIndex = 148;
            FullNamelabel.Text = "Full Name :";
            // 
            // UserIDtextBox
            // 
            UserIDtextBox.Anchor = AnchorStyles.None;
            UserIDtextBox.Location = new Point(167, 113);
            UserIDtextBox.Name = "UserIDtextBox";
            UserIDtextBox.ReadOnly = true;
            UserIDtextBox.Size = new Size(280, 29);
            UserIDtextBox.TabIndex = 147;
            // 
            // UserIDlabel
            // 
            UserIDlabel.Anchor = AnchorStyles.None;
            UserIDlabel.AutoSize = true;
            UserIDlabel.Location = new Point(73, 118);
            UserIDlabel.Name = "UserIDlabel";
            UserIDlabel.Size = new Size(78, 21);
            UserIDlabel.TabIndex = 146;
            UserIDlabel.Text = "User ID :";
            // 
            // DeleteManagerGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 777);
            Controls.Add(SearchgroupBox);
            Controls.Add(CanViewBranchReportscheckBox);
            Controls.Add(CanApprovePurchasescheckBox);
            Controls.Add(CanManageInventoryescheckBox);
            Controls.Add(CanManageStuffcheckBox);
            Controls.Add(Cancelbutton);
            Controls.Add(Clearbutton);
            Controls.Add(Savebutton);
            Controls.Add(ManagerTypecomboBox);
            Controls.Add(ManagerTypelabel);
            Controls.Add(ManagerIDtextBox);
            Controls.Add(ManagerIDlabel);
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
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "DeleteManagerGUI";
            Text = "DeleteManagerGUI";
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
        private CheckBox CanViewBranchReportscheckBox;
        private CheckBox CanApprovePurchasescheckBox;
        private CheckBox CanManageInventoryescheckBox;
        private CheckBox CanManageStuffcheckBox;
        private Button Cancelbutton;
        private Button Clearbutton;
        private Button Savebutton;
        private ComboBox ManagerTypecomboBox;
        private Label ManagerTypelabel;
        private TextBox ManagerIDtextBox;
        private Label ManagerIDlabel;
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
    }
}