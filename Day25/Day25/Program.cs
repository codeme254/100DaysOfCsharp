using System;

namespace MulticastDelegate
{
    public delegate void RectangleDelegate(double Width, double Height);
    internal class Rectangle
    {
        void GetArea(double Width, double Height)
        {
            Console.WriteLine($"Area of the rectangle is {Width * Height}");
        }

        void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine($"Perimeter of the recangle is {2 * Width + 2 * Height}");
        }
        static void Main1(string[] args)
        {
            Rectangle rect = new Rectangle();
            RectangleDelegate rectDelegate = new RectangleDelegate(rect.GetArea);
            // binding more methods to this delegate - thus a multicast delegate
            rectDelegate += rect.GetPerimeter;

            // Invoking the delegate, all the methods bound to this delegate will be executed
            rectDelegate(10, 20);

            // Removing a method from a delegate
            rectDelegate -= rect.GetArea;
            rectDelegate.Invoke(5, 6); // We can also use the Invoke method to call a delegate
        }
    }
}
