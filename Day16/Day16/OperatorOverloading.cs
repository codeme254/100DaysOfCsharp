using System;

namespace OperatorOverloading
{
    class Box
    {
        int Length;
        int Width;
        int Height;
        
        public Box(int l, int w, int h)
        {
            Length = l;
            Width = w;
            Height = h;
        }

        // Overiding the + operator to add two boxes
        public static Box operator +(Box b1, Box b2)
        {
            Box final = new Box(
                b1.Length + b2.Length,
                b1.Width + b2.Width,
                b1.Height + b2.Height
             );
            return final;
        }

        // Overiding the - operator to cut out a box from another
        public static Box operator -(Box b1, Box b2)
        {
            Box final = new Box(
                b1.Length - b2.Length,
                b1.Width - b2.Width,
                b1.Height - b2.Height
             );
            return final;
        }

        public void DisplayBox()
        {
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Height: {Height}");
        }
    }
    internal class OperatorOverloading
    {
        //static void Main( string[] args )
        //{
        //    Box b1 = new Box(10, 20, 30);
        //    Box b2 = new Box(5, 10, 15);
        //    Box b3 = b1 + b2; // Using the overloaded + operator
        //    Box b4 = b1 - b2; // Using the overloaded - operator
        //    b3.DisplayBox();
        //    b4.DisplayBox();
        //}
    }
}
