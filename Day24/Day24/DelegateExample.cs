using System;

public class Program
{
    // 1. Define a delegate type
    public delegate void MyDelegate(string message);

    // 2. Methods matching the delegate signature
    public static void MethodA(string msg)
    {
        Console.WriteLine("MethodA says: " + msg);
    }

    public static void MethodB(string msg)
    {
        Console.WriteLine("MethodB says: " + msg);
    }

    public static void Main1()
    {
        // 3. Create delegate instances
        MyDelegate del = MethodA; // Assign MethodA
        del += MethodB;           // Add MethodB (multicast)

        // 4. Invoke delegate (calls both methods)
        del("Hello from delegate!");

        // 5. Remove a method
        del -= MethodA;
        del("Only MethodB now!");
    }
}
