using System;
using System.Collections.Generic;
using System.IO;

namespace Program
{
    public class Program
    {
        static public string normalMatPath = @"C:\Users\cuong\Documents\CodeProject\ChangliReborn\assets\IngameMaterial\NormalMat";
        static public Dictionary<string, string> NormalMatDic = new Dictionary<string, string>();

        public static void Main()
        {
            /*
               NORMAL MATS (INCLUDING ASCENSION AND SKILL)
            */
            DirectoryInfo dir = new DirectoryInfo(normalMatPath);

            // Check if the directory exists
            if (!dir.Exists)
            {
                Console.WriteLine("Directory not found: " + normalMatPath);
                return;
            }

            // Get all directories and files within the directory
            FileSystemInfo[] items = dir.GetFileSystemInfos();

            // Iterate through each item (both files and folders)
            foreach (FileSystemInfo item in items)
            {
                // Add only folders to the dictionary
                if (item is DirectoryInfo)
                {
                    DirectoryInfo folder = (DirectoryInfo)item;
                    NormalMatDic.Add(folder.Name, folder.FullName);
                    Console.WriteLine(folder.Name);
                    Console.WriteLine(folder.FullName);
                }
            }
        }
    }
}
