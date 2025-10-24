namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int johnAge = 8;
            if (johnAge > 18)
            {
                Console.WriteLine("John is an adult");
            }

            if (johnAge > 18)
            {
                Console.WriteLine("John is an adult");
            }
            else
            {
                Console.WriteLine("John is not yet an adult");
            }

            int a = 15, b = 25, c = 10;
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine($"Largest number is {a}");
                }
                else
                {
                    Console.WriteLine($"Largest number is {c}");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine($"Largest number is {b}");
                }
                else
                {
                    Console.WriteLine($"Largest number is {c}");
                }
            }

            int i = 20;
            if (i == 10)
            {
                Console.WriteLine("i is 10");
            }
            else if (i == 15)
            {
                Console.WriteLine("i is 15");
            }
            else if (i == 20)
            {
                Console.WriteLine("i is 20");
            }
            else
            {
                Console.WriteLine("We don't know i");
            }

            int dayNumber = 5;
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Unknown day number");
                    break;
            }

            int x = 1;
            while (x <= 5)
            {
                Console.WriteLine($"The value of x is {x}");
                x++;
            }

            int val = 1;
            do
            {
                Console.WriteLine($"Value: {val}");
                val++;
            } while (val <= 10);

            for (int num = 1; num <= 100; num++)
            {
                if (num % 5 == 0)
                {
                    continue;
                }
                Console.WriteLine($"Number: {num}");
            }
        }
    }
}
