namespace ConstructorsDemo
{
    internal class ConstructorsDemo
    {
        static int x;
        int y;
        static ConstructorsDemo()
        {
            Console.WriteLine("This is a static constructor");
            x = 55;
        }

        public ConstructorsDemo(int value)
        {
            Console.WriteLine("This is a non-static constructor");
            y = value;
        }

        public ConstructorsDemo(int x, int y)
        {
            Console.WriteLine("Overload 1");
        }

        public ConstructorsDemo(double x, int y)
        {
            Console.WriteLine("Overload 2");
        }

        public ConstructorsDemo(double x, double y)
        {
            Console.WriteLine("Overload 3");
        }
        static void Main(string[] args)
        {
            ConstructorsDemo d1 = new ConstructorsDemo(99);
        }
    }
}
