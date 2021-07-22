using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            foreach (var item in RemovingRepetitionExtension(SortingDetails.AllFilesPath))
            {
                checkedListBox1.Items.Add(item);
            }
        }
        private List<string> RemovingRepetitionExtension(List<string> list)
        {
            return GetOnlyExtension(list).Distinct().ToList(); //Remove repetition elements
        }
        private List<string> GetOnlyExtension(List<string> list)
        {
            List<string> onlyExtensionList = new List<string>();

            foreach (var item in list)
            {
                string fileExtension = Directory.Exists(item) ? "folder" : Path.GetExtension(item);
                onlyExtensionList.Add(fileExtension);
            }
            return onlyExtensionList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                List<string> listToRemove = new List<string>();
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    listToRemove.Add(item.ToString());
                }
                AddExtensionToListView(string.Join(", ", listToRemove));
                RemoveCheckedItems(listToRemove);
            }
            else
            {
                MessageBox.Show("Выберите форматы из списка");
            }
        }
        private void AddExtensionToListView(string strExten)
        {
            string[] row = { "Новая папка", strExten };
            ListViewItem itm = new ListViewItem(row);
            listView1.Items.Add(itm);
        }
        private void RemoveCheckedItems(List<string> listToRemove)
        {
            foreach (var item in listToRemove)
            {
                checkedListBox1.Items.Remove(item);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int arrLength = listView1.Items.Count;

            if (arrLength != 0)
            {
                for (int i = 0; i < arrLength; i++)
                {
                    string extensionName = GetExtensionFromListView(i);
                    SortingDetails.AddNewExtensionName(extensionName);
                    string folderName = listView1.Items[i].SubItems[0].Text;
                    SortingDetails.AddNewFolderName(folderName);
                }
                listView1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Добавте сортировачные папки!");
            }
        }
        private string GetExtensionFromListView(int rowCount)
        {
            return listView1.Items[rowCount].SubItems[1].Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count == 0 && listView1.Items.Count != 0)
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
