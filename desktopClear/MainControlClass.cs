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
        public static void  showControl(Control control, Control content)
        {
            content.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            content.BringToFront();
            control.Focus();

            content.Controls.Add(control);
        }
    }
}
