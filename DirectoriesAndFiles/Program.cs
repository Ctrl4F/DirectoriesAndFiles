using System;
using System.IO;

namespace DirectoriesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\samples";
            //get the full path of all the directories at the tootPath
            string[] allDirectories = Directory.GetDirectories(rootPath);
            //ReadArray(allDirectories);
            //get nested dirctories 
            string[] includeNestedDirectories = Directory.GetFiles(rootPath, "*", SearchOption.AllDirectories);
            //get directory files
            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            ReadArray(files);

        }
        public static void ReadArray(string[] array)
        {
            foreach(string line in array)
            {
                Console.WriteLine(line);
            }
        }
    }
}
