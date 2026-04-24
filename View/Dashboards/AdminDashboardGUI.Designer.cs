namespace SuperMart_Pro.View.Dashboards
{
    partial class AdminDashboardGUI
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
            rootTable = new TableLayoutPanel();
            pnlHeader = new Panel();
            lblLogo = new Label();
            lblRole = new Label();
            pnlSidebar = new Panel();
            flowSidebar = new FlowLayoutPanel();
            btnCatAdmins = new Button();
            flowAdmins = new FlowLayoutPanel();
            btnAddAdmin = new Button();
            btnViewAdmins = new Button();
            btnUpdateAdmin = new Button();
            btnDeleteAdmin = new Button();
            btnCatManagers = new Button();
            flowManagers = new FlowLayoutPanel();
            btnAddManager = new Button();
            btnViewManagers = new Button();
            btnUpdateManager = new Button();
            btnDeleteManager = new Button();
            btnCatCashiers = new Button();
            flowCashiers = new FlowLayoutPanel();
            btnAddCashier = new Button();
            btnViewCashiers = new Button();
            btnUpdateCashier = new Button();
            btnDeleteCashier = new Button();
            btnCatBranches = new Button();
            flowBranches = new FlowLayoutPanel();
            btnAddBranch = new Button();
            btnViewBranches = new Button();
            btnUpdateBranch = new Button();
            btnDeleteBranch = new Button();
            btnCatSuppliers = new Button();
            flowSuppliers = new FlowLayoutPanel();
            btnAddSupplier = new Button();
            btnViewSuppliers = new Button();
            btnUpdateSupplier = new Button();
            btnDeleteSupplier = new Button();
            btnCatExpenses = new Button();
            flowExpenses = new FlowLayoutPanel();
            btnAddExpense = new Button();
            btnViewExpenses = new Button();
            btnUpdateExpense = new Button();
            btnApproveExpense = new Button();
            pnlSidebarSpacer = new Panel();
            btnLogout = new Button();
            contentPanel = new Panel();
            lblWelcome = new Label();
            rootTable.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            flowSidebar.SuspendLayout();
            flowAdmins.SuspendLayout();
            flowManagers.SuspendLayout();
            flowCashiers.SuspendLayout();
            flowBranches.SuspendLayout();
            flowSuppliers.SuspendLayout();
            flowExpenses.SuspendLayout();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // rootTable
            // 
            rootTable.BackColor = Color.FromArgb(240, 243, 248);
            rootTable.ColumnCount = 2;
            rootTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            rootTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            rootTable.Controls.Add(pnlHeader, 0, 0);
            rootTable.Controls.Add(pnlSidebar, 0, 1);
            rootTable.Controls.Add(contentPanel, 1, 1);
            rootTable.Dock = DockStyle.Fill;
            rootTable.Location = new Point(0, 0);
            rootTable.Margin = new Padding(0);
            rootTable.Name = "rootTable";
            rootTable.RowCount = 2;
            rootTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            rootTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            rootTable.Size = new Size(1400, 860);
            rootTable.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(20, 28, 44);
            rootTable.SetColumnSpan(pnlHeader, 2);
            pnlHeader.Controls.Add(lblLogo);
            pnlHeader.Controls.Add(lblRole);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1400, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(16, 14);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(154, 25);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "SuperMart Pro";
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Times New Roman", 11F);
            lblRole.ForeColor = Color.FromArgb(160, 175, 200);
            lblRole.Location = new Point(2450, 20);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(115, 17);
            lblRole.TabIndex = 1;
            lblRole.Text = "Admin Dashboard";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(28, 37, 54);
            pnlSidebar.Controls.Add(flowSidebar);
            pnlSidebar.Dock = DockStyle.Fill;
            pnlSidebar.Location = new Point(0, 60);
            pnlSidebar.Margin = new Padding(0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(240, 800);
            pnlSidebar.TabIndex = 1;
            // 
            // flowSidebar
            // 
            flowSidebar.AutoScroll = true;
            flowSidebar.BackColor = Color.FromArgb(28, 37, 54);
            flowSidebar.Controls.Add(btnCatAdmins);
            flowSidebar.Controls.Add(flowAdmins);
            flowSidebar.Controls.Add(btnCatManagers);
            flowSidebar.Controls.Add(flowManagers);
            flowSidebar.Controls.Add(btnCatCashiers);
            flowSidebar.Controls.Add(flowCashiers);
            flowSidebar.Controls.Add(btnCatBranches);
            flowSidebar.Controls.Add(flowBranches);
            flowSidebar.Controls.Add(btnCatSuppliers);
            flowSidebar.Controls.Add(flowSuppliers);
            flowSidebar.Controls.Add(btnCatExpenses);
            flowSidebar.Controls.Add(flowExpenses);
            flowSidebar.Controls.Add(pnlSidebarSpacer);
            flowSidebar.Controls.Add(btnLogout);
            flowSidebar.Dock = DockStyle.Fill;
            flowSidebar.FlowDirection = FlowDirection.TopDown;
            flowSidebar.Location = new Point(0, 0);
            flowSidebar.Margin = new Padding(0);
            flowSidebar.Name = "flowSidebar";
            flowSidebar.Padding = new Padding(0, 8, 0, 8);
            flowSidebar.Size = new Size(240, 800);
            flowSidebar.TabIndex = 0;
            flowSidebar.WrapContents = false;
            // 
            // btnCatAdmins
            // 
            btnCatAdmins.BackColor = Color.FromArgb(38, 50, 72);
            btnCatAdmins.Cursor = Cursors.Hand;
            btnCatAdmins.FlatAppearance.BorderSize = 0;
            btnCatAdmins.FlatStyle = FlatStyle.Flat;
            btnCatAdmins.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            btnCatAdmins.ForeColor = Color.White;
            btnCatAdmins.Location = new Point(0, 10);
            btnCatAdmins.Margin = new Padding(0, 2, 0, 0);
            btnCatAdmins.Name = "btnCatAdmins";
            btnCatAdmins.Size = new Size(240, 42);
            btnCatAdmins.TabIndex = 0;
            btnCatAdmins.Text = "  > Admins";
            btnCatAdmins.TextAlign = ContentAlignment.MiddleLeft;
            btnCatAdmins.UseVisualStyleBackColor = false;
            // 
            // flowAdmins
            // 
            flowAdmins.AutoSize = true;
            flowAdmins.BackColor = Color.FromArgb(22, 30, 46);
            flowAdmins.Controls.Add(btnAddAdmin);
            flowAdmins.Controls.Add(btnViewAdmins);
            flowAdmins.Controls.Add(btnUpdateAdmin);
            flowAdmins.Controls.Add(btnDeleteAdmin);
            flowAdmins.FlowDirection = FlowDirection.TopDown;
            flowAdmins.Location = new Point(0, 52);
            flowAdmins.Margin = new Padding(0);
            flowAdmins.Name = "flowAdmins";
            flowAdmins.Size = new Size(240, 152);
            flowAdmins.TabIndex = 1;
            flowAdmins.Visible = false;
            flowAdmins.WrapContents = false;
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.BackColor = Color.FromArgb(22, 30, 46);
            btnAddAdmin.Cursor = Cursors.Hand;
            btnAddAdmin.FlatAppearance.BorderSize = 0;
            btnAddAdmin.FlatStyle = FlatStyle.Flat;
            btnAddAdmin.Font = new Font("Times New Roman", 10.5F);
            btnAddAdmin.ForeColor = Color.FromArgb(160, 175, 200);
            btnAddAdmin.Location = new Point(0, 0);
            btnAddAdmin.Margin = new Padding(0);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(240, 38);
            btnAddAdmin.TabIndex = 0;
            btnAddAdmin.Text = "    Add Admin";
            btnAddAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnAddAdmin.UseVisualStyleBackColor = false;
            // 
            // btnViewAdmins
            // 
            btnViewAdmins.BackColor = Color.FromArgb(22, 30, 46);
            btnViewAdmins.Cursor = Cursors.Hand;
            btnViewAdmins.FlatAppearance.BorderSize = 0;
            btnViewAdmins.FlatStyle = FlatStyle.Flat;
            btnViewAdmins.Font = new Font("Times New Roman", 10.5F);
            btnViewAdmins.ForeColor = Color.FromArgb(160, 175, 200);
            btnViewAdmins.Location = new Point(0, 38);
            btnViewAdmins.Margin = new Padding(0);
            btnViewAdmins.Name = "btnViewAdmins";
            btnViewAdmins.Size = new Size(240, 38);
            btnViewAdmins.TabIndex = 1;
            btnViewAdmins.Text = "    View All Admins";
            btnViewAdmins.TextAlign = ContentAlignment.MiddleLeft;
            btnViewAdmins.UseVisualStyleBackColor = false;
            // 
            // btnUpdateAdmin
            // 
            btnUpdateAdmin.BackColor = Color.FromArgb(22, 30, 46);
            btnUpdateAdmin.Cursor = Cursors.Hand;
            btnUpdateAdmin.FlatAppearance.BorderSize = 0;
            btnUpdateAdmin.FlatStyle = FlatStyle.Flat;
            btnUpdateAdmin.Font = new Font("Times New Roman", 10.5F);
            btnUpdateAdmin.ForeColor = Color.FromArgb(160, 175, 200);
            btnUpdateAdmin.Location = new Point(0, 76);
            btnUpdateAdmin.Margin = new Padding(0);
            btnUpdateAdmin.Name = "btnUpdateAdmin";
            btnUpdateAdmin.Size = new Size(240, 38);
            btnUpdateAdmin.TabIndex = 2;
            btnUpdateAdmin.Text = "    Update Admin";
            btnUpdateAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateAdmin.UseVisualStyleBackColor = false;
            // 
            // btnDeleteAdmin
            // 
            btnDeleteAdmin.BackColor = Color.FromArgb(22, 30, 46);
            btnDeleteAdmin.Cursor = Cursors.Hand;
            btnDeleteAdmin.FlatAppearance.BorderSize = 0;
            btnDeleteAdmin.FlatStyle = FlatStyle.Flat;
            btnDeleteAdmin.Font = new Font("Times New Roman", 10.5F);
            btnDeleteAdmin.ForeColor = Color.FromArgb(160, 175, 200);
            btnDeleteAdmin.Location = new Point(0, 114);
            btnDeleteAdmin.Margin = new Padding(0);
            btnDeleteAdmin.Name = "btnDeleteAdmin";
            btnDeleteAdmin.Size = new Size(240, 38);
            btnDeleteAdmin.TabIndex = 3;
            btnDeleteAdmin.Text = "    Delete Admin";
            btnDeleteAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteAdmin.UseVisualStyleBackColor = false;
            // 
            // btnCatManagers
            // 
            btnCatManagers.BackColor = Color.FromArgb(38, 50, 72);
            btnCatManagers.Cursor = Cursors.Hand;
            btnCatManagers.FlatAppearance.BorderSize = 0;
            btnCatManagers.FlatStyle = FlatStyle.Flat;
            btnCatManagers.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            btnCatManagers.ForeColor = Color.White;
            btnCatManagers.Location = new Point(0, 206);
            btnCatManagers.Margin = new Padding(0, 2, 0, 0);
            btnCatManagers.Name = "btnCatManagers";
            btnCatManagers.Size = new Size(240, 42);
            btnCatManagers.TabIndex = 2;
            btnCatManagers.Text = "  > Managers";
            btnCatManagers.TextAlign = ContentAlignment.MiddleLeft;
            btnCatManagers.UseVisualStyleBackColor = false;
            // 
            // flowManagers
            // 
            flowManagers.AutoSize = true;
            flowManagers.BackColor = Color.FromArgb(22, 30, 46);
            flowManagers.Controls.Add(btnAddManager);
            flowManagers.Controls.Add(btnViewManagers);
            flowManagers.Controls.Add(btnUpdateManager);
            flowManagers.Controls.Add(btnDeleteManager);
            flowManagers.FlowDirection = FlowDirection.TopDown;
            flowManagers.Location = new Point(0, 248);
            flowManagers.Margin = new Padding(0);
            flowManagers.Name = "flowManagers";
            flowManagers.Size = new Size(240, 152);
            flowManagers.TabIndex = 3;
            flowManagers.Visible = false;
            flowManagers.WrapContents = false;
            // 
            // btnAddManager
            // 
            btnAddManager.BackColor = Color.FromArgb(22, 30, 46);
            btnAddManager.Cursor = Cursors.Hand;
            btnAddManager.FlatAppearance.BorderSize = 0;
            btnAddManager.FlatStyle = FlatStyle.Flat;
            btnAddManager.Font = new Font("Times New Roman", 10.5F);
            btnAddManager.ForeColor = Color.FromArgb(160, 175, 200);
            btnAddManager.Location = new Point(0, 0);
            btnAddManager.Margin = new Padding(0);
            btnAddManager.Name = "btnAddManager";
            btnAddManager.Size = new Size(240, 38);
            btnAddManager.TabIndex = 0;
            btnAddManager.Text = "    Add Manager";
            btnAddManager.TextAlign = ContentAlignment.MiddleLeft;
            btnAddManager.UseVisualStyleBackColor = false;
            // 
            // btnViewManagers
            // 
            btnViewManagers.BackColor = Color.FromArgb(22, 30, 46);
            btnViewManagers.Cursor = Cursors.Hand;
            btnViewManagers.FlatAppearance.BorderSize = 0;
            btnViewManagers.FlatStyle = FlatStyle.Flat;
            btnViewManagers.Font = new Font("Times New Roman", 10.5F);
            btnViewManagers.ForeColor = Color.FromArgb(160, 175, 200);
            btnViewManagers.Location = new Point(0, 38);
            btnViewManagers.Margin = new Padding(0);
            btnViewManagers.Name = "btnViewManagers";
            btnViewManagers.Size = new Size(240, 38);
            btnViewManagers.TabIndex = 1;
            btnViewManagers.Text = "    View All Managers";
            btnViewManagers.TextAlign = ContentAlignment.MiddleLeft;
            btnViewManagers.UseVisualStyleBackColor = false;
            // 
            // btnUpdateManager
            // 
            btnUpdateManager.BackColor = Color.FromArgb(22, 30, 46);
            btnUpdateManager.Cursor = Cursors.Hand;
            btnUpdateManager.FlatAppearance.BorderSize = 0;
            btnUpdateManager.FlatStyle = FlatStyle.Flat;
            btnUpdateManager.Font = new Font("Times New Roman", 10.5F);
            btnUpdateManager.ForeColor = Color.FromArgb(160, 175, 200);
            btnUpdateManager.Location = new Point(0, 76);
            btnUpdateManager.Margin = new Padding(0);
            btnUpdateManager.Name = "btnUpdateManager";
            btnUpdateManager.Size = new Size(240, 38);
            btnUpdateManager.TabIndex = 2;
            btnUpdateManager.Text = "    Update Manager";
            btnUpdateManager.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateManager.UseVisualStyleBackColor = false;
            // 
            // btnDeleteManager
            // 
            btnDeleteManager.BackColor = Color.FromArgb(22, 30, 46);
            btnDeleteManager.Cursor = Cursors.Hand;
            btnDeleteManager.FlatAppearance.BorderSize = 0;
            btnDeleteManager.FlatStyle = FlatStyle.Flat;
            btnDeleteManager.Font = new Font("Times New Roman", 10.5F);
            btnDeleteManager.ForeColor = Color.FromArgb(160, 175, 200);
            btnDeleteManager.Location = new Point(0, 114);
            btnDeleteManager.Margin = new Padding(0);
            btnDeleteManager.Name = "btnDeleteManager";
            btnDeleteManager.Size = new Size(240, 38);
            btnDeleteManager.TabIndex = 3;
            btnDeleteManager.Text = "    Delete Manager";
            btnDeleteManager.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteManager.UseVisualStyleBackColor = false;
            // 
            // btnCatCashiers
            // 
            btnCatCashiers.BackColor = Color.FromArgb(38, 50, 72);
            btnCatCashiers.Cursor = Cursors.Hand;
            btnCatCashiers.FlatAppearance.BorderSize = 0;
            btnCatCashiers.FlatStyle = FlatStyle.Flat;
            btnCatCashiers.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            btnCatCashiers.ForeColor = Color.White;
            btnCatCashiers.Location = new Point(0, 402);
            btnCatCashiers.Margin = new Padding(0, 2, 0, 0);
            btnCatCashiers.Name = "btnCatCashiers";
            btnCatCashiers.Size = new Size(240, 42);
            btnCatCashiers.TabIndex = 4;
            btnCatCashiers.Text = "  > Cashiers";
            btnCatCashiers.TextAlign = ContentAlignment.MiddleLeft;
            btnCatCashiers.UseVisualStyleBackColor = false;
            // 
            // flowCashiers
            // 
            flowCashiers.AutoSize = true;
            flowCashiers.BackColor = Color.FromArgb(22, 30, 46);
            flowCashiers.Controls.Add(btnAddCashier);
            flowCashiers.Controls.Add(btnViewCashiers);
            flowCashiers.Controls.Add(btnUpdateCashier);
            flowCashiers.Controls.Add(btnDeleteCashier);
            flowCashiers.FlowDirection = FlowDirection.TopDown;
            flowCashiers.Location = new Point(0, 444);
            flowCashiers.Margin = new Padding(0);
            flowCashiers.Name = "flowCashiers";
            flowCashiers.Size = new Size(240, 152);
            flowCashiers.TabIndex = 5;
            flowCashiers.Visible = false;
            flowCashiers.WrapContents = false;
            // 
            // btnAddCashier
            // 
            btnAddCashier.BackColor = Color.FromArgb(22, 30, 46);
            btnAddCashier.Cursor = Cursors.Hand;
            btnAddCashier.FlatAppearance.BorderSize = 0;
            btnAddCashier.FlatStyle = FlatStyle.Flat;
            btnAddCashier.Font = new Font("Times New Roman", 10.5F);
            btnAddCashier.ForeColor = Color.FromArgb(160, 175, 200);
            btnAddCashier.Location = new Point(0, 0);
            btnAddCashier.Margin = new Padding(0);
            btnAddCashier.Name = "btnAddCashier";
            btnAddCashier.Size = new Size(240, 38);
            btnAddCashier.TabIndex = 0;
            btnAddCashier.Text = "    Add Cashier";
            btnAddCashier.TextAlign = ContentAlignment.MiddleLeft;
            btnAddCashier.UseVisualStyleBackColor = false;
            // 
            // btnViewCashiers
            // 
            btnViewCashiers.BackColor = Color.FromArgb(22, 30, 46);
            btnViewCashiers.Cursor = Cursors.Hand;
            btnViewCashiers.FlatAppearance.BorderSize = 0;
            btnViewCashiers.FlatStyle = FlatStyle.Flat;
            btnViewCashiers.Font = new Font("Times New Roman", 10.5F);
            btnViewCashiers.ForeColor = Color.FromArgb(160, 175, 200);
            btnViewCashiers.Location = new Point(0, 38);
            btnViewCashiers.Margin = new Padding(0);
            btnViewCashiers.Name = "btnViewCashiers";
            btnViewCashiers.Size = new Size(240, 38);
            btnViewCashiers.TabIndex = 1;
            btnViewCashiers.Text = "    View All Cashiers";
            btnViewCashiers.TextAlign = ContentAlignment.MiddleLeft;
            btnViewCashiers.UseVisualStyleBackColor = false;
            // 
            // btnUpdateCashier
            // 
            btnUpdateCashier.BackColor = Color.FromArgb(22, 30, 46);
            btnUpdateCashier.Cursor = Cursors.Hand;
            btnUpdateCashier.FlatAppearance.BorderSize = 0;
            btnUpdateCashier.FlatStyle = FlatStyle.Flat;
            btnUpdateCashier.Font = new Font("Times New Roman", 10.5F);
            btnUpdateCashier.ForeColor = Color.FromArgb(160, 175, 200);
            btnUpdateCashier.Location = new Point(0, 76);
            btnUpdateCashier.Margin = new Padding(0);
            btnUpdateCashier.Name = "btnUpdateCashier";
            btnUpdateCashier.Size = new Size(240, 38);
            btnUpdateCashier.TabIndex = 2;
            btnUpdateCashier.Text = "    Update Cashier";
            btnUpdateCashier.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateCashier.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCashier
            // 
            btnDeleteCashier.BackColor = Color.FromArgb(22, 30, 46);
            btnDeleteCashier.Cursor = Cursors.Hand;
            btnDeleteCashier.FlatAppearance.BorderSize = 0;
            btnDeleteCashier.FlatStyle = FlatStyle.Flat;
            btnDeleteCashier.Font = new Font("Times New Roman", 10.5F);
            btnDeleteCashier.ForeColor = Color.FromArgb(160, 175, 200);
            btnDeleteCashier.Location = new Point(0, 114);
            btnDeleteCashier.Margin = new Padding(0);
            btnDeleteCashier.Name = "btnDeleteCashier";
            btnDeleteCashier.Size = new Size(240, 38);
            btnDeleteCashier.TabIndex = 3;
            btnDeleteCashier.Text = "    Delete Cashier";
            btnDeleteCashier.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteCashier.UseVisualStyleBackColor = false;
            // 
            // btnCatBranches
            // 
            btnCatBranches.BackColor = Color.FromArgb(38, 50, 72);
            btnCatBranches.Cursor = Cursors.Hand;
            btnCatBranches.FlatAppearance.BorderSize = 0;
            btnCatBranches.FlatStyle = FlatStyle.Flat;
            btnCatBranches.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            btnCatBranches.ForeColor = Color.White;
            btnCatBranches.Location = new Point(0, 794);
            btnCatBranches.Margin = new Padding(0, 2, 0, 0);
            btnCatBranches.Name = "btnCatBranches";
            btnCatBranches.Size = new Size(240, 42);
            btnCatBranches.TabIndex = 8;
            btnCatBranches.Text = "  > Branches";
            btnCatBranches.TextAlign = ContentAlignment.MiddleLeft;
            btnCatBranches.UseVisualStyleBackColor = false;
            // 
            // flowBranches
            // 
            flowBranches.AutoSize = true;
            flowBranches.BackColor = Color.FromArgb(22, 30, 46);
            flowBranches.Controls.Add(btnAddBranch);
            flowBranches.Controls.Add(btnViewBranches);
            flowBranches.Controls.Add(btnUpdateBranch);
            flowBranches.Controls.Add(btnDeleteBranch);
            flowBranches.FlowDirection = FlowDirection.TopDown;
            flowBranches.Location = new Point(0, 836);
            flowBranches.Margin = new Padding(0);
            flowBranches.Name = "flowBranches";
            flowBranches.Size = new Size(240, 152);
            flowBranches.TabIndex = 9;
            flowBranches.Visible = false;
            flowBranches.WrapContents = false;
            // 
            // btnAddBranch
            // 
            btnAddBranch.BackColor = Color.FromArgb(22, 30, 46);
            btnAddBranch.Cursor = Cursors.Hand;
            btnAddBranch.FlatAppearance.BorderSize = 0;
            btnAddBranch.FlatStyle = FlatStyle.Flat;
            btnAddBranch.Font = new Font("Times New Roman", 10.5F);
            btnAddBranch.ForeColor = Color.FromArgb(160, 175, 200);
            btnAddBranch.Location = new Point(0, 0);
            btnAddBranch.Margin = new Padding(0);
            btnAddBranch.Name = "btnAddBranch";
            btnAddBranch.Size = new Size(240, 38);
            btnAddBranch.TabIndex = 0;
            btnAddBranch.Text = "    Add Branch";
            btnAddBranch.TextAlign = ContentAlignment.MiddleLeft;
            btnAddBranch.UseVisualStyleBackColor = false;
            // 
            // btnViewBranches
            // 
            btnViewBranches.BackColor = Color.FromArgb(22, 30, 46);
            btnViewBranches.Cursor = Cursors.Hand;
            btnViewBranches.FlatAppearance.BorderSize = 0;
            btnViewBranches.FlatStyle = FlatStyle.Flat;
            btnViewBranches.Font = new Font("Times New Roman", 10.5F);
            btnViewBranches.ForeColor = Color.FromArgb(160, 175, 200);
            btnViewBranches.Location = new Point(0, 38);
            btnViewBranches.Margin = new Padding(0);
            btnViewBranches.Name = "btnViewBranches";
            btnViewBranches.Size = new Size(240, 38);
            btnViewBranches.TabIndex = 1;
            btnViewBranches.Text = "    View All Branches";
            btnViewBranches.TextAlign = ContentAlignment.MiddleLeft;
            btnViewBranches.UseVisualStyleBackColor = false;
            // 
            // btnUpdateBranch
            // 
            btnUpdateBranch.BackColor = Color.FromArgb(22, 30, 46);
            btnUpdateBranch.Cursor = Cursors.Hand;
            btnUpdateBranch.FlatAppearance.BorderSize = 0;
            btnUpdateBranch.FlatStyle = FlatStyle.Flat;
            btnUpdateBranch.Font = new Font("Times New Roman", 10.5F);
            btnUpdateBranch.ForeColor = Color.FromArgb(160, 175, 200);
            btnUpdateBranch.Location = new Point(0, 76);
            btnUpdateBranch.Margin = new Padding(0);
            btnUpdateBranch.Name = "btnUpdateBranch";
            btnUpdateBranch.Size = new Size(240, 38);
            btnUpdateBranch.TabIndex = 2;
            btnUpdateBranch.Text = "    Update Branch";
            btnUpdateBranch.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateBranch.UseVisualStyleBackColor = false;
            // 
            // btnDeleteBranch
            // 
            btnDeleteBranch.BackColor = Color.FromArgb(22, 30, 46);
            btnDeleteBranch.Cursor = Cursors.Hand;
            btnDeleteBranch.FlatAppearance.BorderSize = 0;
            btnDeleteBranch.FlatStyle = FlatStyle.Flat;
            btnDeleteBranch.Font = new Font("Times New Roman", 10.5F);
            btnDeleteBranch.ForeColor = Color.FromArgb(160, 175, 200);
            btnDeleteBranch.Location = new Point(0, 114);
            btnDeleteBranch.Margin = new Padding(0);
            btnDeleteBranch.Name = "btnDeleteBranch";
            btnDeleteBranch.Size = new Size(240, 38);
            btnDeleteBranch.TabIndex = 3;
            btnDeleteBranch.Text = "    Delete Branch";
            btnDeleteBranch.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteBranch.UseVisualStyleBackColor = false;
            // 
            // btnCatSuppliers
            // 
            btnCatSuppliers.BackColor = Color.FromArgb(38, 50, 72);
            btnCatSuppliers.Cursor = Cursors.Hand;
            btnCatSuppliers.FlatAppearance.BorderSize = 0;
            btnCatSuppliers.FlatStyle = FlatStyle.Flat;
            btnCatSuppliers.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            btnCatSuppliers.ForeColor = Color.White;
            btnCatSuppliers.Location = new Point(0, 1186);
            btnCatSuppliers.Margin = new Padding(0, 2, 0, 0);
            btnCatSuppliers.Name = "btnCatSuppliers";
            btnCatSuppliers.Size = new Size(240, 42);
            btnCatSuppliers.TabIndex = 12;
            btnCatSuppliers.Text = "  > Suppliers";
            btnCatSuppliers.TextAlign = ContentAlignment.MiddleLeft;
            btnCatSuppliers.UseVisualStyleBackColor = false;
            // 
            // flowSuppliers
            // 
            flowSuppliers.AutoSize = true;
            flowSuppliers.BackColor = Color.FromArgb(22, 30, 46);
            flowSuppliers.Controls.Add(btnAddSupplier);
            flowSuppliers.Controls.Add(btnViewSuppliers);
            flowSuppliers.Controls.Add(btnUpdateSupplier);
            flowSuppliers.Controls.Add(btnDeleteSupplier);
            flowSuppliers.FlowDirection = FlowDirection.TopDown;
            flowSuppliers.Location = new Point(0, 1228);
            flowSuppliers.Margin = new Padding(0);
            flowSuppliers.Name = "flowSuppliers";
            flowSuppliers.Size = new Size(240, 152);
            flowSuppliers.TabIndex = 13;
            flowSuppliers.Visible = false;
            flowSuppliers.WrapContents = false;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.BackColor = Color.FromArgb(22, 30, 46);
            btnAddSupplier.Cursor = Cursors.Hand;
            btnAddSupplier.FlatAppearance.BorderSize = 0;
            btnAddSupplier.FlatStyle = FlatStyle.Flat;
            btnAddSupplier.Font = new Font("Times New Roman", 10.5F);
            btnAddSupplier.ForeColor = Color.FromArgb(160, 175, 200);
            btnAddSupplier.Location = new Point(0, 0);
            btnAddSupplier.Margin = new Padding(0);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(240, 38);
            btnAddSupplier.TabIndex = 0;
            btnAddSupplier.Text = "    Add Supplier";
            btnAddSupplier.TextAlign = ContentAlignment.MiddleLeft;
            btnAddSupplier.UseVisualStyleBackColor = false;
            // 
            // btnViewSuppliers
            // 
            btnViewSuppliers.BackColor = Color.FromArgb(22, 30, 46);
            btnViewSuppliers.Cursor = Cursors.Hand;
            btnViewSuppliers.FlatAppearance.BorderSize = 0;
            btnViewSuppliers.FlatStyle = FlatStyle.Flat;
            btnViewSuppliers.Font = new Font("Times New Roman", 10.5F);
            btnViewSuppliers.ForeColor = Color.FromArgb(160, 175, 200);
            btnViewSuppliers.Location = new Point(0, 38);
            btnViewSuppliers.Margin = new Padding(0);
            btnViewSuppliers.Name = "btnViewSuppliers";
            btnViewSuppliers.Size = new Size(240, 38);
            btnViewSuppliers.TabIndex = 1;
            btnViewSuppliers.Text = "    View All Suppliers";
            btnViewSuppliers.TextAlign = ContentAlignment.MiddleLeft;
            btnViewSuppliers.UseVisualStyleBackColor = false;
            // 
            // btnUpdateSupplier
            // 
            btnUpdateSupplier.BackColor = Color.FromArgb(22, 30, 46);
            btnUpdateSupplier.Cursor = Cursors.Hand;
            btnUpdateSupplier.FlatAppearance.BorderSize = 0;
            btnUpdateSupplier.FlatStyle = FlatStyle.Flat;
            btnUpdateSupplier.Font = new Font("Times New Roman", 10.5F);
            btnUpdateSupplier.ForeColor = Color.FromArgb(160, 175, 200);
            btnUpdateSupplier.Location = new Point(0, 76);
            btnUpdateSupplier.Margin = new Padding(0);
            btnUpdateSupplier.Name = "btnUpdateSupplier";
            btnUpdateSupplier.Size = new Size(240, 38);
            btnUpdateSupplier.TabIndex = 2;
            btnUpdateSupplier.Text = "    Update Supplier";
            btnUpdateSupplier.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateSupplier.UseVisualStyleBackColor = false;
            // 
            // btnDeleteSupplier
            // 
            btnDeleteSupplier.BackColor = Color.FromArgb(22, 30, 46);
            btnDeleteSupplier.Cursor = Cursors.Hand;
            btnDeleteSupplier.FlatAppearance.BorderSize = 0;
            btnDeleteSupplier.FlatStyle = FlatStyle.Flat;
            btnDeleteSupplier.Font = new Font("Times New Roman", 10.5F);
            btnDeleteSupplier.ForeColor = Color.FromArgb(160, 175, 200);
            btnDeleteSupplier.Location = new Point(0, 114);
            btnDeleteSupplier.Margin = new Padding(0);
            btnDeleteSupplier.Name = "btnDeleteSupplier";
            btnDeleteSupplier.Size = new Size(240, 38);
            btnDeleteSupplier.TabIndex = 3;
            btnDeleteSupplier.Text = "    Delete Supplier";
            btnDeleteSupplier.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteSupplier.UseVisualStyleBackColor = false;
            // 
            // btnCatExpenses
            // 
            btnCatExpenses.BackColor = Color.FromArgb(38, 50, 72);
            btnCatExpenses.Cursor = Cursors.Hand;
            btnCatExpenses.FlatAppearance.BorderSize = 0;
            btnCatExpenses.FlatStyle = FlatStyle.Flat;
            btnCatExpenses.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            btnCatExpenses.ForeColor = Color.White;
            btnCatExpenses.Margin = new Padding(0, 2, 0, 0);
            btnCatExpenses.Name = "btnCatExpenses";
            btnCatExpenses.Size = new Size(240, 42);
            btnCatExpenses.TabIndex = 16;
            btnCatExpenses.Text = "  > Expenses";
            btnCatExpenses.TextAlign = ContentAlignment.MiddleLeft;
            btnCatExpenses.UseVisualStyleBackColor = false;
            // 
            // flowExpenses
            // 
            flowExpenses.AutoSize = true;
            flowExpenses.BackColor = Color.FromArgb(22, 30, 46);
            flowExpenses.Controls.Add(btnAddExpense);
            flowExpenses.Controls.Add(btnViewExpenses);
            flowExpenses.Controls.Add(btnUpdateExpense);
            flowExpenses.Controls.Add(btnApproveExpense);
            flowExpenses.FlowDirection = FlowDirection.TopDown;
            flowExpenses.Margin = new Padding(0);
            flowExpenses.Name = "flowExpenses";
            flowExpenses.Size = new Size(240, 152);
            flowExpenses.TabIndex = 17;
            flowExpenses.Visible = false;
            flowExpenses.WrapContents = false;
            // 
            // btnAddExpense
            // 
            btnAddExpense.BackColor = Color.FromArgb(22, 30, 46);
            btnAddExpense.Cursor = Cursors.Hand;
            btnAddExpense.FlatAppearance.BorderSize = 0;
            btnAddExpense.FlatStyle = FlatStyle.Flat;
            btnAddExpense.Font = new Font("Times New Roman", 10.5F);
            btnAddExpense.ForeColor = Color.FromArgb(160, 175, 200);
            btnAddExpense.Margin = new Padding(0);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(240, 38);
            btnAddExpense.TabIndex = 0;
            btnAddExpense.Text = "    Add Expense";
            btnAddExpense.TextAlign = ContentAlignment.MiddleLeft;
            btnAddExpense.UseVisualStyleBackColor = false;
            // 
            // btnViewExpenses
            // 
            btnViewExpenses.BackColor = Color.FromArgb(22, 30, 46);
            btnViewExpenses.Cursor = Cursors.Hand;
            btnViewExpenses.FlatAppearance.BorderSize = 0;
            btnViewExpenses.FlatStyle = FlatStyle.Flat;
            btnViewExpenses.Font = new Font("Times New Roman", 10.5F);
            btnViewExpenses.ForeColor = Color.FromArgb(160, 175, 200);
            btnViewExpenses.Margin = new Padding(0);
            btnViewExpenses.Name = "btnViewExpenses";
            btnViewExpenses.Size = new Size(240, 38);
            btnViewExpenses.TabIndex = 1;
            btnViewExpenses.Text = "    View All Expenses";
            btnViewExpenses.TextAlign = ContentAlignment.MiddleLeft;
            btnViewExpenses.UseVisualStyleBackColor = false;
            // 
            // btnUpdateExpense
            // 
            btnUpdateExpense.BackColor = Color.FromArgb(22, 30, 46);
            btnUpdateExpense.Cursor = Cursors.Hand;
            btnUpdateExpense.FlatAppearance.BorderSize = 0;
            btnUpdateExpense.FlatStyle = FlatStyle.Flat;
            btnUpdateExpense.Font = new Font("Times New Roman", 10.5F);
            btnUpdateExpense.ForeColor = Color.FromArgb(160, 175, 200);
            btnUpdateExpense.Margin = new Padding(0);
            btnUpdateExpense.Name = "btnUpdateExpense";
            btnUpdateExpense.Size = new Size(240, 38);
            btnUpdateExpense.TabIndex = 2;
            btnUpdateExpense.Text = "    Update Expense";
            btnUpdateExpense.TextAlign = ContentAlignment.MiddleLeft;
            btnUpdateExpense.UseVisualStyleBackColor = false;
            // 
            // btnApproveExpense
            // 
            btnApproveExpense.BackColor = Color.FromArgb(22, 30, 46);
            btnApproveExpense.Cursor = Cursors.Hand;
            btnApproveExpense.FlatAppearance.BorderSize = 0;
            btnApproveExpense.FlatStyle = FlatStyle.Flat;
            btnApproveExpense.Font = new Font("Times New Roman", 10.5F);
            btnApproveExpense.ForeColor = Color.FromArgb(160, 175, 200);
            btnApproveExpense.Margin = new Padding(0);
            btnApproveExpense.Name = "btnApproveExpense";
            btnApproveExpense.Size = new Size(240, 38);
            btnApproveExpense.TabIndex = 3;
            btnApproveExpense.Text = "    Approve Expenses";
            btnApproveExpense.TextAlign = ContentAlignment.MiddleLeft;
            btnApproveExpense.UseVisualStyleBackColor = false;
            // 
            // pnlSidebarSpacer
            // 
            pnlSidebarSpacer.BackColor = Color.FromArgb(28, 37, 54);
            pnlSidebarSpacer.Location = new Point(3, 1383);
            pnlSidebarSpacer.Name = "pnlSidebarSpacer";
            pnlSidebarSpacer.Size = new Size(240, 20);
            pnlSidebarSpacer.TabIndex = 14;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(180, 30, 30);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 1410);
            btnLogout.Margin = new Padding(0, 4, 0, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(240, 44);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "  Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(240, 243, 248);
            contentPanel.Controls.Add(lblWelcome);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(240, 60);
            contentPanel.Margin = new Padding(0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1160, 800);
            contentPanel.TabIndex = 2;
            // 
            // lblWelcome
            // 
            lblWelcome.Dock = DockStyle.Fill;
            lblWelcome.Font = new Font("Times New Roman", 16F);
            lblWelcome.ForeColor = Color.FromArgb(90, 110, 140);
            lblWelcome.Location = new Point(0, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(1160, 800);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Admin\r\n\r\nSelect an operation from the left panel to get started.";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminDashboardGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 243, 248);
            ClientSize = new Size(1400, 860);
            Controls.Add(rootTable);
            Font = new Font("Times New Roman", 11F);
            MinimumSize = new Size(1100, 680);
            Name = "AdminDashboardGUI";
            Text = "SuperMart Pro - Admin Dashboard";
            WindowState = FormWindowState.Maximized;
            rootTable.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            flowSidebar.ResumeLayout(false);
            flowSidebar.PerformLayout();
            flowAdmins.ResumeLayout(false);
            flowManagers.ResumeLayout(false);
            flowCashiers.ResumeLayout(false);
            flowBranches.ResumeLayout(false);
            flowSuppliers.ResumeLayout(false);
            flowExpenses.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.TableLayoutPanel rootTable;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.FlowLayoutPanel flowSidebar;
        private System.Windows.Forms.Button btnCatAdmins;
        private System.Windows.Forms.FlowLayoutPanel flowAdmins;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Button btnViewAdmins;
        private System.Windows.Forms.Button btnUpdateAdmin;
        private System.Windows.Forms.Button btnDeleteAdmin;
        private System.Windows.Forms.Button btnCatManagers;
        private System.Windows.Forms.FlowLayoutPanel flowManagers;
        private System.Windows.Forms.Button btnAddManager;
        private System.Windows.Forms.Button btnViewManagers;
        private System.Windows.Forms.Button btnUpdateManager;
        private System.Windows.Forms.Button btnDeleteManager;
        private System.Windows.Forms.Button btnCatCashiers;
        private System.Windows.Forms.FlowLayoutPanel flowCashiers;
        private System.Windows.Forms.Button btnAddCashier;
        private System.Windows.Forms.Button btnViewCashiers;
        private System.Windows.Forms.Button btnUpdateCashier;
        private System.Windows.Forms.Button btnDeleteCashier;
        private System.Windows.Forms.Button btnCatBranches;
        private System.Windows.Forms.FlowLayoutPanel flowBranches;
        private System.Windows.Forms.Button btnAddBranch;
        private System.Windows.Forms.Button btnViewBranches;
        private System.Windows.Forms.Button btnUpdateBranch;
        private System.Windows.Forms.Button btnDeleteBranch;
        private System.Windows.Forms.Button btnCatSuppliers;
        private System.Windows.Forms.FlowLayoutPanel flowSuppliers;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnViewSuppliers;
        private System.Windows.Forms.Button btnUpdateSupplier;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Panel pnlSidebarSpacer;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCatExpenses;
        private System.Windows.Forms.FlowLayoutPanel flowExpenses;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Button btnViewExpenses;
        private System.Windows.Forms.Button btnUpdateExpense;
        private System.Windows.Forms.Button btnApproveExpense;
    }
}
