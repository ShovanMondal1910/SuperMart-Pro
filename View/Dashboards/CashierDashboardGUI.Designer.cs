namespace SuperMart_Pro.View.Dashboards
{
    partial class CashierDashboardGUI
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
            this.components = new System.ComponentModel.Container();
            this.rootTable = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.flowSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCatProducts = new System.Windows.Forms.Button();
            this.flowProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.btnViewProducts = new System.Windows.Forms.Button();
            this.btnCatCashiers = new System.Windows.Forms.Button();
            this.flowCashiers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnViewCashiers = new System.Windows.Forms.Button();
            this.btnCatSuppliers = new System.Windows.Forms.Button();
            this.flowSuppliers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnViewSuppliers = new System.Windows.Forms.Button();
            this.btnCatManagers = new System.Windows.Forms.Button();
            this.flowManagers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnViewManagers = new System.Windows.Forms.Button();
            this.btnCatCustomers = new System.Windows.Forms.Button();
            this.flowCustomers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnViewCustomers = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.pnlSidebarSpacer = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // rootTable
            this.rootTable.BackColor = System.Drawing.Color.FromArgb(240,243,248);
            this.rootTable.ColumnCount = 2;
            this.rootTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.rootTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootTable.Controls.Add(this.pnlHeader, 0, 0);
            this.rootTable.Controls.Add(this.pnlSidebar, 0, 1);
            this.rootTable.Controls.Add(this.contentPanel, 1, 1);
            this.rootTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootTable.Location = new System.Drawing.Point(0,0);
            this.rootTable.Margin = new System.Windows.Forms.Padding(0);
            this.rootTable.Name = "rootTable";
            this.rootTable.RowCount = 2;
            this.rootTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.rootTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootTable.SetColumnSpan(this.pnlHeader, 2);
            this.rootTable.Size = new System.Drawing.Size(1400,860);
            this.rootTable.TabIndex = 0;
            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(20,28,44);
            this.pnlHeader.Controls.Add(this.lblLogo);
            this.pnlHeader.Controls.Add(this.lblRole);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1400,60);
            this.pnlHeader.TabIndex = 0;
            // lblLogo
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(16,14);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "SuperMart Pro";
            // lblRole
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(160,175,200);
            this.lblRole.Location = new System.Drawing.Point(1250,20);
            this.lblRole.Name = "lblRole";
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Cashier Dashboard";
            // pnlSidebar
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(28,37,54);
            this.pnlSidebar.Controls.Add(this.flowSidebar);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(240,800);
            this.pnlSidebar.TabIndex = 1;
            // flowSidebar
            this.flowSidebar.AutoScroll = true;
            this.flowSidebar.BackColor = System.Drawing.Color.FromArgb(28,37,54);
            this.flowSidebar.Controls.Add(this.btnCatProducts);
            this.flowSidebar.Controls.Add(this.flowProducts);
            this.flowSidebar.Controls.Add(this.btnCatCashiers);
            this.flowSidebar.Controls.Add(this.flowCashiers);
            this.flowSidebar.Controls.Add(this.btnCatSuppliers);
            this.flowSidebar.Controls.Add(this.flowSuppliers);
            this.flowSidebar.Controls.Add(this.btnCatManagers);
            this.flowSidebar.Controls.Add(this.flowManagers);
            this.flowSidebar.Controls.Add(this.btnCatCustomers);
            this.flowSidebar.Controls.Add(this.flowCustomers);
            this.flowSidebar.Controls.Add(this.pnlSidebarSpacer);
            this.flowSidebar.Controls.Add(this.btnLogout);
            this.flowSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowSidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.flowSidebar.Name = "flowSidebar";
            this.flowSidebar.Padding = new System.Windows.Forms.Padding(0,8,0,8);
            this.flowSidebar.Size = new System.Drawing.Size(240,800);
            this.flowSidebar.TabIndex = 0;
            this.flowSidebar.WrapContents = false;
            // btnCatProducts
            this.btnCatProducts.BackColor = System.Drawing.Color.FromArgb(38,50,72);
            this.btnCatProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatProducts.FlatAppearance.BorderSize = 0;
            this.btnCatProducts.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnCatProducts.ForeColor = System.Drawing.Color.White;
            this.btnCatProducts.Margin = new System.Windows.Forms.Padding(0,2,0,0);
            this.btnCatProducts.Name = "btnCatProducts";
            this.btnCatProducts.Size = new System.Drawing.Size(240,42);
            this.btnCatProducts.TabIndex = 0;
            this.btnCatProducts.Text = "  > Products";
            this.btnCatProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // flowProducts
            this.flowProducts.AutoSize = true;
            this.flowProducts.BackColor = System.Drawing.Color.FromArgb(22,30,46);
            this.flowProducts.Controls.Add(this.btnViewProducts);
            this.flowProducts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowProducts.Margin = new System.Windows.Forms.Padding(0);
            this.flowProducts.Name = "flowProducts";
            this.flowProducts.Padding = new System.Windows.Forms.Padding(0);
            this.flowProducts.Size = new System.Drawing.Size(240,38);
            this.flowProducts.TabIndex = 1;
            this.flowProducts.Visible = false;
            this.flowProducts.WrapContents = false;
            // btnViewProducts
            this.btnViewProducts.BackColor = System.Drawing.Color.FromArgb(22,30,46);
            this.btnViewProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProducts.FlatAppearance.BorderSize = 0;
            this.btnViewProducts.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.btnViewProducts.ForeColor = System.Drawing.Color.FromArgb(160,175,200);
            this.btnViewProducts.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Size = new System.Drawing.Size(240,38);
            this.btnViewProducts.TabIndex = 0;
            this.btnViewProducts.Text = "    View All Products";
            this.btnViewProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // btnCatCashiers
            this.btnCatCashiers.BackColor = System.Drawing.Color.FromArgb(38,50,72);
            this.btnCatCashiers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatCashiers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatCashiers.FlatAppearance.BorderSize = 0;
            this.btnCatCashiers.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnCatCashiers.ForeColor = System.Drawing.Color.White;
            this.btnCatCashiers.Margin = new System.Windows.Forms.Padding(0,2,0,0);
            this.btnCatCashiers.Name = "btnCatCashiers";
            this.btnCatCashiers.Size = new System.Drawing.Size(240,42);
            this.btnCatCashiers.TabIndex = 2;
            this.btnCatCashiers.Text = "  > Cashiers";
            this.btnCatCashiers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // flowCashiers
            this.flowCashiers.AutoSize = true;
            this.flowCashiers.BackColor = System.Drawing.Color.FromArgb(22,30,46);
            this.flowCashiers.Controls.Add(this.btnViewCashiers);
            this.flowCashiers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowCashiers.Margin = new System.Windows.Forms.Padding(0);
            this.flowCashiers.Name = "flowCashiers";
            this.flowCashiers.Padding = new System.Windows.Forms.Padding(0);
            this.flowCashiers.Size = new System.Drawing.Size(240,38);
            this.flowCashiers.TabIndex = 3;
            this.flowCashiers.Visible = false;
            this.flowCashiers.WrapContents = false;
            // btnViewCashiers
            this.btnViewCashiers.BackColor = System.Drawing.Color.FromArgb(22,30,46);
            this.btnViewCashiers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewCashiers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCashiers.FlatAppearance.BorderSize = 0;
            this.btnViewCashiers.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.btnViewCashiers.ForeColor = System.Drawing.Color.FromArgb(160,175,200);
            this.btnViewCashiers.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewCashiers.Name = "btnViewCashiers";
            this.btnViewCashiers.Size = new System.Drawing.Size(240,38);
            this.btnViewCashiers.TabIndex = 0;
            this.btnViewCashiers.Text = "    View All Cashiers";
            this.btnViewCashiers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // btnCatSuppliers
            this.btnCatSuppliers.BackColor = System.Drawing.Color.FromArgb(38,50,72);
            this.btnCatSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatSuppliers.FlatAppearance.BorderSize = 0;
            this.btnCatSuppliers.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnCatSuppliers.ForeColor = System.Drawing.Color.White;
            this.btnCatSuppliers.Margin = new System.Windows.Forms.Padding(0,2,0,0);
            this.btnCatSuppliers.Name = "btnCatSuppliers";
            this.btnCatSuppliers.Size = new System.Drawing.Size(240,42);
            this.btnCatSuppliers.TabIndex = 4;
            this.btnCatSuppliers.Text = "  > Suppliers";
            this.btnCatSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // flowSuppliers
            this.flowSuppliers.AutoSize = true;
            this.flowSuppliers.BackColor = System.Drawing.Color.FromArgb(22,30,46);
            this.flowSuppliers.Controls.Add(this.btnViewSuppliers);
            this.flowSuppliers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowSuppliers.Margin = new System.Windows.Forms.Padding(0);
            this.flowSuppliers.Name = "flowSuppliers";
            this.flowSuppliers.Padding = new System.Windows.Forms.Padding(0);
            this.flowSuppliers.Size = new System.Drawing.Size(240,38);
            this.flowSuppliers.TabIndex = 5;
            this.flowSuppliers.Visible = false;
            this.flowSuppliers.WrapContents = false;
            // btnViewSuppliers
            this.btnViewSuppliers.BackColor = System.Drawing.Color.FromArgb(22,30,46);
            this.btnViewSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSuppliers.FlatAppearance.BorderSize = 0;
            this.btnViewSuppliers.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.btnViewSuppliers.ForeColor = System.Drawing.Color.FromArgb(160,175,200);
            this.btnViewSuppliers.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewSuppliers.Name = "btnViewSuppliers";
            this.btnViewSuppliers.Size = new System.Drawing.Size(240,38);
            this.btnViewSuppliers.TabIndex = 0;
            this.btnViewSuppliers.Text = "    View All Suppliers";
            this.btnViewSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // btnCatManagers
            this.btnCatManagers.BackColor = System.Drawing.Color.FromArgb(38,50,72);
            this.btnCatManagers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatManagers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatManagers.FlatAppearance.BorderSize = 0;
            this.btnCatManagers.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnCatManagers.ForeColor = System.Drawing.Color.White;
            this.btnCatManagers.Margin = new System.Windows.Forms.Padding(0,2,0,0);
            this.btnCatManagers.Name = "btnCatManagers";
            this.btnCatManagers.Size = new System.Drawing.Size(240,42);
            this.btnCatManagers.TabIndex = 6;
            this.btnCatManagers.Text = "  > Managers";
            this.btnCatManagers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // flowManagers
            this.flowManagers.AutoSize = true;
            this.flowManagers.BackColor = System.Drawing.Color.FromArgb(22,30,46);
            this.flowManagers.Controls.Add(this.btnViewManagers);
            this.flowManagers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowManagers.Margin = new System.Windows.Forms.Padding(0);
            this.flowManagers.Name = "flowManagers";
            this.flowManagers.Padding = new System.Windows.Forms.Padding(0);
            this.flowManagers.Size = new System.Drawing.Size(240,38);
            this.flowManagers.TabIndex = 7;
            this.flowManagers.Visible = false;
            this.flowManagers.WrapContents = false;
            // btnViewManagers
            this.btnViewManagers.BackColor = System.Drawing.Color.FromArgb(22,30,46);
            this.btnViewManagers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewManagers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewManagers.FlatAppearance.BorderSize = 0;
            this.btnViewManagers.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.btnViewManagers.ForeColor = System.Drawing.Color.FromArgb(160,175,200);
            this.btnViewManagers.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewManagers.Name = "btnViewManagers";
            this.btnViewManagers.Size = new System.Drawing.Size(240,38);
            this.btnViewManagers.TabIndex = 0;
            this.btnViewManagers.Text = "    View All Managers";
            this.btnViewManagers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // btnCatCustomers
            this.btnCatCustomers.BackColor = System.Drawing.Color.FromArgb(38,50,72);
            this.btnCatCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatCustomers.FlatAppearance.BorderSize = 0;
            this.btnCatCustomers.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnCatCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCatCustomers.Margin = new System.Windows.Forms.Padding(0,2,0,0);
            this.btnCatCustomers.Name = "btnCatCustomers";
            this.btnCatCustomers.Size = new System.Drawing.Size(240,42);
            this.btnCatCustomers.TabIndex = 8;
            this.btnCatCustomers.Text = "  > Customers";
            this.btnCatCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // flowCustomers
            this.flowCustomers.AutoSize = true;
            this.flowCustomers.BackColor = System.Drawing.Color.FromArgb(22,30,46);
            this.flowCustomers.Controls.Add(this.btnAddCustomer);
            this.flowCustomers.Controls.Add(this.btnViewCustomers);
            this.flowCustomers.Controls.Add(this.btnUpdateCustomer);
            this.flowCustomers.Controls.Add(this.btnDeleteCustomer);
            this.flowCustomers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowCustomers.Margin = new System.Windows.Forms.Padding(0);
            this.flowCustomers.Name = "flowCustomers";
            this.flowCustomers.Padding = new System.Windows.Forms.Padding(0);
            this.flowCustomers.Size = new System.Drawing.Size(240,152);
            this.flowCustomers.TabIndex = 9;
            this.flowCustomers.Visible = false;
            this.flowCustomers.WrapContents = false;
            // btnAddCustomer
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(22,30,46);
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.FromArgb(160,175,200);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(240,38);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "    Add Customer";
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // btnViewCustomers
            this.btnViewCustomers.BackColor = System.Drawing.Color.FromArgb(22,30,46);
            this.btnViewCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCustomers.FlatAppearance.BorderSize = 0;
            this.btnViewCustomers.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.btnViewCustomers.ForeColor = System.Drawing.Color.FromArgb(160,175,200);
            this.btnViewCustomers.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(240,38);
            this.btnViewCustomers.TabIndex = 1;
            this.btnViewCustomers.Text = "    View All Customers";
            this.btnViewCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // btnUpdateCustomer
            this.btnUpdateCustomer.BackColor = System.Drawing.Color.FromArgb(22,30,46);
            this.btnUpdateCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCustomer.FlatAppearance.BorderSize = 0;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.btnUpdateCustomer.ForeColor = System.Drawing.Color.FromArgb(160,175,200);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(240,38);
            this.btnUpdateCustomer.TabIndex = 2;
            this.btnUpdateCustomer.Text = "    Update Customer";
            this.btnUpdateCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // btnDeleteCustomer
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.FromArgb(22,30,46);
            this.btnDeleteCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCustomer.FlatAppearance.BorderSize = 0;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Times New Roman", 10.5F);
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.FromArgb(160,175,200);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(240,38);
            this.btnDeleteCustomer.TabIndex = 3;
            this.btnDeleteCustomer.Text = "    Delete Customer";
            this.btnDeleteCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // pnlSidebarSpacer
            this.pnlSidebarSpacer.BackColor = System.Drawing.Color.FromArgb(28,37,54);
            this.pnlSidebarSpacer.Name = "pnlSidebarSpacer";
            this.pnlSidebarSpacer.Size = new System.Drawing.Size(240,20);
            this.pnlSidebarSpacer.TabIndex = 10;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(180,30,30);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0,4,0,0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(240,44);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "  Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // contentPanel
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(240,243,248);
            this.contentPanel.Controls.Add(this.lblWelcome);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1160,800);
            this.contentPanel.TabIndex = 2;
            // lblWelcome
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(90,110,140);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1160,800);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Cashier\r\n\r\nSelect an operation from the left panel to get started.";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // CashierDashboardGUI
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240,243,248);
            this.ClientSize = new System.Drawing.Size(1400,860);
            this.Controls.Add(this.rootTable);
            this.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.MinimumSize = new System.Drawing.Size(1100,680);
            this.Name = "CashierDashboardGUI";
            this.Text = "SuperMart Pro - Cashier Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.TableLayoutPanel rootTable;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.FlowLayoutPanel flowSidebar;
        private System.Windows.Forms.Button btnCatProducts;
        private System.Windows.Forms.FlowLayoutPanel flowProducts;
        private System.Windows.Forms.Button btnViewProducts;
        private System.Windows.Forms.Button btnCatCashiers;
        private System.Windows.Forms.FlowLayoutPanel flowCashiers;
        private System.Windows.Forms.Button btnViewCashiers;
        private System.Windows.Forms.Button btnCatSuppliers;
        private System.Windows.Forms.FlowLayoutPanel flowSuppliers;
        private System.Windows.Forms.Button btnViewSuppliers;
        private System.Windows.Forms.Button btnCatManagers;
        private System.Windows.Forms.FlowLayoutPanel flowManagers;
        private System.Windows.Forms.Button btnViewManagers;
        private System.Windows.Forms.Button btnCatCustomers;
        private System.Windows.Forms.FlowLayoutPanel flowCustomers;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnViewCustomers;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Panel pnlSidebarSpacer;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label lblWelcome;
    }
}
