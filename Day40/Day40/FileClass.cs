using System;
using System.IO;

namespace FileClass
{
    internal class FileClass
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\otwom\Desktop\example\MyFile.txt";
            //string destPath = @"C:\Users\otwom\Desktop\example\MyFile-Copy.txt";
            //string wrongFilePath = @"C:\Users\otwom\Desktop\example\MyFile.tx";
            //string wrongFilePath2 = @"C:\Users\otwom\Desktop\wrong\path\MyFile.txt";

            //Console.WriteLine(File.Exists(filePath)); // True
            //Console.WriteLine(File.Exists(wrongFilePath)); // False
            //Console.WriteLine(File.Exists(wrongFilePath2)); // False

            //string[] lines = File.ReadAllLines(filePath);
            //foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            //string text = File.ReadAllText(filePath);
            //Console.WriteLine(text);

            //File.Copy(filePath, destPath );

            File.Delete(filePath);
        }
    }
}
