using SuperMart_Pro.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SuperMart_Pro.View.Auth
{
    public partial class LoginGUI : Form
    {
        // ── Seed users — replace List<User> with a real service/repository call
        //    once the database layer is wired. Delete this block at that point.
        private static readonly List<User> _users = new List<User>
        {
            new User("U001", "Admin User",    new DateTime(1990,1,1), "Male", Array.Empty<byte>(),
                "01700000001", "admin@supermart.com",    "Dhaka", "admin",    "Admin@1234",
                UserRole.Admin,   true, "B001",
                "What was the name of your first school?", "greenwood",
                "What was your first pet's name?",         "buddy",
                null, null,
                DateTime.Now, "system", DateTime.Now, "system", null, string.Empty),

            new User("U002", "Manager One",   new DateTime(1992,5,15), "Male", Array.Empty<byte>(),
                "01700000002", "manager1@supermart.com", "Dhaka", "manager1", "Manager@1234",
                UserRole.Manager, true, "B001",
                "In which city or village were you born?", "dhaka",
                "What is your mother's middle name?",      "rose",
                null, null,
                DateTime.Now, "system", DateTime.Now, "system", null, string.Empty),

            new User("U003", "Cashier One",   new DateTime(1995,8,20), "Female", Array.Empty<byte>(),
                "01700000003", "cashier1@supermart.com", "Dhaka", "cashier1", "Cashier@1234",
                UserRole.Cashier, true, "B001",
                "What is the name of your childhood best friend?", "john",
                "What was your dream job as a child?",             "pilot",
                null, null,
                DateTime.Now, "system", DateTime.Now, "system", null, string.Empty),
        };

        /// <summary>
        /// Finds a user by username (case-insensitive).
        /// TODO: replace with UserService.FindByUsername(username) once DB is wired.
        /// </summary>
        internal static User? FindUser(string username) =>
            _users.Find(u => string.Equals(u.Username, username.Trim(),
                StringComparison.OrdinalIgnoreCase));

        // ─────────────────────────────────────────────────────────────────────

        public LoginGUI()
        {
            InitializeComponent();
        }

        // ─── Form Load ────────────────────────────────────────────────────────

        private void LoginGUI_Load(object sender, EventArgs e)
        {
            PasswordtextBox.PasswordChar = '*';
        }

        // ─── Show / Hide Password ─────────────────────────────────────────────

        private void ShowPasswordcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordtextBox.PasswordChar = ShowPasswordcheckBox.Checked ? '\0' : '*';
        }

        // ─── Login ────────────────────────────────────────────────────────────

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            UserNameErrorlabel.Text = string.Empty;
            PasswordErrorlabel.Text = string.Empty;

            string username = UserNametextBox.Text.Trim();
            string password = PasswordtextBox.Text;

            bool hasError = false;

            if (string.IsNullOrWhiteSpace(username))
            {
                UserNameErrorlabel.Text = "Username is required.";
                hasError = true;
            }

            if (string.IsNullOrEmpty(password))
            {
                PasswordErrorlabel.Text = "Password is required.";
                hasError = true;
            }

            if (hasError) return;

            // TODO: replace FindUser() with UserService.FindByUsername(username)
            User? user = FindUser(username);

            if (user == null || user.PasswordHash != password)
            {
                MessageBox.Show("Invalid username or password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordtextBox.Clear();
                PasswordtextBox.Focus();
                return;
            }

            MessageBox.Show($"Welcome, {user.Username}!  Role: {user.Role}", "Login Successful",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // TODO: open the appropriate dashboard based on user.Role
            // if (user.Role == UserRole.Admin)    new AdminDashboardGUI().Show();
            // if (user.Role == UserRole.Manager)  new ManagerDashboardGUI().Show();
            // if (user.Role == UserRole.Cashier)  new CashierDashboardGUI().Show();
            Close();
        }

        // ─── Cancel ───────────────────────────────────────────────────────────

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ─── Forget Password link ─────────────────────────────────────────────

        private void ForgetPasswordlabel_Click(object sender, EventArgs e)
        {
            var forgetPasswordGUI = new ForgetPasswordGUI();
            Hide();
            forgetPasswordGUI.ShowDialog();
            Show();
        }
    }
}
