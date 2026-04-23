namespace SuperMart_Pro.View.Admin
{
    partial class AddAdminGUI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Headerpanel = new Panel();
            UserIDlabel = new Label();
            UserIDtextBox = new TextBox();
            FullNamelabel = new Label();
            FullNametextBox = new TextBox();
            DateOfBirthlabel = new Label();
            DateOfBirthdatePicker = new DateTimePicker();
            Genderlabel = new Label();
            GendercomboBox = new ComboBox();
            Photolabel = new Label();
            PhotopictureBox = new PictureBox();
            BrowsePhotobutton = new Button();
            PhoneNumberlabel = new Label();
            PhoneNumbertextBox = new TextBox();
            Emaillabel = new Label();
            EmailtextBox = new TextBox();
            Addresslabel = new Label();
            AddresstextBox = new TextBox();
            Usernamelabel = new Label();
            UsernametextBox = new TextBox();
            Passwordlabel = new Label();
            PasswordtextBox = new TextBox();
            IsActivecheckBox = new CheckBox();
            BranchIDlabel = new Label();
            BranchIDtextBox = new TextBox();
            BranchNamelabel = new Label();
            BranchNametextBox = new TextBox();
            AdminIDlabel = new Label();
            AdminIDtextBox = new TextBox();
            AdminTypelabel = new Label();
            AdminTypecomboBox = new ComboBox();
            CanManageUserscheckBox = new CheckBox();
            CanManageBranchescheckBox = new CheckBox();
            CanViewReportscheckBox = new CheckBox();
            Savebutton = new Button();
            Clearbutton = new Button();
            Cancelbutton = new Button();
            BranchIDsearchbutton = new Button();
            SecondSecurityAnswerlabel = new Label();
            SecondSecurityAnswertextBox = new TextBox();
            SecondSecurityQuestioncomboBox = new ComboBox();
            SecondSecurityQuestionlalabel = new Label();
            FirstSecurityAnswerlabel = new Label();
            FirstSecurityAnswertextBox = new TextBox();
            FirstSecurityQuestioncomboBox = new ComboBox();
            FirstSecurityQuestionlabel = new Label();
            ((System.ComponentModel.ISupportInitialize)PhotopictureBox).BeginInit();
            SuspendLayout();
            // 
            // Headerpanel
            // 
            Headerpanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Headerpanel.BackColor = Color.Tomato;
            Headerpanel.Location = new Point(0, 0);
            Headerpanel.Name = "Headerpanel";
            Headerpanel.Size = new Size(1231, 85);
            Headerpanel.TabIndex = 0;
            // 
            // UserIDlabel
            // 
            UserIDlabel.Anchor = AnchorStyles.None;
            UserIDlabel.AutoSize = true;
            UserIDlabel.Location = new Point(135, 115);
            UserIDlabel.Name = "UserIDlabel";
            UserIDlabel.Size = new Size(78, 21);
            UserIDlabel.TabIndex = 1;
            UserIDlabel.Text = "User ID :";
            // 
            // UserIDtextBox
            // 
            UserIDtextBox.Anchor = AnchorStyles.None;
            UserIDtextBox.Location = new Point(229, 110);
            UserIDtextBox.Name = "UserIDtextBox";
            UserIDtextBox.Size = new Size(280, 29);
            UserIDtextBox.TabIndex = 2;
            // 
            // FullNamelabel
            // 
            FullNamelabel.Anchor = AnchorStyles.None;
            FullNamelabel.AutoSize = true;
            FullNamelabel.Location = new Point(118, 171);
            FullNamelabel.Name = "FullNamelabel";
            FullNamelabel.Size = new Size(95, 21);
            FullNamelabel.TabIndex = 3;
            FullNamelabel.Text = "Full Name :";
            // 
            // FullNametextBox
            // 
            FullNametextBox.Anchor = AnchorStyles.None;
            FullNametextBox.Location = new Point(229, 167);
            FullNametextBox.Name = "FullNametextBox";
            FullNametextBox.Size = new Size(280, 29);
            FullNametextBox.TabIndex = 4;
            // 
            // DateOfBirthlabel
            // 
            DateOfBirthlabel.Anchor = AnchorStyles.None;
            DateOfBirthlabel.AutoSize = true;
            DateOfBirthlabel.Location = new Point(98, 231);
            DateOfBirthlabel.Name = "DateOfBirthlabel";
            DateOfBirthlabel.Size = new Size(115, 21);
            DateOfBirthlabel.TabIndex = 5;
            DateOfBirthlabel.Text = "Date of Birth :";
            // 
            // DateOfBirthdatePicker
            // 
            DateOfBirthdatePicker.Anchor = AnchorStyles.None;
            DateOfBirthdatePicker.Format = DateTimePickerFormat.Short;
            DateOfBirthdatePicker.Location = new Point(229, 229);
            DateOfBirthdatePicker.Name = "DateOfBirthdatePicker";
            DateOfBirthdatePicker.Size = new Size(280, 29);
            DateOfBirthdatePicker.TabIndex = 6;
            // 
            // Genderlabel
            // 
            Genderlabel.Anchor = AnchorStyles.None;
            Genderlabel.AutoSize = true;
            Genderlabel.Location = new Point(139, 297);
            Genderlabel.Name = "Genderlabel";
            Genderlabel.Size = new Size(74, 21);
            Genderlabel.TabIndex = 7;
            Genderlabel.Text = "Gender :";
            // 
            // GendercomboBox
            // 
            GendercomboBox.Anchor = AnchorStyles.None;
            GendercomboBox.FormattingEnabled = true;
            GendercomboBox.Items.AddRange(new object[] { "Male", "Female", "Other" });
            GendercomboBox.Location = new Point(229, 294);
            GendercomboBox.Name = "GendercomboBox";
            GendercomboBox.Size = new Size(280, 29);
            GendercomboBox.TabIndex = 8;
            // 
            // Photolabel
            // 
            Photolabel.Anchor = AnchorStyles.None;
            Photolabel.AutoSize = true;
            Photolabel.Location = new Point(149, 413);
            Photolabel.Name = "Photolabel";
            Photolabel.Size = new Size(64, 21);
            Photolabel.TabIndex = 9;
            Photolabel.Text = "Photo :";
            // 
            // PhotopictureBox
            // 
            PhotopictureBox.Anchor = AnchorStyles.None;
            PhotopictureBox.BorderStyle = BorderStyle.FixedSingle;
            PhotopictureBox.Location = new Point(229, 338);
            PhotopictureBox.Name = "PhotopictureBox";
            PhotopictureBox.Size = new Size(156, 180);
            PhotopictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PhotopictureBox.TabIndex = 10;
            PhotopictureBox.TabStop = false;
            // 
            // BrowsePhotobutton
            // 
            BrowsePhotobutton.Anchor = AnchorStyles.None;
            BrowsePhotobutton.Location = new Point(414, 413);
            BrowsePhotobutton.Name = "BrowsePhotobutton";
            BrowsePhotobutton.Size = new Size(90, 30);
            BrowsePhotobutton.TabIndex = 11;
            BrowsePhotobutton.Text = "Browse";
            BrowsePhotobutton.UseVisualStyleBackColor = true;
            BrowsePhotobutton.Click += BrowsePhotobutton_Click;
            // 
            // PhoneNumberlabel
            // 
            PhoneNumberlabel.Anchor = AnchorStyles.None;
            PhoneNumberlabel.AutoSize = true;
            PhoneNumberlabel.Location = new Point(82, 537);
            PhoneNumberlabel.Name = "PhoneNumberlabel";
            PhoneNumberlabel.Size = new Size(131, 21);
            PhoneNumberlabel.TabIndex = 12;
            PhoneNumberlabel.Text = "Phone Number :";
            // 
            // PhoneNumbertextBox
            // 
            PhoneNumbertextBox.Anchor = AnchorStyles.None;
            PhoneNumbertextBox.Location = new Point(229, 534);
            PhoneNumbertextBox.Name = "PhoneNumbertextBox";
            PhoneNumbertextBox.Size = new Size(280, 29);
            PhoneNumbertextBox.TabIndex = 13;
            // 
            // Emaillabel
            // 
            Emaillabel.Anchor = AnchorStyles.None;
            Emaillabel.AutoSize = true;
            Emaillabel.Location = new Point(149, 591);
            Emaillabel.Name = "Emaillabel";
            Emaillabel.Size = new Size(60, 21);
            Emaillabel.TabIndex = 14;
            Emaillabel.Text = "Email :";
            // 
            // EmailtextBox
            // 
            EmailtextBox.Anchor = AnchorStyles.None;
            EmailtextBox.Location = new Point(229, 591);
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(280, 29);
            EmailtextBox.TabIndex = 15;
            // 
            // Addresslabel
            // 
            Addresslabel.Anchor = AnchorStyles.None;
            Addresslabel.AutoSize = true;
            Addresslabel.Location = new Point(120, 651);
            Addresslabel.Name = "Addresslabel";
            Addresslabel.Size = new Size(82, 21);
            Addresslabel.TabIndex = 16;
            Addresslabel.Text = "Address :";
            // 
            // AddresstextBox
            // 
            AddresstextBox.Anchor = AnchorStyles.None;
            AddresstextBox.Location = new Point(229, 648);
            AddresstextBox.Name = "AddresstextBox";
            AddresstextBox.Size = new Size(280, 29);
            AddresstextBox.TabIndex = 17;
            // 
            // Usernamelabel
            // 
            Usernamelabel.Anchor = AnchorStyles.None;
            Usernamelabel.AutoSize = true;
            Usernamelabel.Location = new Point(657, 118);
            Usernamelabel.Name = "Usernamelabel";
            Usernamelabel.Size = new Size(93, 21);
            Usernamelabel.TabIndex = 18;
            Usernamelabel.Text = "Username :";
            // 
            // UsernametextBox
            // 
            UsernametextBox.Anchor = AnchorStyles.None;
            UsernametextBox.Location = new Point(777, 115);
            UsernametextBox.Name = "UsernametextBox";
            UsernametextBox.Size = new Size(280, 29);
            UsernametextBox.TabIndex = 19;
            // 
            // Passwordlabel
            // 
            Passwordlabel.Anchor = AnchorStyles.None;
            Passwordlabel.AutoSize = true;
            Passwordlabel.Location = new Point(657, 175);
            Passwordlabel.Name = "Passwordlabel";
            Passwordlabel.Size = new Size(93, 21);
            Passwordlabel.TabIndex = 20;
            Passwordlabel.Text = "Password :";
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.Anchor = AnchorStyles.None;
            PasswordtextBox.Location = new Point(777, 172);
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.PasswordChar = '*';
            PasswordtextBox.Size = new Size(280, 29);
            PasswordtextBox.TabIndex = 21;
            // 
            // IsActivecheckBox
            // 
            IsActivecheckBox.Anchor = AnchorStyles.None;
            IsActivecheckBox.AutoSize = true;
            IsActivecheckBox.Location = new Point(777, 232);
            IsActivecheckBox.Name = "IsActivecheckBox";
            IsActivecheckBox.Size = new Size(95, 25);
            IsActivecheckBox.TabIndex = 22;
            IsActivecheckBox.Text = "Is Active";
            IsActivecheckBox.UseVisualStyleBackColor = true;
            // 
            // BranchIDlabel
            // 
            BranchIDlabel.Anchor = AnchorStyles.None;
            BranchIDlabel.AutoSize = true;
            BranchIDlabel.Location = new Point(654, 282);
            BranchIDlabel.Name = "BranchIDlabel";
            BranchIDlabel.Size = new Size(96, 21);
            BranchIDlabel.TabIndex = 23;
            BranchIDlabel.Text = "Branch ID :";
            // 
            // BranchIDtextBox
            // 
            BranchIDtextBox.Anchor = AnchorStyles.None;
            BranchIDtextBox.Location = new Point(777, 279);
            BranchIDtextBox.Name = "BranchIDtextBox";
            BranchIDtextBox.Size = new Size(280, 29);
            BranchIDtextBox.TabIndex = 24;
            // 
            // BranchNamelabel
            // 
            BranchNamelabel.Anchor = AnchorStyles.None;
            BranchNamelabel.AutoSize = true;
            BranchNamelabel.Location = new Point(630, 344);
            BranchNamelabel.Name = "BranchNamelabel";
            BranchNamelabel.Size = new Size(120, 21);
            BranchNamelabel.TabIndex = 25;
            BranchNamelabel.Text = "Branch Name :";
            // 
            // BranchNametextBox
            // 
            BranchNametextBox.Anchor = AnchorStyles.None;
            BranchNametextBox.Location = new Point(777, 340);
            BranchNametextBox.Name = "BranchNametextBox";
            BranchNametextBox.ReadOnly = true;
            BranchNametextBox.Size = new Size(280, 29);
            BranchNametextBox.TabIndex = 26;
            // 
            // AdminIDlabel
            // 
            AdminIDlabel.Anchor = AnchorStyles.None;
            AdminIDlabel.AutoSize = true;
            AdminIDlabel.Location = new Point(668, 629);
            AdminIDlabel.Name = "AdminIDlabel";
            AdminIDlabel.Size = new Size(93, 21);
            AdminIDlabel.TabIndex = 27;
            AdminIDlabel.Text = "Admin ID :";
            // 
            // AdminIDtextBox
            // 
            AdminIDtextBox.Anchor = AnchorStyles.None;
            AdminIDtextBox.Location = new Point(777, 621);
            AdminIDtextBox.Name = "AdminIDtextBox";
            AdminIDtextBox.Size = new Size(280, 29);
            AdminIDtextBox.TabIndex = 28;
            // 
            // AdminTypelabel
            // 
            AdminTypelabel.Anchor = AnchorStyles.None;
            AdminTypelabel.AutoSize = true;
            AdminTypelabel.Location = new Point(653, 679);
            AdminTypelabel.Name = "AdminTypelabel";
            AdminTypelabel.Size = new Size(112, 21);
            AdminTypelabel.TabIndex = 29;
            AdminTypelabel.Text = "Admin Type :";
            // 
            // AdminTypecomboBox
            // 
            AdminTypecomboBox.Anchor = AnchorStyles.None;
            AdminTypecomboBox.FormattingEnabled = true;
            AdminTypecomboBox.Items.AddRange(new object[] { "Super Admin", "Branch Admin" });
            AdminTypecomboBox.Location = new Point(777, 673);
            AdminTypecomboBox.Name = "AdminTypecomboBox";
            AdminTypecomboBox.Size = new Size(280, 29);
            AdminTypecomboBox.TabIndex = 30;
            // 
            // CanManageUserscheckBox
            // 
            CanManageUserscheckBox.Anchor = AnchorStyles.None;
            CanManageUserscheckBox.AutoSize = true;
            CanManageUserscheckBox.Location = new Point(673, 735);
            CanManageUserscheckBox.Name = "CanManageUserscheckBox";
            CanManageUserscheckBox.Size = new Size(170, 25);
            CanManageUserscheckBox.TabIndex = 31;
            CanManageUserscheckBox.Text = "Can Manage Users";
            CanManageUserscheckBox.UseVisualStyleBackColor = true;
            // 
            // CanManageBranchescheckBox
            // 
            CanManageBranchescheckBox.Anchor = AnchorStyles.None;
            CanManageBranchescheckBox.AutoSize = true;
            CanManageBranchescheckBox.Location = new Point(849, 735);
            CanManageBranchescheckBox.Name = "CanManageBranchescheckBox";
            CanManageBranchescheckBox.Size = new Size(196, 25);
            CanManageBranchescheckBox.TabIndex = 32;
            CanManageBranchescheckBox.Text = "Can Manage Branches";
            CanManageBranchescheckBox.UseVisualStyleBackColor = true;
            // 
            // CanViewReportscheckBox
            // 
            CanViewReportscheckBox.Anchor = AnchorStyles.None;
            CanViewReportscheckBox.AutoSize = true;
            CanViewReportscheckBox.Location = new Point(1051, 735);
            CanViewReportscheckBox.Name = "CanViewReportscheckBox";
            CanViewReportscheckBox.Size = new Size(166, 25);
            CanViewReportscheckBox.TabIndex = 33;
            CanViewReportscheckBox.Text = "Can View Reports";
            CanViewReportscheckBox.UseVisualStyleBackColor = true;
            // 
            // Savebutton
            // 
            Savebutton.Anchor = AnchorStyles.None;
            Savebutton.BackColor = Color.OliveDrab;
            Savebutton.ForeColor = Color.White;
            Savebutton.Location = new Point(389, 790);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(124, 41);
            Savebutton.TabIndex = 34;
            Savebutton.Text = "Save";
            Savebutton.UseVisualStyleBackColor = false;
            Savebutton.Click += Savebutton_Click;
            // 
            // Clearbutton
            // 
            Clearbutton.Anchor = AnchorStyles.None;
            Clearbutton.BackColor = Color.Tan;
            Clearbutton.Location = new Point(542, 790);
            Clearbutton.Name = "Clearbutton";
            Clearbutton.Size = new Size(124, 41);
            Clearbutton.TabIndex = 35;
            Clearbutton.Text = "Clear";
            Clearbutton.UseVisualStyleBackColor = false;
            Clearbutton.Click += Clearbutton_Click;
            // 
            // Cancelbutton
            // 
            Cancelbutton.Anchor = AnchorStyles.None;
            Cancelbutton.BackColor = Color.Red;
            Cancelbutton.ForeColor = Color.White;
            Cancelbutton.Location = new Point(695, 790);
            Cancelbutton.Name = "Cancelbutton";
            Cancelbutton.Size = new Size(124, 41);
            Cancelbutton.TabIndex = 36;
            Cancelbutton.Text = "Cancel";
            Cancelbutton.UseVisualStyleBackColor = false;
            Cancelbutton.Click += Cancelbutton_Click;
            // 
            // BranchIDsearchbutton
            // 
            BranchIDsearchbutton.Anchor = AnchorStyles.None;
            BranchIDsearchbutton.Location = new Point(1091, 279);
            BranchIDsearchbutton.Name = "BranchIDsearchbutton";
            BranchIDsearchbutton.Size = new Size(75, 29);
            BranchIDsearchbutton.TabIndex = 37;
            BranchIDsearchbutton.Text = "Search";
            BranchIDsearchbutton.UseVisualStyleBackColor = true;
            // 
            // SecondSecurityAnswerlabel
            // 
            SecondSecurityAnswerlabel.Anchor = AnchorStyles.None;
            SecondSecurityAnswerlabel.AutoSize = true;
            SecondSecurityAnswerlabel.Location = new Point(559, 572);
            SecondSecurityAnswerlabel.Name = "SecondSecurityAnswerlabel";
            SecondSecurityAnswerlabel.Size = new Size(203, 21);
            SecondSecurityAnswerlabel.TabIndex = 45;
            SecondSecurityAnswerlabel.Text = "Second Security Answer :";
            // 
            // SecondSecurityAnswertextBox
            // 
            SecondSecurityAnswertextBox.Anchor = AnchorStyles.None;
            SecondSecurityAnswertextBox.Location = new Point(777, 569);
            SecondSecurityAnswertextBox.Name = "SecondSecurityAnswertextBox";
            SecondSecurityAnswertextBox.Size = new Size(280, 29);
            SecondSecurityAnswertextBox.TabIndex = 44;
            // 
            // SecondSecurityQuestioncomboBox
            // 
            SecondSecurityQuestioncomboBox.Anchor = AnchorStyles.None;
            SecondSecurityQuestioncomboBox.FormattingEnabled = true;
            SecondSecurityQuestioncomboBox.Items.AddRange(new object[] { "What was the name of your first school?", "", "In which city or village were you born?", "", "What is the name of your childhood best friend?", "What was your first pet’s name?", "", "What is your favorite teacher’s name?", "", "What was the model of your first mobile phone?", "", "What is your mother’s middle name?", "", "What is the name of the street you grew up on?", "", "What is your favorite book or movie from childhood?", "", "What was your dream job as a child?" });
            SecondSecurityQuestioncomboBox.Location = new Point(777, 511);
            SecondSecurityQuestioncomboBox.Name = "SecondSecurityQuestioncomboBox";
            SecondSecurityQuestioncomboBox.Size = new Size(280, 29);
            SecondSecurityQuestioncomboBox.TabIndex = 43;
            // 
            // SecondSecurityQuestionlalabel
            // 
            SecondSecurityQuestionlalabel.Anchor = AnchorStyles.None;
            SecondSecurityQuestionlalabel.AutoSize = true;
            SecondSecurityQuestionlalabel.Location = new Point(547, 515);
            SecondSecurityQuestionlalabel.Name = "SecondSecurityQuestionlalabel";
            SecondSecurityQuestionlalabel.Size = new Size(214, 21);
            SecondSecurityQuestionlalabel.TabIndex = 42;
            SecondSecurityQuestionlalabel.Text = "Second Security Question :";
            // 
            // FirstSecurityAnswerlabel
            // 
            FirstSecurityAnswerlabel.Anchor = AnchorStyles.None;
            FirstSecurityAnswerlabel.AutoSize = true;
            FirstSecurityAnswerlabel.Location = new Point(581, 458);
            FirstSecurityAnswerlabel.Name = "FirstSecurityAnswerlabel";
            FirstSecurityAnswerlabel.Size = new Size(180, 21);
            FirstSecurityAnswerlabel.TabIndex = 41;
            FirstSecurityAnswerlabel.Text = "First Security Answer :";
            // 
            // FirstSecurityAnswertextBox
            // 
            FirstSecurityAnswertextBox.Anchor = AnchorStyles.None;
            FirstSecurityAnswertextBox.Location = new Point(777, 453);
            FirstSecurityAnswertextBox.Name = "FirstSecurityAnswertextBox";
            FirstSecurityAnswertextBox.Size = new Size(280, 29);
            FirstSecurityAnswertextBox.TabIndex = 40;
            // 
            // FirstSecurityQuestioncomboBox
            // 
            FirstSecurityQuestioncomboBox.Anchor = AnchorStyles.None;
            FirstSecurityQuestioncomboBox.FormattingEnabled = true;
            FirstSecurityQuestioncomboBox.Items.AddRange(new object[] { "What was the name of your first school?", "", "In which city or village were you born?", "", "What is the name of your childhood best friend?", "What was your first pet’s name?", "", "What is your favorite teacher’s name?", "", "What was the model of your first mobile phone?", "", "What is your mother’s middle name?", "", "What is the name of the street you grew up on?", "", "What is your favorite book or movie from childhood?", "", "What was your dream job as a child?" });
            FirstSecurityQuestioncomboBox.Location = new Point(777, 395);
            FirstSecurityQuestioncomboBox.Name = "FirstSecurityQuestioncomboBox";
            FirstSecurityQuestioncomboBox.Size = new Size(280, 29);
            FirstSecurityQuestioncomboBox.TabIndex = 39;
            // 
            // FirstSecurityQuestionlabel
            // 
            FirstSecurityQuestionlabel.Anchor = AnchorStyles.None;
            FirstSecurityQuestionlabel.AutoSize = true;
            FirstSecurityQuestionlabel.Location = new Point(570, 400);
            FirstSecurityQuestionlabel.Name = "FirstSecurityQuestionlabel";
            FirstSecurityQuestionlabel.Size = new Size(191, 21);
            FirstSecurityQuestionlabel.TabIndex = 38;
            FirstSecurityQuestionlabel.Text = "First Security Question :";
            // 
            // AddAdminGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 858);
            Controls.Add(SecondSecurityAnswerlabel);
            Controls.Add(SecondSecurityAnswertextBox);
            Controls.Add(SecondSecurityQuestioncomboBox);
            Controls.Add(SecondSecurityQuestionlalabel);
            Controls.Add(FirstSecurityAnswerlabel);
            Controls.Add(FirstSecurityAnswertextBox);
            Controls.Add(FirstSecurityQuestioncomboBox);
            Controls.Add(FirstSecurityQuestionlabel);
            Controls.Add(BranchIDsearchbutton);
            Controls.Add(Cancelbutton);
            Controls.Add(Clearbutton);
            Controls.Add(Savebutton);
            Controls.Add(CanViewReportscheckBox);
            Controls.Add(CanManageBranchescheckBox);
            Controls.Add(CanManageUserscheckBox);
            Controls.Add(AdminTypecomboBox);
            Controls.Add(AdminTypelabel);
            Controls.Add(AdminIDtextBox);
            Controls.Add(AdminIDlabel);
            Controls.Add(BranchNametextBox);
            Controls.Add(BranchNamelabel);
            Controls.Add(BranchIDtextBox);
            Controls.Add(BranchIDlabel);
            Controls.Add(IsActivecheckBox);
            Controls.Add(PasswordtextBox);
            Controls.Add(Passwordlabel);
            Controls.Add(UsernametextBox);
            Controls.Add(Usernamelabel);
            Controls.Add(AddresstextBox);
            Controls.Add(Addresslabel);
            Controls.Add(EmailtextBox);
            Controls.Add(Emaillabel);
            Controls.Add(PhoneNumbertextBox);
            Controls.Add(PhoneNumberlabel);
            Controls.Add(BrowsePhotobutton);
            Controls.Add(PhotopictureBox);
            Controls.Add(Photolabel);
            Controls.Add(GendercomboBox);
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
            Name = "AddAdminGUI";
            Text = "Add Admin";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)PhotopictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Headerpanel;
        private Label UserIDlabel;
        private TextBox UserIDtextBox;
        private Label FullNamelabel;
        private TextBox FullNametextBox;
        private Label DateOfBirthlabel;
        private DateTimePicker DateOfBirthdatePicker;
        private Label Genderlabel;
        private ComboBox GendercomboBox;
        private Label Photolabel;
        private PictureBox PhotopictureBox;
        private Button BrowsePhotobutton;
        private Label PhoneNumberlabel;
        private TextBox PhoneNumbertextBox;
        private Label Emaillabel;
        private TextBox EmailtextBox;
        private Label Addresslabel;
        private TextBox AddresstextBox;
        private Label Usernamelabel;
        private TextBox UsernametextBox;
        private Label Passwordlabel;
        private TextBox PasswordtextBox;
        private CheckBox IsActivecheckBox;
        private Label BranchIDlabel;
        private TextBox BranchIDtextBox;
        private Label BranchNamelabel;
        private TextBox BranchNametextBox;
        private Label AdminIDlabel;
        private TextBox AdminIDtextBox;
        private Label AdminTypelabel;
        private ComboBox AdminTypecomboBox;
        private CheckBox CanManageUserscheckBox;
        private CheckBox CanManageBranchescheckBox;
        private CheckBox CanViewReportscheckBox;
        private Button Savebutton;
        private Button Clearbutton;
        private Button Cancelbutton;
        private Button BranchIDsearchbutton;
        private Label SecondSecurityAnswerlabel;
        private TextBox SecondSecurityAnswertextBox;
        private ComboBox SecondSecurityQuestioncomboBox;
        private Label SecondSecurityQuestionlalabel;
        private Label FirstSecurityAnswerlabel;
        private TextBox FirstSecurityAnswertextBox;
        private ComboBox FirstSecurityQuestioncomboBox;
        private Label FirstSecurityQuestionlabel;
    }
}
