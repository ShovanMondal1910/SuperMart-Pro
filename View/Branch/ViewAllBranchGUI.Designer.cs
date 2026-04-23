namespace SuperMart_Pro.View.Branch
{
    partial class ViewAllBranchGUI
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
            HeaderTitlelabel = new Label();
            SearchpanelPanel = new Panel();
            Searchlabel = new Label();
            SearchtextBox = new TextBox();
            Searchbutton = new Button();
            Refreshbutton = new Button();
            TotalRecordslabel = new Label();
            BranchdataGridView = new DataGridView();
            FooterpanelPanel = new Panel();
            Closebutton = new Button();

            Headerpanel.SuspendLayout();
            SearchpanelPanel.SuspendLayout();
            FooterpanelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BranchdataGridView).BeginInit();
            SuspendLayout();

            // ── Headerpanel ──────────────────────────────────────────────
            Headerpanel.BackColor = Color.Tomato;
            Headerpanel.Dock = DockStyle.Top;
            Headerpanel.Height = 65;
            Headerpanel.Name = "Headerpanel";
            Headerpanel.TabIndex = 0;
            Headerpanel.Controls.Add(HeaderTitlelabel);

            // HeaderTitlelabel
            HeaderTitlelabel.AutoSize = true;
            HeaderTitlelabel.ForeColor = Color.White;
            HeaderTitlelabel.Font = new Font("Times New Roman", 22F, FontStyle.Bold);
            HeaderTitlelabel.Text = "View All Branches";
            HeaderTitlelabel.Location = new Point(20, 14);
            HeaderTitlelabel.Name = "HeaderTitlelabel";
            HeaderTitlelabel.TabIndex = 0;

            // ── SearchpanelPanel ─────────────────────────────────────────
            SearchpanelPanel.BackColor = Color.WhiteSmoke;
            SearchpanelPanel.BorderStyle = BorderStyle.FixedSingle;
            SearchpanelPanel.Dock = DockStyle.Top;
            SearchpanelPanel.Height = 55;
            SearchpanelPanel.Name = "SearchpanelPanel";
            SearchpanelPanel.TabIndex = 1;
            SearchpanelPanel.Controls.Add(Searchlabel);
            SearchpanelPanel.Controls.Add(SearchtextBox);
            SearchpanelPanel.Controls.Add(Searchbutton);
            SearchpanelPanel.Controls.Add(Refreshbutton);
            SearchpanelPanel.Controls.Add(TotalRecordslabel);

            // Searchlabel
            Searchlabel.AutoSize = true;
            Searchlabel.Location = new Point(15, 15);
            Searchlabel.Name = "Searchlabel";
            Searchlabel.TabIndex = 0;
            Searchlabel.Text = "Search :";

            // SearchtextBox
            SearchtextBox.Location = new Point(100, 13);
            SearchtextBox.Name = "SearchtextBox";
            SearchtextBox.Size = new Size(300, 29);
            SearchtextBox.TabIndex = 1;

            // Searchbutton
            Searchbutton.BackColor = Color.SteelBlue;
            Searchbutton.ForeColor = Color.White;
            Searchbutton.Location = new Point(415, 11);
            Searchbutton.Name = "Searchbutton";
            Searchbutton.Size = new Size(100, 33);
            Searchbutton.TabIndex = 2;
            Searchbutton.Text = "Search";
            Searchbutton.UseVisualStyleBackColor = false;
            Searchbutton.Click += Searchbutton_Click;

            // Refreshbutton
            Refreshbutton.BackColor = Color.Tan;
            Refreshbutton.Location = new Point(525, 11);
            Refreshbutton.Name = "Refreshbutton";
            Refreshbutton.Size = new Size(100, 33);
            Refreshbutton.TabIndex = 3;
            Refreshbutton.Text = "Refresh";
            Refreshbutton.UseVisualStyleBackColor = false;
            Refreshbutton.Click += Refreshbutton_Click;

            // TotalRecordslabel
            TotalRecordslabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TotalRecordslabel.AutoSize = true;
            TotalRecordslabel.Location = new Point(1150, 15);
            TotalRecordslabel.Name = "TotalRecordslabel";
            TotalRecordslabel.TabIndex = 4;
            TotalRecordslabel.Text = "Total Records: 0";

            // ── FooterpanelPanel ─────────────────────────────────────────
            FooterpanelPanel.BackColor = Color.WhiteSmoke;
            FooterpanelPanel.BorderStyle = BorderStyle.FixedSingle;
            FooterpanelPanel.Dock = DockStyle.Bottom;
            FooterpanelPanel.Height = 55;
            FooterpanelPanel.Name = "FooterpanelPanel";
            FooterpanelPanel.TabIndex = 3;
            FooterpanelPanel.Controls.Add(Closebutton);

            // Closebutton
            Closebutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Closebutton.BackColor = Color.Red;
            Closebutton.ForeColor = Color.White;
            Closebutton.Location = new Point(1260, 10);
            Closebutton.Name = "Closebutton";
            Closebutton.Size = new Size(110, 36);
            Closebutton.TabIndex = 0;
            Closebutton.Text = "Close";
            Closebutton.UseVisualStyleBackColor = false;
            Closebutton.Click += Closebutton_Click;

            // ── BranchdataGridView ────────────────────────────────────────
            BranchdataGridView.AllowUserToAddRows = false;
            BranchdataGridView.AllowUserToDeleteRows = false;
            BranchdataGridView.Dock = DockStyle.Fill;
            BranchdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BranchdataGridView.BackgroundColor = Color.White;
            BranchdataGridView.BorderStyle = BorderStyle.None;
            BranchdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BranchdataGridView.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Tomato,
                ForeColor = Color.White,
                Font = new Font("Times New Roman", 11F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
            BranchdataGridView.EnableHeadersVisualStyles = false;
            BranchdataGridView.Name = "BranchdataGridView";
            BranchdataGridView.ReadOnly = true;
            BranchdataGridView.RowHeadersWidth = 40;
            BranchdataGridView.RowTemplate.Height = 32;
            BranchdataGridView.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.FromArgb(245, 245, 245) };
            BranchdataGridView.GridColor = Color.LightGray;
            BranchdataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BranchdataGridView.ScrollBars = ScrollBars.Both;
            BranchdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BranchdataGridView.TabIndex = 2;
            BranchdataGridView.SelectionChanged += BranchdataGridView_SelectionChanged;

            // ── ViewAllBranchGUI ──────────────────────────────────────────
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 800);
            Controls.Add(BranchdataGridView);
            Controls.Add(FooterpanelPanel);
            Controls.Add(SearchpanelPanel);
            Controls.Add(Headerpanel);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ViewAllBranchGUI";
            Text = "View All Branches";
            WindowState = FormWindowState.Maximized;
            Load += ViewAllBranchGUI_Load;

            Headerpanel.ResumeLayout(false);
            Headerpanel.PerformLayout();
            SearchpanelPanel.ResumeLayout(false);
            SearchpanelPanel.PerformLayout();
            FooterpanelPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BranchdataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Headerpanel;
        private Label HeaderTitlelabel;
        private Panel SearchpanelPanel;
        private Label Searchlabel;
        private TextBox SearchtextBox;
        private Button Searchbutton;
        private Button Refreshbutton;
        private Label TotalRecordslabel;
        private DataGridView BranchdataGridView;
        private Panel FooterpanelPanel;
        private Button Closebutton;
    }
}
