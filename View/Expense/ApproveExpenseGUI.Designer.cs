namespace SuperMart_Pro.View.Expense
{
    partial class ApproveExpenseGUI
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            SearchpanelPanel = new Panel();
            Searchlabel = new Label();
            SearchtextBox = new TextBox();
            Searchbutton = new Button();
            Refreshbutton = new Button();
            PendingCountlabel = new Label();
            MainsplitContainer = new SplitContainer();
            PendingExpensesdataGridView = new DataGridView();
            DetailpanelPanel = new Panel();
            DetailGroupBox = new GroupBox();
            DetailExpenseIDlabel = new Label();
            DetailExpenseIDtextBox = new TextBox();
            DetailDescriptionlabel = new Label();
            DetailDescriptiontextBox = new TextBox();
            DetailTypelabel = new Label();
            DetailTypetextBox = new TextBox();
            DetailAmountlabel = new Label();
            DetailAmounttextBox = new TextBox();
            DetailDatelabel = new Label();
            DetailDatetextBox = new TextBox();
            DetailPaymentMethodlabel = new Label();
            DetailPaymentMethodtextBox = new TextBox();
            DetailBranchIDlabel = new Label();
            DetailBranchIDtextBox = new TextBox();
            DetailSubmittedBylabel = new Label();
            DetailSubmittedBytextBox = new TextBox();
            Receiptlabel = new Label();
            ReceiptpictureBox = new PictureBox();
            ApproverNoteslabel = new Label();
            ApproverNotesrichtextBox = new RichTextBox();
            ActionpanelPanel = new Panel();
            Approvebutton = new Button();
            Rejectbutton = new Button();
            FooterpanelPanel = new Panel();
            Closebutton = new Button();
            SearchpanelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainsplitContainer).BeginInit();
            MainsplitContainer.Panel1.SuspendLayout();
            MainsplitContainer.Panel2.SuspendLayout();
            MainsplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PendingExpensesdataGridView).BeginInit();
            DetailpanelPanel.SuspendLayout();
            DetailGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReceiptpictureBox).BeginInit();
            ActionpanelPanel.SuspendLayout();
            FooterpanelPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SearchpanelPanel
            // 
            SearchpanelPanel.BackColor = Color.WhiteSmoke;
            SearchpanelPanel.BorderStyle = BorderStyle.FixedSingle;
            SearchpanelPanel.Controls.Add(Searchlabel);
            SearchpanelPanel.Controls.Add(SearchtextBox);
            SearchpanelPanel.Controls.Add(Searchbutton);
            SearchpanelPanel.Controls.Add(Refreshbutton);
            SearchpanelPanel.Controls.Add(PendingCountlabel);
            SearchpanelPanel.Dock = DockStyle.Top;
            SearchpanelPanel.Location = new Point(0, 0);
            SearchpanelPanel.Name = "SearchpanelPanel";
            SearchpanelPanel.Size = new Size(1463, 55);
            SearchpanelPanel.TabIndex = 1;
            // 
            // Searchlabel
            // 
            Searchlabel.AutoSize = true;
            Searchlabel.Location = new Point(15, 15);
            Searchlabel.Name = "Searchlabel";
            Searchlabel.Size = new Size(56, 17);
            Searchlabel.TabIndex = 0;
            Searchlabel.Text = "Search :";
            // 
            // SearchtextBox
            // 
            SearchtextBox.Location = new Point(100, 13);
            SearchtextBox.Name = "SearchtextBox";
            SearchtextBox.Size = new Size(300, 24);
            SearchtextBox.TabIndex = 1;
            // 
            // Searchbutton
            // 
            Searchbutton.BackColor = Color.SteelBlue;
            Searchbutton.ForeColor = Color.White;
            Searchbutton.Location = new Point(415, 11);
            Searchbutton.Name = "Searchbutton";
            Searchbutton.Size = new Size(100, 33);
            Searchbutton.TabIndex = 2;
            Searchbutton.Text = "Search";
            Searchbutton.UseVisualStyleBackColor = false;
            Searchbutton.Click += Searchbutton_Click;
            // 
            // Refreshbutton
            // 
            Refreshbutton.BackColor = Color.Tan;
            Refreshbutton.Location = new Point(525, 11);
            Refreshbutton.Name = "Refreshbutton";
            Refreshbutton.Size = new Size(100, 33);
            Refreshbutton.TabIndex = 3;
            Refreshbutton.Text = "Refresh";
            Refreshbutton.UseVisualStyleBackColor = false;
            Refreshbutton.Click += Refreshbutton_Click;
            // 
            // PendingCountlabel
            // 
            PendingCountlabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PendingCountlabel.AutoSize = true;
            PendingCountlabel.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            PendingCountlabel.ForeColor = Color.Tomato;
            PendingCountlabel.Location = new Point(1303, 15);
            PendingCountlabel.Name = "PendingCountlabel";
            PendingCountlabel.Size = new Size(78, 17);
            PendingCountlabel.TabIndex = 4;
            PendingCountlabel.Text = "Pending: 0";
            // 
            // MainsplitContainer
            // 
            MainsplitContainer.Dock = DockStyle.Fill;
            MainsplitContainer.Location = new Point(0, 55);
            MainsplitContainer.Name = "MainsplitContainer";
            // 
            // MainsplitContainer.Panel1
            // 
            MainsplitContainer.Panel1.Controls.Add(PendingExpensesdataGridView);
            // 
            // MainsplitContainer.Panel2
            // 
            MainsplitContainer.Panel2.Controls.Add(DetailpanelPanel);
            MainsplitContainer.Panel2.Controls.Add(ActionpanelPanel);
            MainsplitContainer.Size = new Size(1463, 690);
            MainsplitContainer.SplitterDistance = 1088;
            MainsplitContainer.TabIndex = 2;
            // 
            // PendingExpensesdataGridView
            // 
            PendingExpensesdataGridView.AllowUserToAddRows = false;
            PendingExpensesdataGridView.AllowUserToDeleteRows = false;
            PendingExpensesdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PendingExpensesdataGridView.BackgroundColor = Color.White;
            PendingExpensesdataGridView.BorderStyle = BorderStyle.None;
            PendingExpensesdataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.BackColor = Color.Tomato;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            PendingExpensesdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            PendingExpensesdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PendingExpensesdataGridView.Dock = DockStyle.Fill;
            PendingExpensesdataGridView.EnableHeadersVisualStyles = false;
            PendingExpensesdataGridView.GridColor = Color.LightGray;
            PendingExpensesdataGridView.Location = new Point(0, 0);
            PendingExpensesdataGridView.Name = "PendingExpensesdataGridView";
            PendingExpensesdataGridView.ReadOnly = true;
            PendingExpensesdataGridView.RowHeadersWidth = 40;
            PendingExpensesdataGridView.RowTemplate.Height = 32;
            PendingExpensesdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PendingExpensesdataGridView.Size = new Size(1088, 690);
            PendingExpensesdataGridView.TabIndex = 0;
            PendingExpensesdataGridView.SelectionChanged += PendingExpensesdataGridView_SelectionChanged;
            // 
            // DetailpanelPanel
            // 
            DetailpanelPanel.AutoScroll = true;
            DetailpanelPanel.BackColor = Color.White;
            DetailpanelPanel.Controls.Add(DetailGroupBox);
            DetailpanelPanel.Dock = DockStyle.Fill;
            DetailpanelPanel.Location = new Point(0, 0);
            DetailpanelPanel.Name = "DetailpanelPanel";
            DetailpanelPanel.Size = new Size(371, 630);
            DetailpanelPanel.TabIndex = 0;
            // 
            // DetailGroupBox
            // 
            DetailGroupBox.Controls.Add(DetailExpenseIDlabel);
            DetailGroupBox.Controls.Add(DetailExpenseIDtextBox);
            DetailGroupBox.Controls.Add(DetailDescriptionlabel);
            DetailGroupBox.Controls.Add(DetailDescriptiontextBox);
            DetailGroupBox.Controls.Add(DetailTypelabel);
            DetailGroupBox.Controls.Add(DetailTypetextBox);
            DetailGroupBox.Controls.Add(DetailAmountlabel);
            DetailGroupBox.Controls.Add(DetailAmounttextBox);
            DetailGroupBox.Controls.Add(DetailDatelabel);
            DetailGroupBox.Controls.Add(DetailDatetextBox);
            DetailGroupBox.Controls.Add(DetailPaymentMethodlabel);
            DetailGroupBox.Controls.Add(DetailPaymentMethodtextBox);
            DetailGroupBox.Controls.Add(DetailBranchIDlabel);
            DetailGroupBox.Controls.Add(DetailBranchIDtextBox);
            DetailGroupBox.Controls.Add(DetailSubmittedBylabel);
            DetailGroupBox.Controls.Add(DetailSubmittedBytextBox);
            DetailGroupBox.Controls.Add(Receiptlabel);
            DetailGroupBox.Controls.Add(ReceiptpictureBox);
            DetailGroupBox.Controls.Add(ApproverNoteslabel);
            DetailGroupBox.Controls.Add(ApproverNotesrichtextBox);
            DetailGroupBox.Dock = DockStyle.Fill;
            DetailGroupBox.Font = new Font("Times New Roman", 11F);
            DetailGroupBox.Location = new Point(0, 0);
            DetailGroupBox.Name = "DetailGroupBox";
            DetailGroupBox.Padding = new Padding(12);
            DetailGroupBox.Size = new Size(371, 630);
            DetailGroupBox.TabIndex = 0;
            DetailGroupBox.TabStop = false;
            DetailGroupBox.Text = "Expense Details";
            // 
            // DetailExpenseIDlabel
            // 
            DetailExpenseIDlabel.AutoSize = true;
            DetailExpenseIDlabel.Location = new Point(20, 35);
            DetailExpenseIDlabel.Name = "DetailExpenseIDlabel";
            DetailExpenseIDlabel.Size = new Size(85, 17);
            DetailExpenseIDlabel.TabIndex = 0;
            DetailExpenseIDlabel.Text = "Expense ID :";
            // 
            // DetailExpenseIDtextBox
            // 
            DetailExpenseIDtextBox.BackColor = Color.WhiteSmoke;
            DetailExpenseIDtextBox.Location = new Point(160, 30);
            DetailExpenseIDtextBox.Name = "DetailExpenseIDtextBox";
            DetailExpenseIDtextBox.ReadOnly = true;
            DetailExpenseIDtextBox.Size = new Size(200, 24);
            DetailExpenseIDtextBox.TabIndex = 0;
            // 
            // DetailDescriptionlabel
            // 
            DetailDescriptionlabel.AutoSize = true;
            DetailDescriptionlabel.Location = new Point(20, 79);
            DetailDescriptionlabel.Name = "DetailDescriptionlabel";
            DetailDescriptionlabel.Size = new Size(82, 17);
            DetailDescriptionlabel.TabIndex = 1;
            DetailDescriptionlabel.Text = "Description :";
            // 
            // DetailDescriptiontextBox
            // 
            DetailDescriptiontextBox.BackColor = Color.WhiteSmoke;
            DetailDescriptiontextBox.Location = new Point(160, 74);
            DetailDescriptiontextBox.Name = "DetailDescriptiontextBox";
            DetailDescriptiontextBox.ReadOnly = true;
            DetailDescriptiontextBox.Size = new Size(200, 24);
            DetailDescriptiontextBox.TabIndex = 1;
            // 
            // DetailTypelabel
            // 
            DetailTypelabel.AutoSize = true;
            DetailTypelabel.Location = new Point(20, 123);
            DetailTypelabel.Name = "DetailTypelabel";
            DetailTypelabel.Size = new Size(44, 17);
            DetailTypelabel.TabIndex = 2;
            DetailTypelabel.Text = "Type :";
            // 
            // DetailTypetextBox
            // 
            DetailTypetextBox.BackColor = Color.WhiteSmoke;
            DetailTypetextBox.Location = new Point(160, 118);
            DetailTypetextBox.Name = "DetailTypetextBox";
            DetailTypetextBox.ReadOnly = true;
            DetailTypetextBox.Size = new Size(200, 24);
            DetailTypetextBox.TabIndex = 2;
            // 
            // DetailAmountlabel
            // 
            DetailAmountlabel.AutoSize = true;
            DetailAmountlabel.Location = new Point(20, 167);
            DetailAmountlabel.Name = "DetailAmountlabel";
            DetailAmountlabel.Size = new Size(62, 17);
            DetailAmountlabel.TabIndex = 3;
            DetailAmountlabel.Text = "Amount :";
            // 
            // DetailAmounttextBox
            // 
            DetailAmounttextBox.BackColor = Color.WhiteSmoke;
            DetailAmounttextBox.Location = new Point(160, 162);
            DetailAmounttextBox.Name = "DetailAmounttextBox";
            DetailAmounttextBox.ReadOnly = true;
            DetailAmounttextBox.Size = new Size(200, 24);
            DetailAmounttextBox.TabIndex = 3;
            // 
            // DetailDatelabel
            // 
            DetailDatelabel.AutoSize = true;
            DetailDatelabel.Location = new Point(20, 211);
            DetailDatelabel.Name = "DetailDatelabel";
            DetailDatelabel.Size = new Size(44, 17);
            DetailDatelabel.TabIndex = 4;
            DetailDatelabel.Text = "Date :";
            // 
            // DetailDatetextBox
            // 
            DetailDatetextBox.BackColor = Color.WhiteSmoke;
            DetailDatetextBox.Location = new Point(160, 206);
            DetailDatetextBox.Name = "DetailDatetextBox";
            DetailDatetextBox.ReadOnly = true;
            DetailDatetextBox.Size = new Size(200, 24);
            DetailDatetextBox.TabIndex = 4;
            // 
            // DetailPaymentMethodlabel
            // 
            DetailPaymentMethodlabel.AutoSize = true;
            DetailPaymentMethodlabel.Location = new Point(20, 255);
            DetailPaymentMethodlabel.Name = "DetailPaymentMethodlabel";
            DetailPaymentMethodlabel.Size = new Size(116, 17);
            DetailPaymentMethodlabel.TabIndex = 5;
            DetailPaymentMethodlabel.Text = "Payment Method :";
            // 
            // DetailPaymentMethodtextBox
            // 
            DetailPaymentMethodtextBox.BackColor = Color.WhiteSmoke;
            DetailPaymentMethodtextBox.Location = new Point(160, 250);
            DetailPaymentMethodtextBox.Name = "DetailPaymentMethodtextBox";
            DetailPaymentMethodtextBox.ReadOnly = true;
            DetailPaymentMethodtextBox.Size = new Size(200, 24);
            DetailPaymentMethodtextBox.TabIndex = 5;
            // 
            // DetailBranchIDlabel
            // 
            DetailBranchIDlabel.AutoSize = true;
            DetailBranchIDlabel.Location = new Point(20, 299);
            DetailBranchIDlabel.Name = "DetailBranchIDlabel";
            DetailBranchIDlabel.Size = new Size(78, 17);
            DetailBranchIDlabel.TabIndex = 6;
            DetailBranchIDlabel.Text = "Branch ID :";
            // 
            // DetailBranchIDtextBox
            // 
            DetailBranchIDtextBox.BackColor = Color.WhiteSmoke;
            DetailBranchIDtextBox.Location = new Point(160, 294);
            DetailBranchIDtextBox.Name = "DetailBranchIDtextBox";
            DetailBranchIDtextBox.ReadOnly = true;
            DetailBranchIDtextBox.Size = new Size(200, 24);
            DetailBranchIDtextBox.TabIndex = 6;
            // 
            // DetailSubmittedBylabel
            // 
            DetailSubmittedBylabel.AutoSize = true;
            DetailSubmittedBylabel.Location = new Point(20, 343);
            DetailSubmittedBylabel.Name = "DetailSubmittedBylabel";
            DetailSubmittedBylabel.Size = new Size(94, 17);
            DetailSubmittedBylabel.TabIndex = 7;
            DetailSubmittedBylabel.Text = "Submitted By :";
            // 
            // DetailSubmittedBytextBox
            // 
            DetailSubmittedBytextBox.BackColor = Color.WhiteSmoke;
            DetailSubmittedBytextBox.Location = new Point(160, 338);
            DetailSubmittedBytextBox.Name = "DetailSubmittedBytextBox";
            DetailSubmittedBytextBox.ReadOnly = true;
            DetailSubmittedBytextBox.Size = new Size(200, 24);
            DetailSubmittedBytextBox.TabIndex = 7;
            // 
            // Receiptlabel
            // 
            Receiptlabel.AutoSize = true;
            Receiptlabel.Location = new Point(20, 395);
            Receiptlabel.Name = "Receiptlabel";
            Receiptlabel.Size = new Size(60, 17);
            Receiptlabel.TabIndex = 8;
            Receiptlabel.Text = "Receipt :";
            // 
            // ReceiptpictureBox
            // 
            ReceiptpictureBox.BorderStyle = BorderStyle.FixedSingle;
            ReceiptpictureBox.Location = new Point(160, 390);
            ReceiptpictureBox.Name = "ReceiptpictureBox";
            ReceiptpictureBox.Size = new Size(200, 150);
            ReceiptpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ReceiptpictureBox.TabIndex = 9;
            ReceiptpictureBox.TabStop = false;
            // 
            // ApproverNoteslabel
            // 
            ApproverNoteslabel.AutoSize = true;
            ApproverNoteslabel.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            ApproverNoteslabel.ForeColor = Color.Firebrick;
            ApproverNoteslabel.Location = new Point(13, 558);
            ApproverNoteslabel.Name = "ApproverNoteslabel";
            ApproverNoteslabel.Size = new Size(123, 17);
            ApproverNoteslabel.TabIndex = 10;
            ApproverNoteslabel.Text = "Approver Notes :";
            // 
            // ApproverNotesrichtextBox
            // 
            ApproverNotesrichtextBox.Location = new Point(160, 550);
            ApproverNotesrichtextBox.Name = "ApproverNotesrichtextBox";
            ApproverNotesrichtextBox.Size = new Size(200, 80);
            ApproverNotesrichtextBox.TabIndex = 8;
            ApproverNotesrichtextBox.Text = "";
            // 
            // ActionpanelPanel
            // 
            ActionpanelPanel.BackColor = Color.WhiteSmoke;
            ActionpanelPanel.BorderStyle = BorderStyle.FixedSingle;
            ActionpanelPanel.Controls.Add(Approvebutton);
            ActionpanelPanel.Controls.Add(Rejectbutton);
            ActionpanelPanel.Dock = DockStyle.Bottom;
            ActionpanelPanel.Location = new Point(0, 630);
            ActionpanelPanel.Name = "ActionpanelPanel";
            ActionpanelPanel.Size = new Size(371, 60);
            ActionpanelPanel.TabIndex = 1;
            // 
            // Approvebutton
            // 
            Approvebutton.BackColor = Color.OliveDrab;
            Approvebutton.Enabled = false;
            Approvebutton.ForeColor = Color.White;
            Approvebutton.Location = new Point(20, 12);
            Approvebutton.Name = "Approvebutton";
            Approvebutton.Size = new Size(150, 38);
            Approvebutton.TabIndex = 0;
            Approvebutton.Text = "✔  Approve";
            Approvebutton.UseVisualStyleBackColor = false;
            Approvebutton.Click += Approvebutton_Click;
            // 
            // Rejectbutton
            // 
            Rejectbutton.BackColor = Color.Firebrick;
            Rejectbutton.Enabled = false;
            Rejectbutton.ForeColor = Color.White;
            Rejectbutton.Location = new Point(185, 12);
            Rejectbutton.Name = "Rejectbutton";
            Rejectbutton.Size = new Size(150, 38);
            Rejectbutton.TabIndex = 1;
            Rejectbutton.Text = "✘  Reject";
            Rejectbutton.UseVisualStyleBackColor = false;
            Rejectbutton.Click += Rejectbutton_Click;
            // 
            // FooterpanelPanel
            // 
            FooterpanelPanel.BackColor = Color.WhiteSmoke;
            FooterpanelPanel.BorderStyle = BorderStyle.FixedSingle;
            FooterpanelPanel.Controls.Add(Closebutton);
            FooterpanelPanel.Dock = DockStyle.Bottom;
            FooterpanelPanel.Location = new Point(0, 745);
            FooterpanelPanel.Name = "FooterpanelPanel";
            FooterpanelPanel.Size = new Size(1463, 55);
            FooterpanelPanel.TabIndex = 4;
            // 
            // Closebutton
            // 
            Closebutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Closebutton.BackColor = Color.Red;
            Closebutton.ForeColor = Color.White;
            Closebutton.Location = new Point(1333, 10);
            Closebutton.Name = "Closebutton";
            Closebutton.Size = new Size(110, 36);
            Closebutton.TabIndex = 0;
            Closebutton.Text = "Close";
            Closebutton.UseVisualStyleBackColor = false;
            Closebutton.Click += Closebutton_Click;
            // 
            // ApproveExpenseGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1463, 800);
            Controls.Add(MainsplitContainer);
            Controls.Add(FooterpanelPanel);
            Controls.Add(SearchpanelPanel);
            Font = new Font("Times New Roman", 11F);
            MinimumSize = new Size(1100, 680);
            Name = "ApproveExpenseGUI";
            Text = "Expense Approval";
            WindowState = FormWindowState.Maximized;
            Load += ApproveExpenseGUI_Load;
            SearchpanelPanel.ResumeLayout(false);
            SearchpanelPanel.PerformLayout();
            MainsplitContainer.Panel1.ResumeLayout(false);
            MainsplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainsplitContainer).EndInit();
            MainsplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PendingExpensesdataGridView).EndInit();
            DetailpanelPanel.ResumeLayout(false);
            DetailGroupBox.ResumeLayout(false);
            DetailGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ReceiptpictureBox).EndInit();
            ActionpanelPanel.ResumeLayout(false);
            FooterpanelPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel SearchpanelPanel;
        private Label Searchlabel;
        private TextBox SearchtextBox;
        private Button Searchbutton;
        private Button Refreshbutton;
        private Label PendingCountlabel;
        private SplitContainer MainsplitContainer;
        private DataGridView PendingExpensesdataGridView;
        private Panel DetailpanelPanel;
        private GroupBox DetailGroupBox;
        private Label DetailExpenseIDlabel;
        private TextBox DetailExpenseIDtextBox;
        private Label DetailDescriptionlabel;
        private TextBox DetailDescriptiontextBox;
        private Label DetailTypelabel;
        private TextBox DetailTypetextBox;
        private Label DetailAmountlabel;
        private TextBox DetailAmounttextBox;
        private Label DetailDatelabel;
        private TextBox DetailDatetextBox;
        private Label DetailPaymentMethodlabel;
        private TextBox DetailPaymentMethodtextBox;
        private Label DetailBranchIDlabel;
        private TextBox DetailBranchIDtextBox;
        private Label DetailSubmittedBylabel;
        private TextBox DetailSubmittedBytextBox;
        private Label Receiptlabel;
        private PictureBox ReceiptpictureBox;
        private Label ApproverNoteslabel;
        private RichTextBox ApproverNotesrichtextBox;
        private Panel ActionpanelPanel;
        private Button Approvebutton;
        private Button Rejectbutton;
        private Panel FooterpanelPanel;
        private Button Closebutton;
    }
}
