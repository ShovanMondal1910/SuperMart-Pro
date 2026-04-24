namespace SuperMart_Pro.View.Product
{
    partial class ViewAllProductGUI
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
            ProductdataGridView = new DataGridView();
            Closebutton = new Button();
            TotalRecordslabel = new Label();
            Refreshbutton = new Button();
            Searchbutton = new Button();
            SearchtextBox = new TextBox();
            Searchlabel = new Label();
            SearchpanelPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)ProductdataGridView).BeginInit();
            SearchpanelPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ProductdataGridView
            // 
            ProductdataGridView.AllowUserToAddRows = false;
            ProductdataGridView.AllowUserToDeleteRows = false;
            ProductdataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ProductdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductdataGridView.BackgroundColor = Color.White;
            ProductdataGridView.BorderStyle = BorderStyle.None;
            ProductdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductdataGridView.Location = new Point(0, 70);
            ProductdataGridView.Name = "ProductdataGridView";
            ProductdataGridView.ReadOnly = true;
            ProductdataGridView.RowHeadersWidth = 40;
            ProductdataGridView.RowTemplate.Height = 30;
            ProductdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductdataGridView.Size = new Size(1400, 635);
            ProductdataGridView.TabIndex = 2;
            ProductdataGridView.SelectionChanged += ProductdataGridView_SelectionChanged;
            // 
            // Closebutton
            // 
            Closebutton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Closebutton.BackColor = Color.Red;
            Closebutton.ForeColor = Color.White;
            Closebutton.Location = new Point(1260, 720);
            Closebutton.Name = "Closebutton";
            Closebutton.Size = new Size(110, 38);
            Closebutton.TabIndex = 3;
            Closebutton.Text = "Close";
            Closebutton.UseVisualStyleBackColor = false;
            Closebutton.Click += Closebutton_Click;
            // 
            // TotalRecordslabel
            // 
            TotalRecordslabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TotalRecordslabel.AutoSize = true;
            TotalRecordslabel.Location = new Point(1200, 18);
            TotalRecordslabel.Name = "TotalRecordslabel";
            TotalRecordslabel.Size = new Size(135, 21);
            TotalRecordslabel.TabIndex = 4;
            TotalRecordslabel.Text = "Total Records: 0";
            // 
            // Refreshbutton
            // 
            Refreshbutton.BackColor = Color.Tan;
            Refreshbutton.Location = new Point(500, 13);
            Refreshbutton.Name = "Refreshbutton";
            Refreshbutton.Size = new Size(90, 33);
            Refreshbutton.TabIndex = 3;
            Refreshbutton.Text = "Refresh";
            Refreshbutton.UseVisualStyleBackColor = false;
            Refreshbutton.Click += Refreshbutton_Click;
            // 
            // Searchbutton
            // 
            Searchbutton.BackColor = Color.SteelBlue;
            Searchbutton.ForeColor = Color.White;
            Searchbutton.Location = new Point(395, 13);
            Searchbutton.Name = "Searchbutton";
            Searchbutton.Size = new Size(90, 33);
            Searchbutton.TabIndex = 2;
            Searchbutton.Text = "Search";
            Searchbutton.UseVisualStyleBackColor = false;
            Searchbutton.Click += Searchbutton_Click;
            // 
            // SearchtextBox
            // 
            SearchtextBox.Location = new Point(100, 15);
            SearchtextBox.Name = "SearchtextBox";
            SearchtextBox.Size = new Size(280, 29);
            SearchtextBox.TabIndex = 1;
            // 
            // Searchlabel
            // 
            Searchlabel.AutoSize = true;
            Searchlabel.Location = new Point(20, 18);
            Searchlabel.Name = "Searchlabel";
            Searchlabel.Size = new Size(70, 21);
            Searchlabel.TabIndex = 0;
            Searchlabel.Text = "Search :";
            // 
            // SearchpanelPanel
            // 
            SearchpanelPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SearchpanelPanel.BackColor = Color.WhiteSmoke;
            SearchpanelPanel.BorderStyle = BorderStyle.FixedSingle;
            SearchpanelPanel.Controls.Add(Searchlabel);
            SearchpanelPanel.Controls.Add(SearchtextBox);
            SearchpanelPanel.Controls.Add(Searchbutton);
            SearchpanelPanel.Controls.Add(Refreshbutton);
            SearchpanelPanel.Controls.Add(TotalRecordslabel);
            SearchpanelPanel.Location = new Point(0, 4);
            SearchpanelPanel.Name = "SearchpanelPanel";
            SearchpanelPanel.Size = new Size(1400, 60);
            SearchpanelPanel.TabIndex = 1;
            // 
            // ViewAllProductGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 775);
            Controls.Add(Closebutton);
            Controls.Add(ProductdataGridView);
            Controls.Add(SearchpanelPanel);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ViewAllProductGUI";
            Text = "View All Products";
            WindowState = FormWindowState.Maximized;
            Load += ViewAllProductGUI_Load;
            ((System.ComponentModel.ISupportInitialize)ProductdataGridView).EndInit();
            SearchpanelPanel.ResumeLayout(false);
            SearchpanelPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView ProductdataGridView;
        private Button Closebutton;
        private Label TotalRecordslabel;
        private Button Refreshbutton;
        private Button Searchbutton;
        private TextBox SearchtextBox;
        private Label Searchlabel;
        private Panel SearchpanelPanel;
    }
}
