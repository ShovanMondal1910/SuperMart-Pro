namespace SuperMart_Pro.View.Branch
{
    partial class AddBranchGUI
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
            BranchIDlabel = new Label();
            BranchIDtextBox = new TextBox();
            BranchNamelabel = new Label();
            BranchNametextBox = new TextBox();
            BranchTypelabel = new Label();
            BranchTypecomboBox = new ComboBox();
            BranchAddresslabel = new Label();
            BranchAddresstextBox = new TextBox();
            BranchZiplabel = new Label();
            BranchZiptextBox = new TextBox();
            BranchPhonelabel = new Label();
            BranchPhonetextBox = new TextBox();
            BranchEmaillabel = new Label();
            BranchEmailtextBox = new TextBox();
            ManagerIDlabel = new Label();
            ManagerIDtextBox = new TextBox();
            IsActivecheckBox = new CheckBox();
            Savebutton = new Button();
            Clearbutton = new Button();
            Cancelbutton = new Button();
            BranchIDErrorlabel = new Label();
            BranchNameErrorlabel = new Label();
            BranchTypeErrorlabel = new Label();
            BranchAddressErrorlabel = new Label();
            BranchZipErrorlabel = new Label();
            BranchPhoneErrorlabel = new Label();
            BranchEmailErrorlabel = new Label();
            BranchManagerIDErrorlabel = new Label();
            SuspendLayout();
            // 
            // Headerpanel
            // 
            Headerpanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Headerpanel.BackColor = Color.Tomato;
            Headerpanel.Location = new Point(0, 0);
            Headerpanel.Name = "Headerpanel";
            Headerpanel.Size = new Size(851, 85);
            Headerpanel.TabIndex = 0;
            // 
            // BranchIDlabel
            // 
            BranchIDlabel.Anchor = AnchorStyles.None;
            BranchIDlabel.AutoSize = true;
            BranchIDlabel.Location = new Point(226, 118);
            BranchIDlabel.Name = "BranchIDlabel";
            BranchIDlabel.Size = new Size(96, 21);
            BranchIDlabel.TabIndex = 1;
            BranchIDlabel.Text = "Branch ID :";
            // 
            // BranchIDtextBox
            // 
            BranchIDtextBox.Anchor = AnchorStyles.None;
            BranchIDtextBox.Location = new Point(342, 115);
            BranchIDtextBox.Name = "BranchIDtextBox";
            BranchIDtextBox.Size = new Size(273, 29);
            BranchIDtextBox.TabIndex = 2;
            // 
            // BranchNamelabel
            // 
            BranchNamelabel.Anchor = AnchorStyles.None;
            BranchNamelabel.AutoSize = true;
            BranchNamelabel.Location = new Point(202, 180);
            BranchNamelabel.Name = "BranchNamelabel";
            BranchNamelabel.Size = new Size(120, 21);
            BranchNamelabel.TabIndex = 3;
            BranchNamelabel.Text = "Branch Name :";
            // 
            // BranchNametextBox
            // 
            BranchNametextBox.Anchor = AnchorStyles.None;
            BranchNametextBox.Location = new Point(342, 177);
            BranchNametextBox.Name = "BranchNametextBox";
            BranchNametextBox.Size = new Size(273, 29);
            BranchNametextBox.TabIndex = 4;
            // 
            // BranchTypelabel
            // 
            BranchTypelabel.Anchor = AnchorStyles.None;
            BranchTypelabel.AutoSize = true;
            BranchTypelabel.Location = new Point(207, 243);
            BranchTypelabel.Name = "BranchTypelabel";
            BranchTypelabel.Size = new Size(115, 21);
            BranchTypelabel.TabIndex = 5;
            BranchTypelabel.Text = "Branch Type :";
            // 
            // BranchTypecomboBox
            // 
            BranchTypecomboBox.Anchor = AnchorStyles.None;
            BranchTypecomboBox.FormattingEnabled = true;
            BranchTypecomboBox.Items.AddRange(new object[] { "Main", "Sub", "Warehouse", "Outlet" });
            BranchTypecomboBox.Location = new Point(342, 240);
            BranchTypecomboBox.Name = "BranchTypecomboBox";
            BranchTypecomboBox.Size = new Size(273, 29);
            BranchTypecomboBox.TabIndex = 6;
            // 
            // BranchAddresslabel
            // 
            BranchAddresslabel.Anchor = AnchorStyles.None;
            BranchAddresslabel.AutoSize = true;
            BranchAddresslabel.Location = new Point(185, 308);
            BranchAddresslabel.Name = "BranchAddresslabel";
            BranchAddresslabel.Size = new Size(139, 21);
            BranchAddresslabel.TabIndex = 7;
            BranchAddresslabel.Text = "Branch Address :";
            // 
            // BranchAddresstextBox
            // 
            BranchAddresstextBox.Anchor = AnchorStyles.None;
            BranchAddresstextBox.Location = new Point(342, 305);
            BranchAddresstextBox.Name = "BranchAddresstextBox";
            BranchAddresstextBox.Size = new Size(273, 29);
            BranchAddresstextBox.TabIndex = 8;
            // 
            // BranchZiplabel
            // 
            BranchZiplabel.Anchor = AnchorStyles.None;
            BranchZiplabel.AutoSize = true;
            BranchZiplabel.Location = new Point(222, 373);
            BranchZiplabel.Name = "BranchZiplabel";
            BranchZiplabel.Size = new Size(102, 21);
            BranchZiplabel.TabIndex = 9;
            BranchZiplabel.Text = "Branch Zip :";
            // 
            // BranchZiptextBox
            // 
            BranchZiptextBox.Anchor = AnchorStyles.None;
            BranchZiptextBox.Location = new Point(342, 370);
            BranchZiptextBox.Name = "BranchZiptextBox";
            BranchZiptextBox.Size = new Size(273, 29);
            BranchZiptextBox.TabIndex = 10;
            // 
            // BranchPhonelabel
            // 
            BranchPhonelabel.Anchor = AnchorStyles.None;
            BranchPhonelabel.AutoSize = true;
            BranchPhonelabel.Location = new Point(196, 438);
            BranchPhonelabel.Name = "BranchPhonelabel";
            BranchPhonelabel.Size = new Size(124, 21);
            BranchPhonelabel.TabIndex = 11;
            BranchPhonelabel.Text = "Branch Phone :";
            // 
            // BranchPhonetextBox
            // 
            BranchPhonetextBox.Anchor = AnchorStyles.None;
            BranchPhonetextBox.Location = new Point(342, 435);
            BranchPhonetextBox.Name = "BranchPhonetextBox";
            BranchPhonetextBox.Size = new Size(273, 29);
            BranchPhonetextBox.TabIndex = 12;
            // 
            // BranchEmaillabel
            // 
            BranchEmaillabel.Anchor = AnchorStyles.None;
            BranchEmaillabel.AutoSize = true;
            BranchEmaillabel.Location = new Point(204, 503);
            BranchEmaillabel.Name = "BranchEmaillabel";
            BranchEmaillabel.Size = new Size(118, 21);
            BranchEmaillabel.TabIndex = 13;
            BranchEmaillabel.Text = "Branch Email :";
            // 
            // BranchEmailtextBox
            // 
            BranchEmailtextBox.Anchor = AnchorStyles.None;
            BranchEmailtextBox.Location = new Point(342, 500);
            BranchEmailtextBox.Name = "BranchEmailtextBox";
            BranchEmailtextBox.Size = new Size(273, 29);
            BranchEmailtextBox.TabIndex = 14;
            // 
            // ManagerIDlabel
            // 
            ManagerIDlabel.Anchor = AnchorStyles.None;
            ManagerIDlabel.AutoSize = true;
            ManagerIDlabel.Location = new Point(213, 572);
            ManagerIDlabel.Name = "ManagerIDlabel";
            ManagerIDlabel.Size = new Size(107, 21);
            ManagerIDlabel.TabIndex = 15;
            ManagerIDlabel.Text = "Manager ID :";
            // 
            // ManagerIDtextBox
            // 
            ManagerIDtextBox.Anchor = AnchorStyles.None;
            ManagerIDtextBox.Location = new Point(342, 569);
            ManagerIDtextBox.Name = "ManagerIDtextBox";
            ManagerIDtextBox.Size = new Size(273, 29);
            ManagerIDtextBox.TabIndex = 16;
            // 
            // IsActivecheckBox
            // 
            IsActivecheckBox.Anchor = AnchorStyles.None;
            IsActivecheckBox.AutoSize = true;
            IsActivecheckBox.Location = new Point(342, 649);
            IsActivecheckBox.Name = "IsActivecheckBox";
            IsActivecheckBox.Size = new Size(95, 25);
            IsActivecheckBox.TabIndex = 17;
            IsActivecheckBox.Text = "Is Active";
            IsActivecheckBox.UseVisualStyleBackColor = true;
            // 
            // Savebutton
            // 
            Savebutton.Anchor = AnchorStyles.None;
            Savebutton.BackColor = Color.OliveDrab;
            Savebutton.ForeColor = Color.White;
            Savebutton.Location = new Point(181, 704);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(124, 41);
            Savebutton.TabIndex = 18;
            Savebutton.Text = "Save";
            Savebutton.UseVisualStyleBackColor = false;
            Savebutton.Click += Savebutton_Click;
            // 
            // Clearbutton
            // 
            Clearbutton.Anchor = AnchorStyles.None;
            Clearbutton.BackColor = Color.Tan;
            Clearbutton.Location = new Point(336, 704);
            Clearbutton.Name = "Clearbutton";
            Clearbutton.Size = new Size(124, 41);
            Clearbutton.TabIndex = 19;
            Clearbutton.Text = "Clear";
            Clearbutton.UseVisualStyleBackColor = false;
            Clearbutton.Click += Clearbutton_Click;
            // 
            // Cancelbutton
            // 
            Cancelbutton.Anchor = AnchorStyles.None;
            Cancelbutton.BackColor = Color.Red;
            Cancelbutton.ForeColor = Color.White;
            Cancelbutton.Location = new Point(491, 704);
            Cancelbutton.Name = "Cancelbutton";
            Cancelbutton.Size = new Size(124, 41);
            Cancelbutton.TabIndex = 20;
            Cancelbutton.Text = "Cancel";
            Cancelbutton.UseVisualStyleBackColor = false;
            Cancelbutton.Click += Cancelbutton_Click;
            // 
            // BranchIDErrorlabel
            // 
            BranchIDErrorlabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BranchIDErrorlabel.AutoSize = true;
            BranchIDErrorlabel.Location = new Point(342, 147);
            BranchIDErrorlabel.Name = "BranchIDErrorlabel";
            BranchIDErrorlabel.Size = new Size(0, 21);
            BranchIDErrorlabel.TabIndex = 21;
            // 
            // BranchNameErrorlabel
            // 
            BranchNameErrorlabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BranchNameErrorlabel.AutoSize = true;
            BranchNameErrorlabel.Location = new Point(342, 209);
            BranchNameErrorlabel.Name = "BranchNameErrorlabel";
            BranchNameErrorlabel.Size = new Size(0, 21);
            BranchNameErrorlabel.TabIndex = 22;
            // 
            // BranchTypeErrorlabel
            // 
            BranchTypeErrorlabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BranchTypeErrorlabel.AutoSize = true;
            BranchTypeErrorlabel.Location = new Point(342, 272);
            BranchTypeErrorlabel.Name = "BranchTypeErrorlabel";
            BranchTypeErrorlabel.Size = new Size(0, 21);
            BranchTypeErrorlabel.TabIndex = 23;
            // 
            // BranchAddressErrorlabel
            // 
            BranchAddressErrorlabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BranchAddressErrorlabel.AutoSize = true;
            BranchAddressErrorlabel.Location = new Point(342, 337);
            BranchAddressErrorlabel.Name = "BranchAddressErrorlabel";
            BranchAddressErrorlabel.Size = new Size(0, 21);
            BranchAddressErrorlabel.TabIndex = 24;
            // 
            // BranchZipErrorlabel
            // 
            BranchZipErrorlabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BranchZipErrorlabel.AutoSize = true;
            BranchZipErrorlabel.Location = new Point(342, 402);
            BranchZipErrorlabel.Name = "BranchZipErrorlabel";
            BranchZipErrorlabel.Size = new Size(0, 21);
            BranchZipErrorlabel.TabIndex = 25;
            // 
            // BranchPhoneErrorlabel
            // 
            BranchPhoneErrorlabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BranchPhoneErrorlabel.AutoSize = true;
            BranchPhoneErrorlabel.Location = new Point(342, 467);
            BranchPhoneErrorlabel.Name = "BranchPhoneErrorlabel";
            BranchPhoneErrorlabel.Size = new Size(0, 21);
            BranchPhoneErrorlabel.TabIndex = 26;
            // 
            // BranchEmailErrorlabel
            // 
            BranchEmailErrorlabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BranchEmailErrorlabel.AutoSize = true;
            BranchEmailErrorlabel.Location = new Point(342, 532);
            BranchEmailErrorlabel.Name = "BranchEmailErrorlabel";
            BranchEmailErrorlabel.Size = new Size(0, 21);
            BranchEmailErrorlabel.TabIndex = 27;
            // 
            // BranchManagerIDErrorlabel
            // 
            BranchManagerIDErrorlabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BranchManagerIDErrorlabel.AutoSize = true;
            BranchManagerIDErrorlabel.Location = new Point(342, 601);
            BranchManagerIDErrorlabel.Name = "BranchManagerIDErrorlabel";
            BranchManagerIDErrorlabel.Size = new Size(0, 21);
            BranchManagerIDErrorlabel.TabIndex = 28;
            // 
            // AddBranchGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 768);
            Controls.Add(BranchManagerIDErrorlabel);
            Controls.Add(BranchEmailErrorlabel);
            Controls.Add(BranchPhoneErrorlabel);
            Controls.Add(BranchZipErrorlabel);
            Controls.Add(BranchAddressErrorlabel);
            Controls.Add(BranchTypeErrorlabel);
            Controls.Add(BranchNameErrorlabel);
            Controls.Add(BranchIDErrorlabel);
            Controls.Add(Cancelbutton);
            Controls.Add(Clearbutton);
            Controls.Add(Savebutton);
            Controls.Add(IsActivecheckBox);
            Controls.Add(ManagerIDtextBox);
            Controls.Add(ManagerIDlabel);
            Controls.Add(BranchEmailtextBox);
            Controls.Add(BranchEmaillabel);
            Controls.Add(BranchPhonetextBox);
            Controls.Add(BranchPhonelabel);
            Controls.Add(BranchZiptextBox);
            Controls.Add(BranchZiplabel);
            Controls.Add(BranchAddresstextBox);
            Controls.Add(BranchAddresslabel);
            Controls.Add(BranchTypecomboBox);
            Controls.Add(BranchTypelabel);
            Controls.Add(BranchNametextBox);
            Controls.Add(BranchNamelabel);
            Controls.Add(BranchIDtextBox);
            Controls.Add(BranchIDlabel);
            Controls.Add(Headerpanel);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AddBranchGUI";
            Text = "Add Branch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Headerpanel;
        private Label BranchIDlabel;
        private TextBox BranchIDtextBox;
        private Label BranchNamelabel;
        private TextBox BranchNametextBox;
        private Label BranchTypelabel;
        private ComboBox BranchTypecomboBox;
        private Label BranchAddresslabel;
        private TextBox BranchAddresstextBox;
        private Label BranchZiplabel;
        private TextBox BranchZiptextBox;
        private Label BranchPhonelabel;
        private TextBox BranchPhonetextBox;
        private Label BranchEmaillabel;
        private TextBox BranchEmailtextBox;
        private Label ManagerIDlabel;
        private TextBox ManagerIDtextBox;
        private CheckBox IsActivecheckBox;
        private Button Savebutton;
        private Button Clearbutton;
        private Button Cancelbutton;
        private Label BranchIDErrorlabel;
        private Label BranchNameErrorlabel;
        private Label BranchTypeErrorlabel;
        private Label BranchAddressErrorlabel;
        private Label BranchZipErrorlabel;
        private Label BranchPhoneErrorlabel;
        private Label BranchEmailErrorlabel;
        private Label BranchManagerIDErrorlabel;
    }
}
