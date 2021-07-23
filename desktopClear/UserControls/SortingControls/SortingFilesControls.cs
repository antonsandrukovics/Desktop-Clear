using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace desktopClear.UserControls.SortingControls
{
    public partial class SortingFilesControls : UserControl
    {
        public SortingFilesControls()
        {
            InitializeComponent();
            ListBoxFilling();
        }
        private void ListBoxFilling()
        {
            foreach (var item in RemovingRepetitionExtension(GetExtensionList(SortingDetails.AllFilesPath)))
            {
                extensionsFilesCheckedListBox.Items.Add(item);
            }
        }
        private List<string> RemovingRepetitionExtension(List<string> filesPaths)
        {
            return filesPaths.Distinct().ToList();
        }
        private List<string> GetExtensionList(List<string> filesPaths)
        {
            List<string> extensionFilesList = new List<string>();
            foreach (var file in filesPaths)
            {
                string fileExtension = Directory.Exists(file) ? "folder" : Path.GetExtension(file);
                extensionFilesList.Add(fileExtension);
            }
            return extensionFilesList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (extensionsFilesCheckedListBox.CheckedItems.Count > 0)
            {
                List<string> selectedItemsFromFilesExtensionsList = new List<string>();
                foreach (var checkedItem in extensionsFilesCheckedListBox.CheckedItems)
                {
                    selectedItemsFromFilesExtensionsList.Add(checkedItem.ToString());
                }
                AddExtensionToListView(string.Join(", ", selectedItemsFromFilesExtensionsList));
                RemoveCheckedItems(selectedItemsFromFilesExtensionsList);
            }
            else
            {
                MessageBox.Show("Выберите форматы из списка");
            }
        }
        private void AddExtensionToListView(string extensionsString)
        {
            ListViewItem sortingFolderNameAndExtension = 
                new ListViewItem(new string[] { "Новая папка", extensionsString });
            sortinglistView.Items.Add(sortingFolderNameAndExtension);
        }
        private void RemoveCheckedItems(List<string> listToRemove)
        {
            foreach (var item in listToRemove)
            {
                extensionsFilesCheckedListBox.Items.Remove(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int listViewItems = sortinglistView.Items.Count;

            if (listViewItems != 0)
            {
                for (int i = 0; i < listViewItems; i++)
                {
                    string extensionName = GetExtensionFromListView(i);
                    SortingDetails.AddNewExtensionName(extensionName);
                    string directoryName = sortinglistView.Items[i].SubItems[0].Text;
                    SortingDetails.AddNewFolderName(directoryName);
                }
                sortinglistView.Enabled = false;
            }
            else
            {
                MessageBox.Show("Добавте сортировачные папки!");
            }
        }
        private string GetExtensionFromListView(int rowCount)
        {
            return sortinglistView.Items[rowCount].SubItems[1].Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (extensionsFilesCheckedListBox.Items.Count == 0 
                && sortinglistView.Items.Count != 0)
            {
                SortingDetails.StartSorting();
                MessageBox.Show("Сортировка прошла успешно!");
            }
            else
            {
                MessageBox.Show("error!");
            }
        }
    }
}
