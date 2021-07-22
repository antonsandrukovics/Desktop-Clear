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

namespace desktopClear
{
    public partial class FolderSelectionControl : UserControl
    {
        private List<string> allFilesNameList;
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

                allFilesNameList = Directory.GetFiles(folderBrowserDialog.SelectedPath)
                    .Concat(Directory.GetDirectories(folderBrowserDialog.SelectedPath)).ToList(); //Concat files path name and folder path name to list

                FillTheChekedListBox(allFilesNameList);
            }
        }
        private void SelectAllInCheckBoxList()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void DeleteSelectedItems()
        {
            List<string> itemsToRemove = new List<string>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                for (int j = 0; j < allFilesNameList.Count; j++)
                {
                    if (item.ToString() == Path.GetFileName(allFilesNameList[j]))
                    {
                        try
                        {
                            if (Directory.Exists(allFilesNameList[j]))
                            {
                                Directory.Delete(allFilesNameList[j]);
                                itemsToRemove.Add(item.ToString());
                            }
                            if (File.Exists(allFilesNameList[j]))
                            {
                                File.Delete(allFilesNameList[j]);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (allFilesNameList != null && allFilesNameList.Count > 0)
            {
                SelectAllInCheckBoxList();
            }
            else
            {
                MessageBox.Show("Выберите папку с файлами!!!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 0)
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
        private void button3_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != checkedListBox1.Items.Count)
            {
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    chekedItemList.Add(item.ToString());
                }
                SwitchOffAllObjects();
                SortingDetails.AllFilesPath = GetUnChekedItemList();
                MessageBox.Show($"Выбранные элементы сохранены! Пожалуйста настройте сортровку!\nЧисло файлов в списке: {checkedListBox1.Items.Count}");
            }
            else
            {
                MessageBox.Show("Вы выбрали все файлы, количество файлов для сортировки ровно нулю!");
            }
        }

        private void FillTheChekedListBox(List<string> arrWithFileName)
        {
            checkedListBox1.Items.Clear();
            foreach (var file in arrWithFileName)
            {
                checkedListBox1.Items.Add(Path.GetFileName(file));
            }
        }
        

        
        private void RemoveElementFromChekedList(List<string> itemsToRemove)
        {
            foreach (var item in itemsToRemove)
            {
                checkedListBox1.Items.Remove(item);
            }
        }
        private void SwitchOffAllObjects()
        {
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            checkedListBox1.Enabled = false;
            buttonChoseDirectory.Enabled = false;
            textBoxDirectoryName.Enabled = false;
        }

        private List<string> GetUnChekedItemList()
        {
            List<string> unChekedList = new List<string>();

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (!checkedListBox1.CheckedItems.Contains(checkedListBox1.Items[i]))
                {
                    unChekedList.Add(allFilesNameList[i]);
                }
            }
            return unChekedList;
        }
    }
}
