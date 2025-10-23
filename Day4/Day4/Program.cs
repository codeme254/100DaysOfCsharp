namespace Operators
{
    internal class Opeartors
    {

        static void Main()
        {
            int a = 10;
            int b = 5;
            // Addition
            Console.WriteLine(a + b);
            // Subtraction
            Console.WriteLine(a - b);
            // Multiplication
            Console.WriteLine(a * b);
            // Divison
            Console.WriteLine(a / b);
            // Modulos
            Console.WriteLine(a % b);

            /// Assignment Operators
            //Simple Assignment Operator
            int x = 10;
            Console.WriteLine(x); // 10
            // Addition Assignment
            int aa = 10;
            aa += 20;
            Console.WriteLine(aa); // 30
            // Subtraction Assignment
            int sa = 20;
            sa -= 15;
            Console.WriteLine(sa); // 5
            // Multiplication Assignment
            int ma = 10;
            ma *= 50;
            Console.WriteLine(ma); // 500
            // Division Assignment
            int da = 50;
            da /= 10;
            Console.WriteLine(da); // 5
            // Modulus Assignment
            int mas = 50;
            mas %= 3;
            Console.WriteLine(mas); // 2

            /// Relational Operators
            // Equal to
            Console.WriteLine(10 == 10); // True
            Console.WriteLine(10 == 20); // False
            // Not Equal to
            Console.WriteLine(10 != 20); // True
            Console.WriteLine(10 != 10); // False
            // Less Than
            Console.WriteLine(10 < 20); // True
            Console.WriteLine(10 < 5); // False
            // Less Than or equal to
            Console.WriteLine(10 <= 10); // True
            Console.WriteLine(20 <= 10); // False
            // Greater than
            Console.WriteLine(20 > 10); // True
            Console.WriteLine(10 > 20); // False
            // Greater Than or equal to
            Console.WriteLine(10 >= 10); // True
            Console.WriteLine(10 >= 20); // False

            /// Logical Operators
            // Logical OR (||)
            Console.WriteLine(true || false); // True
            Console.WriteLine(false || true); // True
            Console.WriteLine(true || true); // True
            Console.WriteLine(false || false); // False

            // Logical AND (&&)
            Console.WriteLine(true && true); // True
            Console.WriteLine(true && false); // false
            Console.WriteLine(false && true); // false
            Console.WriteLine(false && false); // false

            // Logical NOT (!)
            Console.WriteLine(!true); // False
            Console.WriteLine(!false); // True


            // Post-increment operator
            int y = 5;
            int z = y++;
            Console.WriteLine(z); // 5
            Console.WriteLine(y); // 6

            // Pre-increment operator
            int j = 5;
            int k = ++j;
            Console.WriteLine(k); // 6
            Console.WriteLine(j); // 6

            // Post-decrement operator
            int c = 5;
            int d = c--;
            Console.WriteLine(d); // 5
            Console.WriteLine(c); // 4

            // Pre-decrement operator
            int h = 5;
            int i = --h;
            Console.WriteLine(i); // 4
            Console.WriteLine(h); // 4

            int age = 25;
            string s = age > 18 ? "Adult" : "Child";
            Console.WriteLine(s); // Adult
        }
    }
}
