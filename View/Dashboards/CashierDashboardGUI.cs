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
    public partial class CashierDashboardGUI : Form
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

        public CashierDashboardGUI()
        {
            InitializeComponent();
            WireEvents();
        }

        private void WireEvents()
        {
            // ── category toggles ─────────────────────────────────────────────
            WireCat(btnCatProducts,  flowProducts,  "Products");
            WireCat(btnCatCashiers,  flowCashiers,  "Cashiers");
            WireCat(btnCatSuppliers, flowSuppliers, "Suppliers");
            WireCat(btnCatManagers,  flowManagers,  "Managers");
            WireCat(btnCatCustomers, flowCustomers, "Customers");

            // ── sub-button hover colours ──────────────────────────────────────
            foreach (var btn in new[] {
                btnViewProducts,
                btnViewCashiers,
                btnViewSuppliers,
                btnViewManagers,
                btnAddCustomer, btnViewCustomers, btnUpdateCustomer, btnDeleteCustomer,
            })
            {
                btn.MouseEnter += (_, _) => { if (btn != _activeSubBtn) btn.BackColor = SubBtnHover; };
                btn.MouseLeave += (_, _) => { if (btn != _activeSubBtn) btn.BackColor = SubBtnBg; };
            }

            // ── category hover colours ────────────────────────────────────────
            foreach (var cat in new[] { btnCatProducts, btnCatCashiers, btnCatSuppliers, btnCatManagers, btnCatCustomers })
            {
                cat.MouseEnter += (_, _) => cat.BackColor = CategoryHover;
                cat.MouseLeave += (_, _) => cat.BackColor = CategoryBg;
            }

            // ── Product operations ────────────────────────────────────────────
            btnViewProducts.Click  += (_, _) => LoadForm(btnViewProducts,  new ViewAllProductGUI());

            // ── Cashier operations ────────────────────────────────────────────
            btnViewCashiers.Click  += (_, _) => LoadForm(btnViewCashiers,  new ViewAllCashierGUI());

            // ── Supplier operations ───────────────────────────────────────────
            btnViewSuppliers.Click += (_, _) => LoadForm(btnViewSuppliers, new ViewAllSupplierGUI());

            // ── Manager operations ────────────────────────────────────────────
            btnViewManagers.Click  += (_, _) => LoadForm(btnViewManagers,  new ViewAllManagerGUI());

            // ── Customer operations ───────────────────────────────────────────
            btnAddCustomer.Click    += (_, _) => LoadForm(btnAddCustomer,    new AddCustomerGUI());
            btnViewCustomers.Click  += (_, _) => LoadForm(btnViewCustomers,  new ViewAllCustomerGUI());
            btnUpdateCustomer.Click += (_, _) => LoadForm(btnUpdateCustomer, new UpdateCustomerGUI());
            btnDeleteCustomer.Click += (_, _) => LoadForm(btnDeleteCustomer, new DeleteCustomerGUI());

            // ── Logout ────────────────────────────────────────────────────────
            btnLogout.Click += (_, _) =>
            {
                if (MessageBox.Show("Are you sure you want to logout?", "Logout",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Restart();
            };

            // ── header role label right-align on resize ───────────────────────
            pnlHeader.Resize += (_, _) =>
                lblRole.Location = new Point(
                    pnlHeader.Width - lblRole.Width - 16,
                    (pnlHeader.Height - lblRole.Height) / 2);
        }

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
