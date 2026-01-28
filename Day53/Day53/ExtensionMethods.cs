using System;

namespace ExtensionMethods
{
    class ExtensionMethods
    {
        static void Main(string[] args)
        {
            string sentence = "Hello World, C# is fun";
            int wordCount = sentence.GetWordCount();
            Console.WriteLine(wordCount); // 5
        }
    }
    public static class ExtensionHelper
    {
        public static int GetWordCount(this string str)
        {
            if (!String.IsNullOrEmpty(str))
            {
                return str.Split(' ').Length;
            }
            return 0;
        }
    }
}
