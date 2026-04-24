using SuperMart_Pro.View.Branch;
using SuperMart_Pro.View.Cashier;
using SuperMart_Pro.View.Customer;
using SuperMart_Pro.View.Expense;
using SuperMart_Pro.View.Product;
using SuperMart_Pro.View.Supplier;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuperMart_Pro.View.Dashboards
{
    public partial class ManagerDashboardGUI : Form
    {
        private static readonly Color SubBtnBg      = Color.FromArgb(22,  30,  46);
        private static readonly Color SubBtnHover   = Color.FromArgb(0,  120, 215);
        private static readonly Color SubBtnActive  = Color.FromArgb(0,   90, 170);
        private static readonly Color CategoryBg    = Color.FromArgb(38,  50,  72);
        private static readonly Color CategoryHover = Color.FromArgb(52,  68,  94);
        private static readonly Color TextLight     = Color.White;
        private static readonly Color TextMuted     = Color.FromArgb(160, 175, 200);
        private static readonly Color ContentBg     = Color.FromArgb(240, 243, 248);

        private Button? _activeSubBtn;
        private Form?   _hostedForm;

        public ManagerDashboardGUI()
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
            WireCat(btnCatCashiers,  flowCashiers,  "Cashiers");
            WireCat(btnCatCustomers, flowCustomers, "Customers");
            WireCat(btnCatBranches,  flowBranches,  "Branches");
            WireCat(btnCatProducts,  flowProducts,  "Products");
            WireCat(btnCatSuppliers, flowSuppliers, "Suppliers");
            WireCat(btnCatExpenses,  flowExpenses,  "Expenses");

            // ── sub-button hover colours ──────────────────────────────────────
            foreach (var btn in new[] {
                btnAddCashier,   btnViewCashiers,  btnUpdateCashier,  btnDeleteCashier,
                btnAddCustomer,  btnViewCustomers, btnUpdateCustomer, btnDeleteCustomer,
                btnViewBranches, btnUpdateBranch,
                btnAddProduct,   btnViewProducts,  btnUpdateProduct,  btnDeleteProduct,
                btnAddSupplier,  btnViewSuppliers, btnUpdateSupplier, btnDeleteSupplier,
                btnAddExpense,   btnUpdateExpense,
                btnApproveExpense,
            })
            {
                btn.MouseEnter += (_, _) => { if (btn != _activeSubBtn) btn.BackColor = SubBtnHover; };
                btn.MouseLeave += (_, _) => { if (btn != _activeSubBtn) btn.BackColor = SubBtnBg; };
            }

            // ── category hover colours ────────────────────────────────────────
            foreach (var cat in new[] { btnCatCashiers, btnCatCustomers, btnCatBranches, btnCatProducts, btnCatSuppliers, btnCatExpenses })
            {
                cat.MouseEnter += (_, _) => cat.BackColor = CategoryHover;
                cat.MouseLeave += (_, _) => cat.BackColor = CategoryBg;
            }

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
            btnViewBranches.Click  += (_, _) => LoadForm(btnViewBranches,  new ViewAllBranchGUI());
            btnUpdateBranch.Click  += (_, _) => LoadForm(btnUpdateBranch,  new UpdateBranchGUI());

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

            // ── Expense operations ────────────────────────────────────────────
            btnAddExpense.Click    += (_, _) => LoadForm(btnAddExpense,    new AddExpenseGUI());
            btnUpdateExpense.Click += (_, _) => LoadForm(btnUpdateExpense, new UpdateExpenseGUI());
            btnApproveExpense.Click += (_, _) => LoadForm(btnApproveExpense, new ApproveExpenseGUI());

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

        private static void WireCat(Button cat, FlowLayoutPanel sub, string title)
        {
            cat.Click += (_, _) =>
            {
                sub.Visible = !sub.Visible;
                cat.Text    = $"  {(sub.Visible ? "v" : ">")} {title}";
            };
        }

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
