using desktopClear.UserControls.SortingControls;
using System;
using System.IO;
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
            FolderBrowserDialog sortedFileStorage = new FolderBrowserDialog();
            sortedFileStorage.Description = "Выберите папку для размещения отсортированых файлов";
            if (sortedFileStorage.ShowDialog() == DialogResult.OK)
            {
                Directory.CreateDirectory(sortedFileStorage.SelectedPath + "\\Sorting Files");
                sortedFilesStorageTextbox.Text = sortedFileStorage.SelectedPath + "\\Sorting Files";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Sorting Files";
            sortedFilesStorageTextbox.Text = desktopPath;
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
                        sortedFilesStorageTextbox.Clear();
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
            if (Directory.Exists(sortedFilesStorageTextbox.Text))
            {
                SortingDetails.FolderForSortedFiles = sortedFilesStorageTextbox.Text;
                SortingFilesControls sortingFilesControls = new SortingFilesControls();
                MainControlClass.showControl(sortingFilesControls, sortingControlPanel); 
            }
            else
            {
                MessageBox.Show("Выберите папку для хранения файлов!");
            }
        }
    }
}
