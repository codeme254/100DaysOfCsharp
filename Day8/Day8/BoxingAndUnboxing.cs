namespace BoxingAndUnboxing
{
    internal class BoxingAndUnboxing
    {
        static void Main()
        {
            int x = 10;
            object y = x; // boxing
            int z = (int)y; // unboxing
            Console.WriteLine($"x:{x}, y:{y}, z:{z}");
        }
    }
}
