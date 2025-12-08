using System;
using System.IO;
using System.Text;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\otwom\Desktop\example\MyFile.txt";

            //FileStream fileStream = new FileStream(filePath, FileMode.Create);
            //Console.WriteLine("File successfully created");

            // Opening the file in Append mode and writing data into it.
            //FileStream fileStream = new FileStream (filePath, FileMode.Append);
            //byte[] bytedata = Encoding.Default.GetBytes("C# is an object orinted programming language");
            //fileStream.Write(bytedata, 0, bytedata.Length);
            //fileStream.Close();
            //Console.WriteLine("Successfully saved data into file");

            // Reading from a file
            string data;
            using(StreamReader sr = new StreamReader(filePath))
            {
               data = sr.ReadToEnd();
            }
            Console.WriteLine(data);
        }
    }
}
