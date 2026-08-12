using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SuperMart_Pro.Utils
{
    public static class RoundedControlHelper
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        /// <summary>
        /// Applies circular rounded corners to any WinForms Control (TextBox, RichTextBox, ComboBox, Button, Panel, etc.)
        /// </summary>
        /// <param name="control">The target control to round.</param>
        /// <param name="radius">Corner radius in pixels.</param>
        public static void ApplyRoundedCorners(Control control, int radius = 12)
        {
            if (control == null || control.Width <= 0 || control.Height <= 0) return;

            try
            {
                control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width + 1, control.Height + 1, radius, radius));
            }
            catch
            {
                // Fallback gracefully if GDI call fails
            }

            control.SizeChanged += (s, e) =>
            {
                if (control.Width > 0 && control.Height > 0)
                {
                    try
                    {
                        control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width + 1, control.Height + 1, radius, radius));
                    }
                    catch
                    {
                    }
                }
            };
        }
    }
}
