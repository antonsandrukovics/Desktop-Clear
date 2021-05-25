using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktopClear
{
    class SortingDetails
    {
        private static List<string> listOfNewFolderNames = new List<string>();
        private static List<string> listOfFileFormatNames = new List<string>();
        private static string folderForSortedFiles;
        private static List<string> allFilesPath;
        private static DateTime lastSortingTime;

        public static List<string> AllFilesPath
        {
            get { return allFilesPath; }
            set { allFilesPath = value; }
        }
        public static string LastSortingTime
        {
            get { return lastSortingTime.ToString(); }
        }
        public static string FolderForSortedFiles
        {
            get { return folderForSortedFiles; }
            set { folderForSortedFiles = value; }
        }
        public static void AddNewFolderName(string value)
        {
            listOfNewFolderNames.Add(value);
        }

        public static void AddNewExtensionName(string value)
        {
            listOfFileFormatNames.Add(value);
        }

        public static void StartSorting()
        {
            CreateNewFolders();
        }
        private static void CreateNewFolders()
        {
            for (int i = 0; i < listOfNewFolderNames.Count; i++)
            {
                string newFolderPath = folderForSortedFiles + "\\" + listOfNewFolderNames[i];
                Directory.CreateDirectory(newFolderPath);
                Transportation(newFolderPath, i);
            }
        }
        private static void Transportation(string folderName, int index)
        {
            for (int i = 0; i < allFilesPath.Count; i++)
            {
                if (FormatCheck(allFilesPath[i], SeparateStringToFormats(index)))
                {
                    if (!Directory.Exists(allFilesPath[i]))
                    {
                        string oldFilePath = allFilesPath[i];
                        string newFilePath = folderName + $"\\{Path.GetFileName(allFilesPath[i])}";
                        try
                        {
                            File.Copy(oldFilePath, newFilePath);
                            File.Delete(oldFilePath);
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        try
                        {
                            string oldPath = allFilesPath[i];
                            string newPath = folderName + $"\\{Path.GetFileName(allFilesPath[i])}";
                            Directory.Move(oldPath, newPath);
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private static bool FormatCheck(string file, string[] format)
        {            
            for (int i = 0; i < format.Length; i++)
            {
                string extensionFile = Path.GetExtension(file);
                string formatFile = format[i].Trim();
                if (extensionFile == formatFile || Directory.Exists(file) & Path.GetExtension(file) == "" & format[i] == "folder")
                {
                    return true;
                }
            }
            return false;
        }

        private static string[] SeparateStringToFormats(int index)
        {
            string[] arr = listOfFileFormatNames[index].Split(',');
            return arr;
        }
    }
}
