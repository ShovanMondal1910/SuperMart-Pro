namespace SuperMart_Pro.View.Branch
{
    partial class DeleteBranchGUI
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
            SearchgroupBox = new GroupBox();
            Searchbutton = new Button();
            SearchtextBox = new TextBox();
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
            Deletebutton = new Button();
            Clearbutton = new Button();
            Cancelbutton = new Button();
            SearchgroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SearchgroupBox
            // 
            SearchgroupBox.Anchor = AnchorStyles.None;
            SearchgroupBox.Controls.Add(Searchbutton);
            SearchgroupBox.Controls.Add(SearchtextBox);
            SearchgroupBox.Location = new Point(95, 27);
            SearchgroupBox.Name = "SearchgroupBox";
            SearchgroupBox.Size = new Size(441, 80);
            SearchgroupBox.TabIndex = 1;
            SearchgroupBox.TabStop = false;
            SearchgroupBox.Text = "Search Branch";
            // 
            // Searchbutton
            // 
            Searchbutton.Location = new Point(341, 28);
            Searchbutton.Name = "Searchbutton";
            Searchbutton.Size = new Size(75, 33);
            Searchbutton.TabIndex = 1;
            Searchbutton.Text = "Search";
            Searchbutton.UseVisualStyleBackColor = true;
            Searchbutton.Click += Searchbutton_Click;
            // 
            // SearchtextBox
            // 
            SearchtextBox.Location = new Point(45, 28);
            SearchtextBox.Name = "SearchtextBox";
            SearchtextBox.Size = new Size(263, 29);
            SearchtextBox.TabIndex = 0;
            // 
            // BranchIDlabel
            // 
            BranchIDlabel.Anchor = AnchorStyles.None;
            BranchIDlabel.AutoSize = true;
            BranchIDlabel.Location = new Point(143, 134);
            BranchIDlabel.Name = "BranchIDlabel";
            BranchIDlabel.Size = new Size(96, 21);
            BranchIDlabel.TabIndex = 2;
            BranchIDlabel.Text = "Branch ID :";
            // 
            // BranchIDtextBox
            // 
            BranchIDtextBox.Anchor = AnchorStyles.None;
            BranchIDtextBox.Location = new Point(259, 131);
            BranchIDtextBox.Name = "BranchIDtextBox";
            BranchIDtextBox.ReadOnly = true;
            BranchIDtextBox.Size = new Size(273, 29);
            BranchIDtextBox.TabIndex = 3;
            // 
            // BranchNamelabel
            // 
            BranchNamelabel.Anchor = AnchorStyles.None;
            BranchNamelabel.AutoSize = true;
            BranchNamelabel.Location = new Point(119, 182);
            BranchNamelabel.Name = "BranchNamelabel";
            BranchNamelabel.Size = new Size(120, 21);
            BranchNamelabel.TabIndex = 4;
            BranchNamelabel.Text = "Branch Name :";
            // 
            // BranchNametextBox
            // 
            BranchNametextBox.Anchor = AnchorStyles.None;
            BranchNametextBox.Location = new Point(259, 179);
            BranchNametextBox.Name = "BranchNametextBox";
            BranchNametextBox.ReadOnly = true;
            BranchNametextBox.Size = new Size(273, 29);
            BranchNametextBox.TabIndex = 5;
            // 
            // BranchTypelabel
            // 
            BranchTypelabel.Anchor = AnchorStyles.None;
            BranchTypelabel.AutoSize = true;
            BranchTypelabel.Location = new Point(124, 231);
            BranchTypelabel.Name = "BranchTypelabel";
            BranchTypelabel.Size = new Size(115, 21);
            BranchTypelabel.TabIndex = 6;
            BranchTypelabel.Text = "Branch Type :";
            // 
            // BranchTypecomboBox
            // 
            BranchTypecomboBox.Anchor = AnchorStyles.None;
            BranchTypecomboBox.Enabled = false;
            BranchTypecomboBox.FormattingEnabled = true;
            BranchTypecomboBox.Items.AddRange(new object[] { "Main", "Sub", "Warehouse", "Outlet" });
            BranchTypecomboBox.Location = new Point(259, 228);
            BranchTypecomboBox.Name = "BranchTypecomboBox";
            BranchTypecomboBox.Size = new Size(273, 29);
            BranchTypecomboBox.TabIndex = 7;
            // 
            // BranchAddresslabel
            // 
            BranchAddresslabel.Anchor = AnchorStyles.None;
            BranchAddresslabel.AutoSize = true;
            BranchAddresslabel.Location = new Point(102, 280);
            BranchAddresslabel.Name = "BranchAddresslabel";
            BranchAddresslabel.Size = new Size(139, 21);
            BranchAddresslabel.TabIndex = 8;
            BranchAddresslabel.Text = "Branch Address :";
            // 
            // BranchAddresstextBox
            // 
            BranchAddresstextBox.Anchor = AnchorStyles.None;
            BranchAddresstextBox.Location = new Point(259, 277);
            BranchAddresstextBox.Name = "BranchAddresstextBox";
            BranchAddresstextBox.ReadOnly = true;
            BranchAddresstextBox.Size = new Size(273, 29);
            BranchAddresstextBox.TabIndex = 9;
            // 
            // BranchZiplabel
            // 
            BranchZiplabel.Anchor = AnchorStyles.None;
            BranchZiplabel.AutoSize = true;
            BranchZiplabel.Location = new Point(139, 329);
            BranchZiplabel.Name = "BranchZiplabel";
            BranchZiplabel.Size = new Size(102, 21);
            BranchZiplabel.TabIndex = 10;
            BranchZiplabel.Text = "Branch Zip :";
            // 
            // BranchZiptextBox
            // 
            BranchZiptextBox.Anchor = AnchorStyles.None;
            BranchZiptextBox.Location = new Point(259, 326);
            BranchZiptextBox.Name = "BranchZiptextBox";
            BranchZiptextBox.ReadOnly = true;
            BranchZiptextBox.Size = new Size(273, 29);
            BranchZiptextBox.TabIndex = 11;
            // 
            // BranchPhonelabel
            // 
            BranchPhonelabel.Anchor = AnchorStyles.None;
            BranchPhonelabel.AutoSize = true;
            BranchPhonelabel.Location = new Point(113, 378);
            BranchPhonelabel.Name = "BranchPhonelabel";
            BranchPhonelabel.Size = new Size(124, 21);
            BranchPhonelabel.TabIndex = 12;
            BranchPhonelabel.Text = "Branch Phone :";
            // 
            // BranchPhonetextBox
            // 
            BranchPhonetextBox.Anchor = AnchorStyles.None;
            BranchPhonetextBox.Location = new Point(259, 375);
            BranchPhonetextBox.Name = "BranchPhonetextBox";
            BranchPhonetextBox.ReadOnly = true;
            BranchPhonetextBox.Size = new Size(273, 29);
            BranchPhonetextBox.TabIndex = 13;
            // 
            // BranchEmaillabel
            // 
            BranchEmaillabel.Anchor = AnchorStyles.None;
            BranchEmaillabel.AutoSize = true;
            BranchEmaillabel.Location = new Point(121, 427);
            BranchEmaillabel.Name = "BranchEmaillabel";
            BranchEmaillabel.Size = new Size(118, 21);
            BranchEmaillabel.TabIndex = 14;
            BranchEmaillabel.Text = "Branch Email :";
            // 
            // BranchEmailtextBox
            // 
            BranchEmailtextBox.Anchor = AnchorStyles.None;
            BranchEmailtextBox.Location = new Point(259, 424);
            BranchEmailtextBox.Name = "BranchEmailtextBox";
            BranchEmailtextBox.ReadOnly = true;
            BranchEmailtextBox.Size = new Size(273, 29);
            BranchEmailtextBox.TabIndex = 15;
            // 
            // ManagerIDlabel
            // 
            ManagerIDlabel.Anchor = AnchorStyles.None;
            ManagerIDlabel.AutoSize = true;
            ManagerIDlabel.Location = new Point(130, 476);
            ManagerIDlabel.Name = "ManagerIDlabel";
            ManagerIDlabel.Size = new Size(107, 21);
            ManagerIDlabel.TabIndex = 16;
            ManagerIDlabel.Text = "Manager ID :";
            // 
            // ManagerIDtextBox
            // 
            ManagerIDtextBox.Anchor = AnchorStyles.None;
            ManagerIDtextBox.Location = new Point(259, 473);
            ManagerIDtextBox.Name = "ManagerIDtextBox";
            ManagerIDtextBox.ReadOnly = true;
            ManagerIDtextBox.Size = new Size(273, 29);
            ManagerIDtextBox.TabIndex = 17;
            // 
            // IsActivecheckBox
            // 
            IsActivecheckBox.Anchor = AnchorStyles.None;
            IsActivecheckBox.AutoSize = true;
            IsActivecheckBox.Enabled = false;
            IsActivecheckBox.Location = new Point(259, 522);
            IsActivecheckBox.Name = "IsActivecheckBox";
            IsActivecheckBox.Size = new Size(95, 25);
            IsActivecheckBox.TabIndex = 18;
            IsActivecheckBox.Text = "Is Active";
            IsActivecheckBox.UseVisualStyleBackColor = true;
            // 
            // Deletebutton
            // 
            Deletebutton.Anchor = AnchorStyles.None;
            Deletebutton.BackColor = Color.Firebrick;
            Deletebutton.ForeColor = Color.White;
            Deletebutton.Location = new Point(80, 579);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(124, 41);
            Deletebutton.TabIndex = 19;
            Deletebutton.Text = "Delete";
            Deletebutton.UseVisualStyleBackColor = false;
            Deletebutton.Click += Deletebutton_Click;
            // 
            // Clearbutton
            // 
            Clearbutton.Anchor = AnchorStyles.None;
            Clearbutton.BackColor = Color.Tan;
            Clearbutton.Location = new Point(235, 579);
            Clearbutton.Name = "Clearbutton";
            Clearbutton.Size = new Size(124, 41);
            Clearbutton.TabIndex = 20;
            Clearbutton.Text = "Clear";
            Clearbutton.UseVisualStyleBackColor = false;
            Clearbutton.Click += Clearbutton_Click;
            // 
            // Cancelbutton
            // 
            Cancelbutton.Anchor = AnchorStyles.None;
            Cancelbutton.BackColor = Color.Red;
            Cancelbutton.ForeColor = Color.White;
            Cancelbutton.Location = new Point(390, 579);
            Cancelbutton.Name = "Cancelbutton";
            Cancelbutton.Size = new Size(124, 41);
            Cancelbutton.TabIndex = 21;
            Cancelbutton.Text = "Cancel";
            Cancelbutton.UseVisualStyleBackColor = false;
            Cancelbutton.Click += Cancelbutton_Click;
            // 
            // DeleteBranchGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 669);
            Controls.Add(Cancelbutton);
            Controls.Add(Clearbutton);
            Controls.Add(Deletebutton);
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
            Controls.Add(SearchgroupBox);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "DeleteBranchGUI";
            Text = "Delete Branch";
            SearchgroupBox.ResumeLayout(false);
            SearchgroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox SearchgroupBox;
        private Button Searchbutton;
        private TextBox SearchtextBox;
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
        private Button Deletebutton;
        private Button Clearbutton;
        private Button Cancelbutton;
    }
}
