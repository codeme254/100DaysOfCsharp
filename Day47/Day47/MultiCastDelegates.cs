using System;

namespace DelegatesReview
{
    internal class MultiCastDelegates
    {
        delegate int RectangleDelegate(int l, int w);

        static int GetArea(int length, int width)
        {
            return length * width;
        }

        static int GetPerimeter(int length, int width)
        {
            return (2 * length) + (2 * width);
        }

        static void Main1(string[] args)
        {
            RectangleDelegate rec = new RectangleDelegate(GetArea);
            rec += GetPerimeter;

            Console.WriteLine(rec(5, 10)); ;
        }
    }
}
