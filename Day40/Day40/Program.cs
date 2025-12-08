using System;
using System.IO;

namespace StreamWriterExample
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            using(StreamWriter sr = new StreamWriter(@"C:\Users\otwom\Desktop\example\numbers.txt", true))
            {
                for (int i = 0; i < 1_000; i++)
                {
                    sr.Write($"{i}, ");
                }
            }
        }
    }
}
