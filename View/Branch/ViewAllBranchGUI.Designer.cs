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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)BranchdataGridView).BeginInit();
            FooterpanelPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Headerpanel
            // 
            Headerpanel.BackColor = Color.Tomato;
            Headerpanel.Controls.Add(HeaderTitlelabel);
            Headerpanel.Dock = DockStyle.Top;
            Headerpanel.Location = new Point(0, 0);
            Headerpanel.Name = "Headerpanel";
            Headerpanel.Size = new Size(1400, 65);
            Headerpanel.TabIndex = 0;
            // 
            // HeaderTitlelabel
            // 
            HeaderTitlelabel.AutoSize = true;
            HeaderTitlelabel.Font = new Font("Times New Roman", 22F, FontStyle.Bold);
            HeaderTitlelabel.ForeColor = Color.White;
            HeaderTitlelabel.Location = new Point(20, 14);
            HeaderTitlelabel.Name = "HeaderTitlelabel";
            HeaderTitlelabel.Size = new Size(245, 35);
            HeaderTitlelabel.TabIndex = 0;
            HeaderTitlelabel.Text = "View All Branches";
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
            SearchpanelPanel.Location = new Point(0, 65);
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
            TotalRecordslabel.Location = new Point(2350, 15);
            TotalRecordslabel.Name = "TotalRecordslabel";
            TotalRecordslabel.Size = new Size(135, 21);
            TotalRecordslabel.TabIndex = 4;
            TotalRecordslabel.Text = "Total Records: 0";
            // 
            // BranchdataGridView
            // 
            BranchdataGridView.AllowUserToAddRows = false;
            BranchdataGridView.AllowUserToDeleteRows = false;
            BranchdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BranchdataGridView.BackgroundColor = Color.White;
            BranchdataGridView.BorderStyle = BorderStyle.None;
            BranchdataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BranchdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            BranchdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BranchdataGridView.Dock = DockStyle.Fill;
            BranchdataGridView.EnableHeadersVisualStyles = false;
            BranchdataGridView.GridColor = Color.LightGray;
            BranchdataGridView.Location = new Point(0, 120);
            BranchdataGridView.Name = "BranchdataGridView";
            BranchdataGridView.ReadOnly = true;
            BranchdataGridView.RowHeadersWidth = 40;
            BranchdataGridView.RowTemplate.Height = 32;
            BranchdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BranchdataGridView.Size = new Size(1400, 625);
            BranchdataGridView.TabIndex = 2;
            BranchdataGridView.SelectionChanged += BranchdataGridView_SelectionChanged;
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
            FooterpanelPanel.TabIndex = 3;
            // 
            // Closebutton
            // 
            Closebutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Closebutton.BackColor = Color.Red;
            Closebutton.ForeColor = Color.White;
            Closebutton.Location = new Point(2460, 10);
            Closebutton.Name = "Closebutton";
            Closebutton.Size = new Size(110, 36);
            Closebutton.TabIndex = 0;
            Closebutton.Text = "Close";
            Closebutton.UseVisualStyleBackColor = false;
            Closebutton.Click += Closebutton_Click;
            // 
            // ViewAllBranchGUI
            // 
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
            Load += ViewAllBranchGUI_Load;
            Headerpanel.ResumeLayout(false);
            Headerpanel.PerformLayout();
            SearchpanelPanel.ResumeLayout(false);
            SearchpanelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BranchdataGridView).EndInit();
            FooterpanelPanel.ResumeLayout(false);
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
