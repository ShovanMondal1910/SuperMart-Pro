namespace SuperMart_Pro.View.Admin
{
    partial class ViewAllAdminGUI
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
            AdmindataGridView = new DataGridView();
            FooterpanelPanel = new Panel();
            Closebutton = new Button();
            SearchpanelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdmindataGridView).BeginInit();
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
            // AdmindataGridView
            // 
            AdmindataGridView.AllowUserToAddRows = false;
            AdmindataGridView.AllowUserToDeleteRows = false;
            AdmindataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AdmindataGridView.BackgroundColor = Color.White;
            AdmindataGridView.BorderStyle = BorderStyle.None;
            AdmindataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AdmindataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            AdmindataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdmindataGridView.Dock = DockStyle.Fill;
            AdmindataGridView.EnableHeadersVisualStyles = false;
            AdmindataGridView.GridColor = Color.LightGray;
            AdmindataGridView.Location = new Point(0, 55);
            AdmindataGridView.Name = "AdmindataGridView";
            AdmindataGridView.ReadOnly = true;
            AdmindataGridView.RowHeadersWidth = 40;
            AdmindataGridView.RowTemplate.Height = 32;
            AdmindataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AdmindataGridView.Size = new Size(1400, 690);
            AdmindataGridView.TabIndex = 2;
            AdmindataGridView.SelectionChanged += AdmindataGridView_SelectionChanged;
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
            Closebutton.Location = new Point(1270, 10);
            Closebutton.Name = "Closebutton";
            Closebutton.Size = new Size(110, 36);
            Closebutton.TabIndex = 0;
            Closebutton.Text = "Close";
            Closebutton.UseVisualStyleBackColor = false;
            Closebutton.Click += Closebutton_Click;
            // 
            // ViewAllAdminGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 800);
            Controls.Add(AdmindataGridView);
            Controls.Add(FooterpanelPanel);
            Controls.Add(SearchpanelPanel);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ViewAllAdminGUI";
            Text = "View All Admins";
            WindowState = FormWindowState.Maximized;
            Load += ViewAllAdminGUI_Load;
            SearchpanelPanel.ResumeLayout(false);
            SearchpanelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdmindataGridView).EndInit();
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
        private DataGridView AdmindataGridView;
        private Panel FooterpanelPanel;
        private Button Closebutton;
    }
}
