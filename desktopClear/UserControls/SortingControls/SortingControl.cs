using desktopClear.UserControls.SortingControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktopClear.UserControls
{
    public partial class SortingControl : UserControl
    {
        public SortingControl()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Выберите папку для размещения отсортированых файлов";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Directory.CreateDirectory(folderBrowserDialog.SelectedPath + "\\Sorting Files");
                textBox1.Text = folderBrowserDialog.SelectedPath + "\\Sorting Files";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Sorting Files";
            textBox1.Text = desktopPath;
            try
            {
                if (!Directory.Exists(desktopPath))
                {
                    Directory.CreateDirectory(desktopPath);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Папка по умолчанию уже присутствует! Хотите выбрать ее для сохранения файлов?",
                        "Предупреждение",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.No)
                    {
                        textBox1.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox1.Text))
            {
                SortingDetails.FolderForSortedFiles = textBox1.Text;
                SortingFilesControls sortingFilesControls = new SortingFilesControls();
                MainControlClass.showControl(sortingFilesControls, panel1); 
            }
            else
            {
                MessageBox.Show("Выберите папку для хранения файлов!");
            }
        }
    }
}
