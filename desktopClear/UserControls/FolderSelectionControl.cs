using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace desktopClear
{
    public partial class FolderSelectionControl : UserControl
    {
        private List<string> filesNamesList;
        private List<string> chekedItemList = new List<string>();

        public FolderSelectionControl()
        {
            InitializeComponent();
        }

        private void buttonChoseDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Выберете папку для работы";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxDirectoryName.Text = folderBrowserDialog.SelectedPath;

                //Concat files path name and folder path name to list
                filesNamesList = Directory.GetFiles(folderBrowserDialog.SelectedPath)
                    .Concat(Directory.GetDirectories(folderBrowserDialog.SelectedPath)).ToList(); 

                FillTheChekedListBox(filesNamesList);
            }
        }
        private void FillTheChekedListBox(List<string> arrWithFileName)
        {
            filesNamesCheckedListBox.Items.Clear();
            foreach (var file in arrWithFileName)
            {
                filesNamesCheckedListBox.Items.Add(Path.GetFileName(file));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (filesNamesList != null && filesNamesList.Count > 0)
            {
                SelectAllInCheckBoxList();
            }
            else
            {
                MessageBox.Show("Выберите папку с файлами!!!");
            }
        }
        private void SelectAllInCheckBoxList()
        {
            for (int i = 0; i < filesNamesCheckedListBox.Items.Count; i++)
            {
                filesNamesCheckedListBox.SetItemChecked(i, true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filesNamesCheckedListBox.CheckedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Вы действительно хотите удалить выбранные элементы?",
                    "Предупреждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);

                if (result == DialogResult.Yes)
                {
                    DeleteSelectedItems();
                }
            }
            else
            {
                MessageBox.Show("Выберите элементы для удаления!!!");
            }
        }
        private void DeleteSelectedItems()
        {
            List<string> itemsToRemove = new List<string>();
            foreach (var item in filesNamesCheckedListBox.CheckedItems)
            {
                for (int j = 0; j < filesNamesList.Count; j++)
                {
                    if (item.ToString() == Path.GetFileName(filesNamesList[j]))
                    {
                        try
                        {
                            if (Directory.Exists(filesNamesList[j]))
                            {
                                Directory.Delete(filesNamesList[j]);
                                itemsToRemove.Add(item.ToString());
                            }
                            if (File.Exists(filesNamesList[j]))
                            {
                                File.Delete(filesNamesList[j]);
                                itemsToRemove.Add(item.ToString());
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            RemoveElementFromChekedList(itemsToRemove);
        }
        private void RemoveElementFromChekedList(List<string> itemsToRemove)
        {
            foreach (var item in itemsToRemove)
            {
                filesNamesCheckedListBox.Items.Remove(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (filesNamesCheckedListBox.CheckedItems.Count != filesNamesCheckedListBox.Items.Count)
            {
                foreach (var item in filesNamesCheckedListBox.CheckedItems)
                {
                    chekedItemList.Add(item.ToString());
                }
                SwitchOffAllObjects();
                SortingDetails.AllFilesPath = GetUnChekedItemList();
                MessageBox.Show($"Выбранные элементы сохранены! " +
                    $"Пожалуйста настройте сортровку!\n" +
                    $"Число файлов в списке: {filesNamesCheckedListBox.Items.Count}");
            }
            else
            {
                MessageBox.Show("Вы выбрали все файлы, " +
                    "количество файлов для сортировки ровно нулю!");
            }
        }
        private void SwitchOffAllObjects()
        {
            saveSelectedItemsBtn.Enabled = false;
            deleteSelectedObjectBtn.Enabled = false;
            selectAllBtn.Enabled = false;
            filesNamesCheckedListBox.Enabled = false;
            сhoseDirectoryBtn.Enabled = false;
            textBoxDirectoryName.Enabled = false;
        }
        private List<string> GetUnChekedItemList()
        {
            List<string> unChekedList = new List<string>();

            for (int i = 0; i < filesNamesCheckedListBox.Items.Count; i++)
            {
                if (!filesNamesCheckedListBox.CheckedItems.Contains(filesNamesCheckedListBox.Items[i]))
                {
                    unChekedList.Add(filesNamesList[i]);
                }
            }
            return unChekedList;
        }
    }
}
