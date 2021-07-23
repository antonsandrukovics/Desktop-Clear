using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace desktopClear
{
    class SortingDetails
    {
        private static List<string> directoryNamesForStoringSortedFiles = new List<string>(); 
        private static List<string> filesExtensionsList = new List<string>(); 
        private static string sortedFilesPath;
        private static List<string> filesPathList;
        private static DateTime lastSortingTime;

        public static List<string> AllFilesPath
        {
            get { return filesPathList; }
            set { filesPathList = value; }
        }

        public static string LastSortingTime
        {
            get { return lastSortingTime.ToString(); }
        }

        public static string FolderForSortedFiles
        {
            get { return sortedFilesPath; }
            set { sortedFilesPath = value; }
        }

        public static void AddNewFolderName(string value)
        {
            directoryNamesForStoringSortedFiles.Add(value);
        }

        public static void AddNewExtensionName(string value)
        {
            filesExtensionsList.Add(value);
        }

        public static void StartSorting()
        {
            CreateNewDirectories();
        }
        private static void CreateNewDirectories()
        {
            for (int i = 0; i < directoryNamesForStoringSortedFiles.Count; i++)
            {
                string newDirectoryPath = sortedFilesPath + "\\" 
                    + directoryNamesForStoringSortedFiles[i];
                Directory.CreateDirectory(newDirectoryPath);
                Transportation(newDirectoryPath, i);
            }
        }
        private static void Transportation(string newDirectoryPath, int itemIndex)
        {
            for (int i = 0; i < filesPathList.Count; i++)
            {
                if (ExtensionCheck(filesPathList[i], SeparateStringToFormats(itemIndex)))
                {
                    if (!Directory.Exists(filesPathList[i]))
                    {
                        string oldFilePath = filesPathList[i], 
                               newFilePath = newDirectoryPath + $"\\{Path.GetFileName(filesPathList[i])}";
                        MoveFile(oldFilePath, newFilePath);
                    }
                    else
                    {
                        string oldDirectotyPath = filesPathList[i],
                               newDirectotyPath = newDirectoryPath + $"\\{Path.GetFileName(filesPathList[i])}";
                        MoveDirectory(oldDirectotyPath, newDirectotyPath);
                    }
                }
            }
        }
        private static bool ExtensionCheck(string filePath, string[] extensionsArray)
        {
            for (int i = 0; i < extensionsArray.Length; i++)
            {
                string fileExtension = Path.GetExtension(filePath);
                string itemFromExtensionList = extensionsArray[i].Trim();
                bool isFileExtensionsEquals = fileExtension == itemFromExtensionList;
                bool isDirectoryExists = Directory.Exists(filePath);
                bool isFileExtensionEqualsEmpty = Path.GetExtension(filePath) == "";
                bool isExtensionEqualsToDirectory = itemFromExtensionList == "folder";
                if (isFileExtensionsEquals 
                    || isDirectoryExists & isFileExtensionEqualsEmpty & isExtensionEqualsToDirectory)
                {
                    return true;
                }
            }
            return false;
        }
        private static string[] SeparateStringToFormats(int index)
        {
            string[] arr = filesExtensionsList[index].Split(',');
            return arr;
        }
        private static void MoveFile(string oldFilesPath, string newFilesPath)
        {
            try
            {
                File.Copy(oldFilesPath, newFilesPath);
                File.Delete(oldFilesPath);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private static void MoveDirectory(string oldDirectoryPath, string newDirectoryPath)
        {
            try
            {
                Directory.Move(oldDirectoryPath, newDirectoryPath);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
