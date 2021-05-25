using desktopClear.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktopClear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            StartControl startControl = new StartControl();
            MainControlClass.showControl(startControl, panel1);
        }

        private void customizeDesign()
        {
            panelMediaSubmenu.Visible = false;
            panelPlaylistSubmenu.Visible = false;
            panelToolsSubmenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelMediaSubmenu.Visible == true)
                panelMediaSubmenu.Visible = false;
            if (panelPlaylistSubmenu.Visible == true)
                panelPlaylistSubmenu.Visible = false;
            if (panelToolsSubmenu.Visible == true)
                panelToolsSubmenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubmenu);
            StartControl startControl = new StartControl();
            MainControlClass.showControl(startControl, panel1);
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubmenu);
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubmenu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SortingDetails.AllFilesPath == null)
            {
                FolderSelectionControl folderSelectionControl = new FolderSelectionControl();
                MainControlClass.showControl(folderSelectionControl, panel1); 
            }
            else
            {
                MessageBox.Show("Папка для работы уже выбрана");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SortingDetails.AllFilesPath != null)
            {
                SortingControl sortingControl = new SortingControl();
                MainControlClass.showControl(sortingControl, panel1); 
            }
            else
            {
                MessageBox.Show("Выберите папку для сортировки!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DetailsControl detailsControl = new DetailsControl();
            MainControlClass.showControl(detailsControl, panel1);
        }
    }
}
