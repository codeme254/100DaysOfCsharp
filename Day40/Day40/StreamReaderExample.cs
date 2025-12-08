using System;
using System.IO;

namespace Day40
{
    internal class StreamReaderExample
    {
        static void Main1(string[] args)
        {
            //StreamReader sr = new StreamReader(@"C:\Users\otwom\Desktop\example\MyFile.txt");

            //string data = sr.ReadToEnd();
            //Console.WriteLine(data);

            ////string data = sr.ReadLine();
            ////while (data != null)
            ////{
            ////    Console.WriteLine(data);
            ////    data = sr.ReadLine();
            ////}

            //sr.Close();

            using(StreamReader reader = new StreamReader(@"C:\Users\otwom\Desktop\example\MyFile.txt"))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
        }
    }
}
