namespace SuperMart_Pro.View.Expense
{
    partial class ViewAllExpenseGUI
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
            TotalRecordslabel = new Label();
            FilterpanelPanel = new Panel();
            ExpenseTypeFilterlabel = new Label();
            ExpenseTypeFiltercomboBox = new ComboBox();
            FromDatelabel = new Label();
            FromDatedatePicker = new DateTimePicker();
            ToDatelabel = new Label();
            ToDatedatePicker = new DateTimePicker();
            FilterbyDatebutton = new Button();
            ExpensedataGridView = new DataGridView();
            FooterpanelPanel = new Panel();
            Closebutton = new Button();
            SearchpanelPanel.SuspendLayout();
            FilterpanelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExpensedataGridView).BeginInit();
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
            SearchpanelPanel.Controls.Add(TotalRecordslabel);
            SearchpanelPanel.Dock = DockStyle.Top;
            SearchpanelPanel.Location = new Point(0, 0);
            SearchpanelPanel.Name = "SearchpanelPanel";
            SearchpanelPanel.Size = new Size(1400, 55);
            SearchpanelPanel.TabIndex = 1;
            // 
            // Searchlabel
            // 
            Searchlabel.AutoSize = true;
            Searchlabel.Location = new Point(15, 15);
            Searchlabel.Name = "Searchlabel";
            Searchlabel.Size = new Size(70, 21);
            Searchlabel.TabIndex = 0;
            Searchlabel.Text = "Search :";
            // 
            // SearchtextBox
            // 
            SearchtextBox.Location = new Point(100, 13);
            SearchtextBox.Name = "SearchtextBox";
            SearchtextBox.Size = new Size(300, 29);
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
            // TotalRecordslabel
            // 
            TotalRecordslabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TotalRecordslabel.AutoSize = true;
            TotalRecordslabel.Location = new Point(1240, 15);
            TotalRecordslabel.Name = "TotalRecordslabel";
            TotalRecordslabel.Size = new Size(135, 21);
            TotalRecordslabel.TabIndex = 4;
            TotalRecordslabel.Text = "Total Records: 0";
            // 
            // FilterpanelPanel
            // 
            FilterpanelPanel.BackColor = Color.AliceBlue;
            FilterpanelPanel.BorderStyle = BorderStyle.FixedSingle;
            FilterpanelPanel.Controls.Add(ExpenseTypeFilterlabel);
            FilterpanelPanel.Controls.Add(ExpenseTypeFiltercomboBox);
            FilterpanelPanel.Controls.Add(FromDatelabel);
            FilterpanelPanel.Controls.Add(FromDatedatePicker);
            FilterpanelPanel.Controls.Add(ToDatelabel);
            FilterpanelPanel.Controls.Add(ToDatedatePicker);
            FilterpanelPanel.Controls.Add(FilterbyDatebutton);
            FilterpanelPanel.Dock = DockStyle.Top;
            FilterpanelPanel.Location = new Point(0, 55);
            FilterpanelPanel.Name = "FilterpanelPanel";
            FilterpanelPanel.Size = new Size(1400, 55);
            FilterpanelPanel.TabIndex = 2;
            // 
            // ExpenseTypeFilterlabel
            // 
            ExpenseTypeFilterlabel.AutoSize = true;
            ExpenseTypeFilterlabel.Location = new Point(15, 15);
            ExpenseTypeFilterlabel.Name = "ExpenseTypeFilterlabel";
            ExpenseTypeFilterlabel.Size = new Size(57, 21);
            ExpenseTypeFilterlabel.TabIndex = 0;
            ExpenseTypeFilterlabel.Text = "Type :";
            // 
            // ExpenseTypeFiltercomboBox
            // 
            ExpenseTypeFiltercomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ExpenseTypeFiltercomboBox.FormattingEnabled = true;
            ExpenseTypeFiltercomboBox.Items.AddRange(new object[] { "All", "Food", "Transportation", "Entertainment", "Utilities", "Healthcare", "Education", "Miscellaneous" });
            ExpenseTypeFiltercomboBox.Location = new Point(70, 12);
            ExpenseTypeFiltercomboBox.Name = "ExpenseTypeFiltercomboBox";
            ExpenseTypeFiltercomboBox.Size = new Size(160, 29);
            ExpenseTypeFiltercomboBox.TabIndex = 1;
            // 
            // FromDatelabel
            // 
            FromDatelabel.AutoSize = true;
            FromDatelabel.Location = new Point(250, 15);
            FromDatelabel.Name = "FromDatelabel";
            FromDatelabel.Size = new Size(60, 21);
            FromDatelabel.TabIndex = 2;
            FromDatelabel.Text = "From :";
            // 
            // FromDatedatePicker
            // 
            FromDatedatePicker.Format = DateTimePickerFormat.Short;
            FromDatedatePicker.Location = new Point(310, 12);
            FromDatedatePicker.Name = "FromDatedatePicker";
            FromDatedatePicker.Size = new Size(150, 29);
            FromDatedatePicker.TabIndex = 3;
            // 
            // ToDatelabel
            // 
            ToDatelabel.AutoSize = true;
            ToDatelabel.Location = new Point(475, 15);
            ToDatelabel.Name = "ToDatelabel";
            ToDatelabel.Size = new Size(40, 21);
            ToDatelabel.TabIndex = 4;
            ToDatelabel.Text = "To :";
            // 
            // ToDatedatePicker
            // 
            ToDatedatePicker.Format = DateTimePickerFormat.Short;
            ToDatedatePicker.Location = new Point(515, 12);
            ToDatedatePicker.Name = "ToDatedatePicker";
            ToDatedatePicker.Size = new Size(150, 29);
            ToDatedatePicker.TabIndex = 5;
            // 
            // FilterbyDatebutton
            // 
            FilterbyDatebutton.BackColor = Color.SteelBlue;
            FilterbyDatebutton.ForeColor = Color.White;
            FilterbyDatebutton.Location = new Point(680, 11);
            FilterbyDatebutton.Name = "FilterbyDatebutton";
            FilterbyDatebutton.Size = new Size(110, 33);
            FilterbyDatebutton.TabIndex = 6;
            FilterbyDatebutton.Text = "Apply Filter";
            FilterbyDatebutton.UseVisualStyleBackColor = false;
            FilterbyDatebutton.Click += FilterbyDatebutton_Click;
            // 
            // ExpensedataGridView
            // 
            ExpensedataGridView.AllowUserToAddRows = false;
            ExpensedataGridView.AllowUserToDeleteRows = false;
            ExpensedataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ExpensedataGridView.BackgroundColor = Color.White;
            ExpensedataGridView.BorderStyle = BorderStyle.None;
            ExpensedataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.BackColor = Color.Tomato;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            ExpensedataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ExpensedataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ExpensedataGridView.Dock = DockStyle.Fill;
            ExpensedataGridView.EnableHeadersVisualStyles = false;
            ExpensedataGridView.GridColor = Color.LightGray;
            ExpensedataGridView.Location = new Point(0, 110);
            ExpensedataGridView.Name = "ExpensedataGridView";
            ExpensedataGridView.ReadOnly = true;
            ExpensedataGridView.RowHeadersWidth = 40;
            ExpensedataGridView.RowTemplate.Height = 32;
            ExpensedataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ExpensedataGridView.Size = new Size(1400, 635);
            ExpensedataGridView.TabIndex = 3;
            ExpensedataGridView.SelectionChanged += ExpensedataGridView_SelectionChanged;
            // 
            // FooterpanelPanel
            // 
            FooterpanelPanel.BackColor = Color.WhiteSmoke;
            FooterpanelPanel.BorderStyle = BorderStyle.FixedSingle;
            FooterpanelPanel.Controls.Add(Closebutton);
            FooterpanelPanel.Dock = DockStyle.Bottom;
            FooterpanelPanel.Location = new Point(0, 745);
            FooterpanelPanel.Name = "FooterpanelPanel";
            FooterpanelPanel.Size = new Size(1400, 55);
            FooterpanelPanel.TabIndex = 4;
            // 
            // Closebutton
            // 
            Closebutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Closebutton.BackColor = Color.Red;
            Closebutton.ForeColor = Color.White;
            Closebutton.Location = new Point(1270, 10);
            Closebutton.Name = "Closebutton";
            Closebutton.Size = new Size(110, 36);
            Closebutton.TabIndex = 0;
            Closebutton.Text = "Close";
            Closebutton.UseVisualStyleBackColor = false;
            Closebutton.Click += Closebutton_Click;
            // 
            // ViewAllExpenseGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 800);
            Controls.Add(ExpensedataGridView);
            Controls.Add(FooterpanelPanel);
            Controls.Add(FilterpanelPanel);
            Controls.Add(SearchpanelPanel);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ViewAllExpenseGUI";
            Text = "View All Expenses";
            WindowState = FormWindowState.Maximized;
            Load += ViewAllExpenseGUI_Load;
            SearchpanelPanel.ResumeLayout(false);
            SearchpanelPanel.PerformLayout();
            FilterpanelPanel.ResumeLayout(false);
            FilterpanelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ExpensedataGridView).EndInit();
            FooterpanelPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel SearchpanelPanel;
        private Label Searchlabel;
        private TextBox SearchtextBox;
        private Button Searchbutton;
        private Button Refreshbutton;
        private Label TotalRecordslabel;
        private Panel FilterpanelPanel;
        private Label ExpenseTypeFilterlabel;
        private ComboBox ExpenseTypeFiltercomboBox;
        private Label FromDatelabel;
        private DateTimePicker FromDatedatePicker;
        private Label ToDatelabel;
        private DateTimePicker ToDatedatePicker;
        private Button FilterbyDatebutton;
        private DataGridView ExpensedataGridView;
        private Panel FooterpanelPanel;
        private Button Closebutton;
    }
}
