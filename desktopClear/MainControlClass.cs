using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktopClear
{
    class MainControlClass
    {
        public static void  showControl(Control control, Control Content)
        {
            Content.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            Content.BringToFront();
            control.Focus();

            Content.Controls.Add(control);
        }
    }
}
