using SuperMart_Pro.View.Admin;
using SuperMart_Pro.View.Branch;
using SuperMart_Pro.View.Cashier;
using SuperMart_Pro.View.Customer;
using SuperMart_Pro.View.Manager;
using SuperMart_Pro.View.Product;
using SuperMart_Pro.View.Supplier;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuperMart_Pro.View.Dashboards
{
    public partial class AdminDashboardGUI : Form
    {
        private static readonly Color SubBtnBg     = Color.FromArgb(22,  30,  46);
        private static readonly Color SubBtnHover  = Color.FromArgb(0,  120, 215);
        private static readonly Color SubBtnActive = Color.FromArgb(0,   90, 170);
        private static readonly Color CategoryBg   = Color.FromArgb(38,  50,  72);
        private static readonly Color CategoryHover= Color.FromArgb(52,  68,  94);
        private static readonly Color TextLight    = Color.White;
        private static readonly Color TextMuted    = Color.FromArgb(160, 175, 200);
        private static readonly Color ContentBg    = Color.FromArgb(240, 243, 248);

        private Button? _activeSubBtn;
        private Form?   _hostedForm;

        public AdminDashboardGUI()
        {
            InitializeComponent();
            WireEvents();
        }

        // ─────────────────────────────────────────────────────────────────────
        //  EVENT WIRING
        // ─────────────────────────────────────────────────────────────────────
        private void WireEvents()
        {
            // ── category toggles ─────────────────────────────────────────────
            WireCat(btnCatAdmins,    flowAdmins,    "👤 Admins");
            WireCat(btnCatManagers,  flowManagers,  "🧑‍💼 Managers");
            WireCat(btnCatCashiers,  flowCashiers,  "💳 Cashiers");
            WireCat(btnCatCustomers, flowCustomers, "🛍️ Customers");
            WireCat(btnCatBranches,  flowBranches,  "🏢 Branches");
            WireCat(btnCatProducts,  flowProducts,  "📦 Products");
            WireCat(btnCatSuppliers, flowSuppliers, "🚚 Suppliers");

            // ── sub-button hover colours ──────────────────────────────────────
            foreach (var btn in new[] {
                btnAddAdmin,    btnViewAdmins,   btnUpdateAdmin,   btnDeleteAdmin,
                btnAddManager,  btnViewManagers, btnUpdateManager, btnDeleteManager,
                btnAddCashier,  btnViewCashiers, btnUpdateCashier, btnDeleteCashier,
                btnAddCustomer, btnViewCustomers,btnUpdateCustomer,btnDeleteCustomer,
                btnAddBranch,   btnViewBranches, btnUpdateBranch,  btnDeleteBranch,
                btnAddProduct,  btnViewProducts, btnUpdateProduct, btnDeleteProduct,
                btnAddSupplier, btnViewSuppliers,btnUpdateSupplier,btnDeleteSupplier,
            })
            {
                btn.MouseEnter += (_, _) => { if (btn != _activeSubBtn) btn.BackColor = SubBtnHover; };
                btn.MouseLeave += (_, _) => { if (btn != _activeSubBtn) btn.BackColor = SubBtnBg; };
            }

            // ── category hover colours ────────────────────────────────────────
            foreach (var cat in new[] {
                btnCatAdmins, btnCatManagers, btnCatCashiers, btnCatCustomers,
                btnCatBranches, btnCatProducts, btnCatSuppliers })
            {
                cat.MouseEnter += (_, _) => cat.BackColor = CategoryHover;
                cat.MouseLeave += (_, _) => cat.BackColor = CategoryBg;
            }

            // ── Admin operations ──────────────────────────────────────────────
            btnAddAdmin.Click    += (_, _) => LoadForm(btnAddAdmin,    new AddAdminGUI());
            btnViewAdmins.Click  += (_, _) => LoadForm(btnViewAdmins,  new ViewAllAdminGUI());
            btnUpdateAdmin.Click += (_, _) => LoadForm(btnUpdateAdmin, new UpdateAdminGUI());
            btnDeleteAdmin.Click += (_, _) => LoadForm(btnDeleteAdmin, new DeleteAdminGUI());

            // ── Manager operations ────────────────────────────────────────────
            btnAddManager.Click    += (_, _) => LoadForm(btnAddManager,    new AddManagerGUI());
            btnViewManagers.Click  += (_, _) => LoadForm(btnViewManagers,  new ViewAllManagerGUI());
            btnUpdateManager.Click += (_, _) => LoadForm(btnUpdateManager, new UpdateManagerGUI());
            btnDeleteManager.Click += (_, _) => LoadForm(btnDeleteManager, new DeleteManagerGUI());

            // ── Cashier operations ────────────────────────────────────────────
            btnAddCashier.Click    += (_, _) => LoadForm(btnAddCashier,    new AddCashierGUI());
            btnViewCashiers.Click  += (_, _) => LoadForm(btnViewCashiers,  new ViewAllCashierGUI());
            btnUpdateCashier.Click += (_, _) => LoadForm(btnUpdateCashier, new UpdateCashierGUI());
            btnDeleteCashier.Click += (_, _) => LoadForm(btnDeleteCashier, new DeleteCashierGUI());

            // ── Customer operations ───────────────────────────────────────────
            btnAddCustomer.Click    += (_, _) => LoadForm(btnAddCustomer,    new AddCustomerGUI());
            btnViewCustomers.Click  += (_, _) => LoadForm(btnViewCustomers,  new ViewAllCustomerGUI());
            btnUpdateCustomer.Click += (_, _) => LoadForm(btnUpdateCustomer, new UpdateCustomerGUI());
            btnDeleteCustomer.Click += (_, _) => LoadForm(btnDeleteCustomer, new DeleteCustomerGUI());

            // ── Branch operations ─────────────────────────────────────────────
            btnAddBranch.Click    += (_, _) => LoadForm(btnAddBranch,    new AddBranchGUI());
            btnViewBranches.Click += (_, _) => LoadForm(btnViewBranches, new ViewAllBranchGUI());
            btnUpdateBranch.Click += (_, _) => LoadForm(btnUpdateBranch, new UpdateBranchGUI());
            btnDeleteBranch.Click += (_, _) => LoadForm(btnDeleteBranch, new DeleteBranchGUI());

            // ── Product operations ────────────────────────────────────────────
            btnAddProduct.Click    += (_, _) => LoadForm(btnAddProduct,    new AddProductGUI());
            btnViewProducts.Click  += (_, _) => LoadForm(btnViewProducts,  new ViewAllProductGUI());
            btnUpdateProduct.Click += (_, _) => LoadForm(btnUpdateProduct, new UpdateProductGUI());
            btnDeleteProduct.Click += (_, _) => LoadForm(btnDeleteProduct, new DeleteProductGUI());

            // ── Supplier operations ───────────────────────────────────────────
            btnAddSupplier.Click    += (_, _) => LoadForm(btnAddSupplier,    new AddSupplierGUI());
            btnViewSuppliers.Click  += (_, _) => LoadForm(btnViewSuppliers,  new ViewAllSupplierGUI());
            btnUpdateSupplier.Click += (_, _) => LoadForm(btnUpdateSupplier, new UpdateSupplierGUI());
            btnDeleteSupplier.Click += (_, _) => LoadForm(btnDeleteSupplier, new DeleteSupplierGUI());

            // ── Logout ────────────────────────────────────────────────────────
            btnLogout.Click += (_, _) =>
            {
                if (MessageBox.Show("Are you sure you want to logout?", "Logout",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Restart();
            };

            // ── header role label — keep right-aligned on resize ──────────────
            pnlHeader.Resize += (_, _) =>
                lblRole.Location = new Point(
                    pnlHeader.Width - lblRole.Width - 16,
                    (pnlHeader.Height - lblRole.Height) / 2);
        }

        // ─────────────────────────────────────────────────────────────────────
        //  HELPERS
        // ─────────────────────────────────────────────────────────────────────

        /// <summary>Wires a category button to toggle its sub-panel.</summary>
        private static void WireCat(Button cat, FlowLayoutPanel sub, string title)
        {
            cat.Click += (_, _) =>
            {
                sub.Visible = !sub.Visible;
                cat.Text    = $"  {(sub.Visible ? "▾" : "▸")} {title}";
            };
        }

        /// <summary>Embeds a Form into the right content panel.</summary>
        private void LoadForm(Button sender, Form form)
        {
            SetActiveSubBtn(sender);

            _hostedForm?.Close();
            _hostedForm?.Dispose();
            contentPanel.Controls.Clear();

            _hostedForm          = form;
            form.TopLevel        = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock            = DockStyle.Fill;
            form.BackColor       = ContentBg;

            contentPanel.Controls.Add(form);
            form.Show();
        }

        /// <summary>Highlights the active sidebar sub-button.</summary>
        private void SetActiveSubBtn(Button btn)
        {
            if (_activeSubBtn != null)
            {
                _activeSubBtn.BackColor = SubBtnBg;
                _activeSubBtn.ForeColor = TextMuted;
            }
            _activeSubBtn       = btn;
            btn.BackColor       = SubBtnActive;
            btn.ForeColor       = TextLight;
        }
    }
}
