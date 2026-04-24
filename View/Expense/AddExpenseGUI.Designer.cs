namespace SuperMart_Pro.View.Expense
{
    partial class AddExpenseGUI
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
            ExpenseIDlabel = new Label();
            ExpenseIDtextBox = new TextBox();
            Descriptionlabel = new Label();
            DescriptionrichTextBox = new RichTextBox();
            ExpenseTypelabel = new Label();
            ExpenseTypecomboBox = new ComboBox();
            Amountlabel = new Label();
            AmounttextBox = new TextBox();
            Datelabel = new Label();
            DatedatePicker = new DateTimePicker();
            Receiptlabel = new Label();
            ReceiptpictureBox = new PictureBox();
            BrowseReceiptbutton = new Button();
            Noteslabel = new Label();
            NotesrichTextBox = new RichTextBox();
            BranchIDlabel = new Label();
            BranchIDtextBox = new TextBox();
            BranchNamelabel = new Label();
            BranchNametextBox = new TextBox();
            BranchIDsearchbutton = new Button();
            Savebutton = new Button();
            Clearbutton = new Button();
            Cancelbutton = new Button();
            PaymentMethodcomboBox = new ComboBox();
            PaymentMethodlabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ReceiptpictureBox).BeginInit();
            SuspendLayout();
            // 
            // ExpenseIDlabel
            // 
            ExpenseIDlabel.Anchor = AnchorStyles.None;
            ExpenseIDlabel.AutoSize = true;
            ExpenseIDlabel.Location = new Point(67, 18);
            ExpenseIDlabel.Name = "ExpenseIDlabel";
            ExpenseIDlabel.Size = new Size(106, 21);
            ExpenseIDlabel.TabIndex = 1;
            ExpenseIDlabel.Text = "Expense ID :";
            // 
            // ExpenseIDtextBox
            // 
            ExpenseIDtextBox.Anchor = AnchorStyles.None;
            ExpenseIDtextBox.Location = new Point(197, 15);
            ExpenseIDtextBox.Name = "ExpenseIDtextBox";
            ExpenseIDtextBox.Size = new Size(280, 29);
            ExpenseIDtextBox.TabIndex = 2;
            // 
            // Descriptionlabel
            // 
            Descriptionlabel.Anchor = AnchorStyles.None;
            Descriptionlabel.AutoSize = true;
            Descriptionlabel.Location = new Point(68, 96);
            Descriptionlabel.Name = "Descriptionlabel";
            Descriptionlabel.Size = new Size(105, 21);
            Descriptionlabel.TabIndex = 3;
            Descriptionlabel.Text = "Description :";
            // 
            // DescriptionrichTextBox
            // 
            DescriptionrichTextBox.Anchor = AnchorStyles.None;
            DescriptionrichTextBox.Location = new Point(197, 67);
            DescriptionrichTextBox.Name = "DescriptionrichTextBox";
            DescriptionrichTextBox.Size = new Size(280, 80);
            DescriptionrichTextBox.TabIndex = 4;
            DescriptionrichTextBox.Text = "";
            // 
            // ExpenseTypelabel
            // 
            ExpenseTypelabel.Anchor = AnchorStyles.None;
            ExpenseTypelabel.AutoSize = true;
            ExpenseTypelabel.Location = new Point(48, 168);
            ExpenseTypelabel.Name = "ExpenseTypelabel";
            ExpenseTypelabel.Size = new Size(125, 21);
            ExpenseTypelabel.TabIndex = 5;
            ExpenseTypelabel.Text = "Expense Type :";
            // 
            // ExpenseTypecomboBox
            // 
            ExpenseTypecomboBox.Anchor = AnchorStyles.None;
            ExpenseTypecomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ExpenseTypecomboBox.FormattingEnabled = true;
            ExpenseTypecomboBox.Items.AddRange(new object[] { "Food", "Transportation", "Entertainment", "Utilities", "Healthcare", "Education", "Miscellaneous" });
            ExpenseTypecomboBox.Location = new Point(197, 165);
            ExpenseTypecomboBox.Name = "ExpenseTypecomboBox";
            ExpenseTypecomboBox.Size = new Size(280, 29);
            ExpenseTypecomboBox.TabIndex = 6;
            // 
            // Amountlabel
            // 
            Amountlabel.Anchor = AnchorStyles.None;
            Amountlabel.AutoSize = true;
            Amountlabel.Location = new Point(94, 216);
            Amountlabel.Name = "Amountlabel";
            Amountlabel.Size = new Size(79, 21);
            Amountlabel.TabIndex = 7;
            Amountlabel.Text = "Amount :";
            // 
            // AmounttextBox
            // 
            AmounttextBox.Anchor = AnchorStyles.None;
            AmounttextBox.Location = new Point(197, 213);
            AmounttextBox.Name = "AmounttextBox";
            AmounttextBox.Size = new Size(280, 29);
            AmounttextBox.TabIndex = 8;
            // 
            // Datelabel
            // 
            Datelabel.Anchor = AnchorStyles.None;
            Datelabel.AutoSize = true;
            Datelabel.Location = new Point(120, 269);
            Datelabel.Name = "Datelabel";
            Datelabel.Size = new Size(53, 21);
            Datelabel.TabIndex = 9;
            Datelabel.Text = "Date :";
            // 
            // DatedatePicker
            // 
            DatedatePicker.Anchor = AnchorStyles.None;
            DatedatePicker.Format = DateTimePickerFormat.Short;
            DatedatePicker.Location = new Point(197, 266);
            DatedatePicker.Name = "DatedatePicker";
            DatedatePicker.Size = new Size(280, 29);
            DatedatePicker.TabIndex = 10;
            // 
            // Receiptlabel
            // 
            Receiptlabel.Anchor = AnchorStyles.None;
            Receiptlabel.AutoSize = true;
            Receiptlabel.Location = new Point(101, 381);
            Receiptlabel.Name = "Receiptlabel";
            Receiptlabel.Size = new Size(76, 21);
            Receiptlabel.TabIndex = 11;
            Receiptlabel.Text = "Receipt :";
            // 
            // ReceiptpictureBox
            // 
            ReceiptpictureBox.Anchor = AnchorStyles.None;
            ReceiptpictureBox.BorderStyle = BorderStyle.FixedSingle;
            ReceiptpictureBox.Location = new Point(197, 314);
            ReceiptpictureBox.Name = "ReceiptpictureBox";
            ReceiptpictureBox.Size = new Size(156, 160);
            ReceiptpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ReceiptpictureBox.TabIndex = 12;
            ReceiptpictureBox.TabStop = false;
            // 
            // BrowseReceiptbutton
            // 
            BrowseReceiptbutton.Anchor = AnchorStyles.None;
            BrowseReceiptbutton.Location = new Point(372, 372);
            BrowseReceiptbutton.Name = "BrowseReceiptbutton";
            BrowseReceiptbutton.Size = new Size(100, 30);
            BrowseReceiptbutton.TabIndex = 13;
            BrowseReceiptbutton.Text = "Browse";
            BrowseReceiptbutton.UseVisualStyleBackColor = true;
            BrowseReceiptbutton.Click += BrowseReceiptbutton_Click;
            // 
            // Noteslabel
            // 
            Noteslabel.Anchor = AnchorStyles.None;
            Noteslabel.AutoSize = true;
            Noteslabel.Location = new Point(110, 520);
            Noteslabel.Name = "Noteslabel";
            Noteslabel.Size = new Size(63, 21);
            Noteslabel.TabIndex = 14;
            Noteslabel.Text = "Notes :";
            // 
            // NotesrichTextBox
            // 
            NotesrichTextBox.Anchor = AnchorStyles.None;
            NotesrichTextBox.Location = new Point(197, 492);
            NotesrichTextBox.Name = "NotesrichTextBox";
            NotesrichTextBox.Size = new Size(280, 80);
            NotesrichTextBox.TabIndex = 15;
            NotesrichTextBox.Text = "";
            // 
            // BranchIDlabel
            // 
            BranchIDlabel.Anchor = AnchorStyles.None;
            BranchIDlabel.AutoSize = true;
            BranchIDlabel.Location = new Point(77, 596);
            BranchIDlabel.Name = "BranchIDlabel";
            BranchIDlabel.Size = new Size(96, 21);
            BranchIDlabel.TabIndex = 16;
            BranchIDlabel.Text = "Branch ID :";
            // 
            // BranchIDtextBox
            // 
            BranchIDtextBox.Anchor = AnchorStyles.None;
            BranchIDtextBox.Location = new Point(197, 592);
            BranchIDtextBox.Name = "BranchIDtextBox";
            BranchIDtextBox.Size = new Size(280, 29);
            BranchIDtextBox.TabIndex = 17;
            // 
            // BranchNamelabel
            // 
            BranchNamelabel.Anchor = AnchorStyles.None;
            BranchNamelabel.AutoSize = true;
            BranchNamelabel.Location = new Point(57, 645);
            BranchNamelabel.Name = "BranchNamelabel";
            BranchNamelabel.Size = new Size(120, 21);
            BranchNamelabel.TabIndex = 18;
            BranchNamelabel.Text = "Branch Name :";
            // 
            // BranchNametextBox
            // 
            BranchNametextBox.Anchor = AnchorStyles.None;
            BranchNametextBox.Location = new Point(197, 645);
            BranchNametextBox.Name = "BranchNametextBox";
            BranchNametextBox.ReadOnly = true;
            BranchNametextBox.Size = new Size(280, 29);
            BranchNametextBox.TabIndex = 19;
            // 
            // BranchIDsearchbutton
            // 
            BranchIDsearchbutton.Anchor = AnchorStyles.None;
            BranchIDsearchbutton.Location = new Point(497, 591);
            BranchIDsearchbutton.Name = "BranchIDsearchbutton";
            BranchIDsearchbutton.Size = new Size(75, 29);
            BranchIDsearchbutton.TabIndex = 20;
            BranchIDsearchbutton.Text = "Search";
            BranchIDsearchbutton.UseVisualStyleBackColor = true;
            BranchIDsearchbutton.Click += BranchIDsearchbutton_Click;
            // 
            // Savebutton
            // 
            Savebutton.Anchor = AnchorStyles.None;
            Savebutton.BackColor = Color.OliveDrab;
            Savebutton.ForeColor = Color.White;
            Savebutton.Location = new Point(99, 756);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(124, 41);
            Savebutton.TabIndex = 23;
            Savebutton.Text = "Save";
            Savebutton.UseVisualStyleBackColor = false;
            Savebutton.Click += Savebutton_Click;
            // 
            // Clearbutton
            // 
            Clearbutton.Anchor = AnchorStyles.None;
            Clearbutton.BackColor = Color.Tan;
            Clearbutton.Location = new Point(249, 756);
            Clearbutton.Name = "Clearbutton";
            Clearbutton.Size = new Size(124, 41);
            Clearbutton.TabIndex = 26;
            Clearbutton.Text = "Clear";
            Clearbutton.UseVisualStyleBackColor = false;
            Clearbutton.Click += Clearbutton_Click;
            // 
            // Cancelbutton
            // 
            Cancelbutton.Anchor = AnchorStyles.None;
            Cancelbutton.BackColor = Color.Red;
            Cancelbutton.ForeColor = Color.White;
            Cancelbutton.Location = new Point(399, 756);
            Cancelbutton.Name = "Cancelbutton";
            Cancelbutton.Size = new Size(124, 41);
            Cancelbutton.TabIndex = 27;
            Cancelbutton.Text = "Cancel";
            Cancelbutton.UseVisualStyleBackColor = false;
            Cancelbutton.Click += Cancelbutton_Click;
            // 
            // PaymentMethodcomboBox
            // 
            PaymentMethodcomboBox.Anchor = AnchorStyles.None;
            PaymentMethodcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PaymentMethodcomboBox.FormattingEnabled = true;
            PaymentMethodcomboBox.Items.AddRange(new object[] { "Cash", "Credit Card", "Debit Card", "Bank Transfer", "Mobile Payment", "Check", "Other" });
            PaymentMethodcomboBox.Location = new Point(197, 700);
            PaymentMethodcomboBox.Name = "PaymentMethodcomboBox";
            PaymentMethodcomboBox.Size = new Size(280, 29);
            PaymentMethodcomboBox.TabIndex = 29;
            // 
            // PaymentMethodlabel
            // 
            PaymentMethodlabel.Anchor = AnchorStyles.None;
            PaymentMethodlabel.AutoSize = true;
            PaymentMethodlabel.Location = new Point(47, 703);
            PaymentMethodlabel.Name = "PaymentMethodlabel";
            PaymentMethodlabel.Size = new Size(146, 21);
            PaymentMethodlabel.TabIndex = 28;
            PaymentMethodlabel.Text = "Payment Method :";
            // 
            // AddExpenseGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 812);
            Controls.Add(PaymentMethodcomboBox);
            Controls.Add(PaymentMethodlabel);
            Controls.Add(Cancelbutton);
            Controls.Add(Clearbutton);
            Controls.Add(Savebutton);
            Controls.Add(BranchIDsearchbutton);
            Controls.Add(BranchNametextBox);
            Controls.Add(BranchNamelabel);
            Controls.Add(BranchIDtextBox);
            Controls.Add(BranchIDlabel);
            Controls.Add(NotesrichTextBox);
            Controls.Add(Noteslabel);
            Controls.Add(BrowseReceiptbutton);
            Controls.Add(ReceiptpictureBox);
            Controls.Add(Receiptlabel);
            Controls.Add(DatedatePicker);
            Controls.Add(Datelabel);
            Controls.Add(AmounttextBox);
            Controls.Add(Amountlabel);
            Controls.Add(ExpenseTypecomboBox);
            Controls.Add(ExpenseTypelabel);
            Controls.Add(DescriptionrichTextBox);
            Controls.Add(Descriptionlabel);
            Controls.Add(ExpenseIDtextBox);
            Controls.Add(ExpenseIDlabel);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AddExpenseGUI";
            Text = "Add Expense";
            ((System.ComponentModel.ISupportInitialize)ReceiptpictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ExpenseIDlabel;
        private TextBox ExpenseIDtextBox;
        private Label Descriptionlabel;
        private RichTextBox DescriptionrichTextBox;
        private Label ExpenseTypelabel;
        private ComboBox ExpenseTypecomboBox;
        private Label Amountlabel;
        private TextBox AmounttextBox;
        private Label Datelabel;
        private DateTimePicker DatedatePicker;
        private Label Receiptlabel;
        private PictureBox ReceiptpictureBox;
        private Button BrowseReceiptbutton;
        private Label Noteslabel;
        private RichTextBox NotesrichTextBox;
        private Label BranchIDlabel;
        private TextBox BranchIDtextBox;
        private Label BranchNamelabel;
        private TextBox BranchNametextBox;
        private Button BranchIDsearchbutton;
        private Button Savebutton;
        private Button Clearbutton;
        private Button Cancelbutton;
        private ComboBox PaymentMethodcomboBox;
        private Label PaymentMethodlabel;
    }
}
