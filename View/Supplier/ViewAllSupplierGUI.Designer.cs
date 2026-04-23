namespace SuperMart_Pro.View.Supplier
{
    partial class ViewAllSupplierGUI
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
            SearchpanelPanel = new Panel();
            Searchlabel = new Label();
            SearchtextBox = new TextBox();
            Searchbutton = new Button();
            Refreshbutton = new Button();
            TotalRecordslabel = new Label();
            SupplierdataGridView = new DataGridView();
            Closebutton = new Button();
            SearchpanelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SupplierdataGridView).BeginInit();
            SuspendLayout();

            // Headerpanel
            Headerpanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Headerpanel.BackColor = Color.Tomato;
            Headerpanel.Location = new Point(0, 0);
            Headerpanel.Name = "Headerpanel";
            Headerpanel.Size = new Size(1400, 85);
            Headerpanel.TabIndex = 0;

            // SearchpanelPanel
            SearchpanelPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SearchpanelPanel.BackColor = Color.WhiteSmoke;
            SearchpanelPanel.BorderStyle = BorderStyle.FixedSingle;
            SearchpanelPanel.Controls.Add(Searchlabel);
            SearchpanelPanel.Controls.Add(SearchtextBox);
            SearchpanelPanel.Controls.Add(Searchbutton);
            SearchpanelPanel.Controls.Add(Refreshbutton);
            SearchpanelPanel.Controls.Add(TotalRecordslabel);
            SearchpanelPanel.Location = new Point(0, 85);
            SearchpanelPanel.Name = "SearchpanelPanel";
            SearchpanelPanel.Size = new Size(1400, 60);
            SearchpanelPanel.TabIndex = 1;

            // Searchlabel
            Searchlabel.AutoSize = true;
            Searchlabel.Location = new Point(20, 18);
            Searchlabel.Name = "Searchlabel";
            Searchlabel.TabIndex = 0;
            Searchlabel.Text = "Search :";

            // SearchtextBox
            SearchtextBox.Location = new Point(100, 15);
            SearchtextBox.Name = "SearchtextBox";
            SearchtextBox.Size = new Size(280, 29);
            SearchtextBox.TabIndex = 1;

            // Searchbutton
            Searchbutton.BackColor = Color.SteelBlue;
            Searchbutton.ForeColor = Color.White;
            Searchbutton.Location = new Point(395, 13);
            Searchbutton.Name = "Searchbutton";
            Searchbutton.Size = new Size(90, 33);
            Searchbutton.TabIndex = 2;
            Searchbutton.Text = "Search";
            Searchbutton.UseVisualStyleBackColor = false;
            Searchbutton.Click += Searchbutton_Click;

            // Refreshbutton
            Refreshbutton.BackColor = Color.Tan;
            Refreshbutton.Location = new Point(500, 13);
            Refreshbutton.Name = "Refreshbutton";
            Refreshbutton.Size = new Size(90, 33);
            Refreshbutton.TabIndex = 3;
            Refreshbutton.Text = "Refresh";
            Refreshbutton.UseVisualStyleBackColor = false;
            Refreshbutton.Click += Refreshbutton_Click;

            // TotalRecordslabel
            TotalRecordslabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TotalRecordslabel.AutoSize = true;
            TotalRecordslabel.Location = new Point(1200, 18);
            TotalRecordslabel.Name = "TotalRecordslabel";
            TotalRecordslabel.TabIndex = 4;
            TotalRecordslabel.Text = "Total Records: 0";

            // SupplierdataGridView
            SupplierdataGridView.AllowUserToAddRows = false;
            SupplierdataGridView.AllowUserToDeleteRows = false;
            SupplierdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SupplierdataGridView.BackgroundColor = Color.White;
            SupplierdataGridView.BorderStyle = BorderStyle.None;
            SupplierdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SupplierdataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SupplierdataGridView.Location = new Point(0, 145);
            SupplierdataGridView.Name = "SupplierdataGridView";
            SupplierdataGridView.ReadOnly = true;
            SupplierdataGridView.RowHeadersWidth = 40;
            SupplierdataGridView.RowTemplate.Height = 30;
            SupplierdataGridView.ScrollBars = ScrollBars.Both;
            SupplierdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SupplierdataGridView.Size = new Size(1400, 560);
            SupplierdataGridView.TabIndex = 2;
            SupplierdataGridView.SelectionChanged += SupplierdataGridView_SelectionChanged;

            // Closebutton
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

            // ViewAllSupplierGUI
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 775);
            Controls.Add(Closebutton);
            Controls.Add(SupplierdataGridView);
            Controls.Add(SearchpanelPanel);
            Controls.Add(Headerpanel);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ViewAllSupplierGUI";
            Text = "View All Suppliers";
            WindowState = FormWindowState.Maximized;
            Load += ViewAllSupplierGUI_Load;
            SearchpanelPanel.ResumeLayout(false);
            SearchpanelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SupplierdataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Headerpanel;
        private Panel SearchpanelPanel;
        private Label Searchlabel;
        private TextBox SearchtextBox;
        private Button Searchbutton;
        private Button Refreshbutton;
        private Label TotalRecordslabel;
        private DataGridView SupplierdataGridView;
        private Button Closebutton;
    }
}
