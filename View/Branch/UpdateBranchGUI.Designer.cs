namespace SuperMart_Pro.View.Branch
{
    partial class UpdateBranchGUI
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
            Savebutton = new Button();
            Clearbutton = new Button();
            Cancelbutton = new Button();
            SearchgroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // Headerpanel
            // 
            Headerpanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Headerpanel.BackColor = Color.Tomato;
            Headerpanel.Location = new Point(0, 0);
            Headerpanel.Name = "Headerpanel";
            Headerpanel.Size = new Size(763, 85);
            Headerpanel.TabIndex = 0;
            // 
            // SearchgroupBox
            // 
            SearchgroupBox.Anchor = AnchorStyles.None;
            SearchgroupBox.Controls.Add(Searchbutton);
            SearchgroupBox.Controls.Add(SearchtextBox);
            SearchgroupBox.Location = new Point(161, 103);
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
            BranchIDlabel.Location = new Point(226, 210);
            BranchIDlabel.Name = "BranchIDlabel";
            BranchIDlabel.Size = new Size(96, 21);
            BranchIDlabel.TabIndex = 2;
            BranchIDlabel.Text = "Branch ID :";
            // 
            // BranchIDtextBox
            // 
            BranchIDtextBox.Anchor = AnchorStyles.None;
            BranchIDtextBox.Location = new Point(342, 207);
            BranchIDtextBox.Name = "BranchIDtextBox";
            BranchIDtextBox.ReadOnly = true;
            BranchIDtextBox.Size = new Size(273, 29);
            BranchIDtextBox.TabIndex = 3;
            // 
            // BranchNamelabel
            // 
            BranchNamelabel.Anchor = AnchorStyles.None;
            BranchNamelabel.AutoSize = true;
            BranchNamelabel.Location = new Point(202, 258);
            BranchNamelabel.Name = "BranchNamelabel";
            BranchNamelabel.Size = new Size(120, 21);
            BranchNamelabel.TabIndex = 4;
            BranchNamelabel.Text = "Branch Name :";
            // 
            // BranchNametextBox
            // 
            BranchNametextBox.Anchor = AnchorStyles.None;
            BranchNametextBox.Location = new Point(342, 255);
            BranchNametextBox.Name = "BranchNametextBox";
            BranchNametextBox.Size = new Size(273, 29);
            BranchNametextBox.TabIndex = 5;
            // 
            // BranchTypelabel
            // 
            BranchTypelabel.Anchor = AnchorStyles.None;
            BranchTypelabel.AutoSize = true;
            BranchTypelabel.Location = new Point(207, 307);
            BranchTypelabel.Name = "BranchTypelabel";
            BranchTypelabel.Size = new Size(115, 21);
            BranchTypelabel.TabIndex = 6;
            BranchTypelabel.Text = "Branch Type :";
            // 
            // BranchTypecomboBox
            // 
            BranchTypecomboBox.Anchor = AnchorStyles.None;
            BranchTypecomboBox.FormattingEnabled = true;
            BranchTypecomboBox.Items.AddRange(new object[] { "Main", "Sub", "Warehouse", "Outlet" });
            BranchTypecomboBox.Location = new Point(342, 304);
            BranchTypecomboBox.Name = "BranchTypecomboBox";
            BranchTypecomboBox.Size = new Size(273, 29);
            BranchTypecomboBox.TabIndex = 7;
            // 
            // BranchAddresslabel
            // 
            BranchAddresslabel.Anchor = AnchorStyles.None;
            BranchAddresslabel.AutoSize = true;
            BranchAddresslabel.Location = new Point(185, 356);
            BranchAddresslabel.Name = "BranchAddresslabel";
            BranchAddresslabel.Size = new Size(139, 21);
            BranchAddresslabel.TabIndex = 8;
            BranchAddresslabel.Text = "Branch Address :";
            // 
            // BranchAddresstextBox
            // 
            BranchAddresstextBox.Anchor = AnchorStyles.None;
            BranchAddresstextBox.Location = new Point(342, 353);
            BranchAddresstextBox.Name = "BranchAddresstextBox";
            BranchAddresstextBox.Size = new Size(273, 29);
            BranchAddresstextBox.TabIndex = 9;
            // 
            // BranchZiplabel
            // 
            BranchZiplabel.Anchor = AnchorStyles.None;
            BranchZiplabel.AutoSize = true;
            BranchZiplabel.Location = new Point(222, 405);
            BranchZiplabel.Name = "BranchZiplabel";
            BranchZiplabel.Size = new Size(102, 21);
            BranchZiplabel.TabIndex = 10;
            BranchZiplabel.Text = "Branch Zip :";
            // 
            // BranchZiptextBox
            // 
            BranchZiptextBox.Anchor = AnchorStyles.None;
            BranchZiptextBox.Location = new Point(342, 402);
            BranchZiptextBox.Name = "BranchZiptextBox";
            BranchZiptextBox.Size = new Size(273, 29);
            BranchZiptextBox.TabIndex = 11;
            // 
            // BranchPhonelabel
            // 
            BranchPhonelabel.Anchor = AnchorStyles.None;
            BranchPhonelabel.AutoSize = true;
            BranchPhonelabel.Location = new Point(196, 454);
            BranchPhonelabel.Name = "BranchPhonelabel";
            BranchPhonelabel.Size = new Size(124, 21);
            BranchPhonelabel.TabIndex = 12;
            BranchPhonelabel.Text = "Branch Phone :";
            // 
            // BranchPhonetextBox
            // 
            BranchPhonetextBox.Anchor = AnchorStyles.None;
            BranchPhonetextBox.Location = new Point(342, 451);
            BranchPhonetextBox.Name = "BranchPhonetextBox";
            BranchPhonetextBox.Size = new Size(273, 29);
            BranchPhonetextBox.TabIndex = 13;
            // 
            // BranchEmaillabel
            // 
            BranchEmaillabel.Anchor = AnchorStyles.None;
            BranchEmaillabel.AutoSize = true;
            BranchEmaillabel.Location = new Point(204, 503);
            BranchEmaillabel.Name = "BranchEmaillabel";
            BranchEmaillabel.Size = new Size(118, 21);
            BranchEmaillabel.TabIndex = 14;
            BranchEmaillabel.Text = "Branch Email :";
            // 
            // BranchEmailtextBox
            // 
            BranchEmailtextBox.Anchor = AnchorStyles.None;
            BranchEmailtextBox.Location = new Point(342, 500);
            BranchEmailtextBox.Name = "BranchEmailtextBox";
            BranchEmailtextBox.Size = new Size(273, 29);
            BranchEmailtextBox.TabIndex = 15;
            // 
            // ManagerIDlabel
            // 
            ManagerIDlabel.Anchor = AnchorStyles.None;
            ManagerIDlabel.AutoSize = true;
            ManagerIDlabel.Location = new Point(213, 552);
            ManagerIDlabel.Name = "ManagerIDlabel";
            ManagerIDlabel.Size = new Size(107, 21);
            ManagerIDlabel.TabIndex = 16;
            ManagerIDlabel.Text = "Manager ID :";
            // 
            // ManagerIDtextBox
            // 
            ManagerIDtextBox.Anchor = AnchorStyles.None;
            ManagerIDtextBox.Location = new Point(342, 549);
            ManagerIDtextBox.Name = "ManagerIDtextBox";
            ManagerIDtextBox.Size = new Size(273, 29);
            ManagerIDtextBox.TabIndex = 17;
            // 
            // IsActivecheckBox
            // 
            IsActivecheckBox.Anchor = AnchorStyles.None;
            IsActivecheckBox.AutoSize = true;
            IsActivecheckBox.Location = new Point(342, 598);
            IsActivecheckBox.Name = "IsActivecheckBox";
            IsActivecheckBox.Size = new Size(95, 25);
            IsActivecheckBox.TabIndex = 18;
            IsActivecheckBox.Text = "Is Active";
            IsActivecheckBox.UseVisualStyleBackColor = true;
            // 
            // Savebutton
            // 
            Savebutton.Anchor = AnchorStyles.None;
            Savebutton.BackColor = Color.OliveDrab;
            Savebutton.ForeColor = Color.White;
            Savebutton.Location = new Point(163, 655);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(124, 41);
            Savebutton.TabIndex = 19;
            Savebutton.Text = "Update";
            Savebutton.UseVisualStyleBackColor = false;
            Savebutton.Click += Savebutton_Click;
            // 
            // Clearbutton
            // 
            Clearbutton.Anchor = AnchorStyles.None;
            Clearbutton.BackColor = Color.Tan;
            Clearbutton.Location = new Point(318, 655);
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
            Cancelbutton.Location = new Point(473, 655);
            Cancelbutton.Name = "Cancelbutton";
            Cancelbutton.Size = new Size(124, 41);
            Cancelbutton.TabIndex = 21;
            Cancelbutton.Text = "Cancel";
            Cancelbutton.UseVisualStyleBackColor = false;
            Cancelbutton.Click += Cancelbutton_Click;
            // 
            // UpdateBranchGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 720);
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
            Controls.Add(SearchgroupBox);
            Controls.Add(Headerpanel);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "UpdateBranchGUI";
            Text = "Update Branch";
            SearchgroupBox.ResumeLayout(false);
            SearchgroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Headerpanel;
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
        private Button Savebutton;
        private Button Clearbutton;
        private Button Cancelbutton;
    }
}
