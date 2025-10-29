namespace CopyConstructor
{
    internal class CopyConstructor
    {
        //static void Main(string[] args)
        //{
        //    TestClass t1 = new TestClass(10, 20, 30, 40);
        //    t1.Display();
        //    TestClass t2 = new TestClass(t1);
        //    t2.Display();
        //    TestClass t3 = new TestClass(t1);
        //    t3.Display();
        //    TestClass t4 = new TestClass(t1);
        //    t4.Display();
        //}
    }

    class TestClass
    {
        int I, J, K, L;
        public TestClass(int i, int j, int k, int l)
        {
            I = i;
            J = j;
            K = k;
            L = l;
        }

        public TestClass(TestClass t) 
        {
            I = t.I; 
            J = t.J;
            K = t.K;
            L = t.L;
        }

        public void Display()
        {
            Console.WriteLine($"I = {I}");
            Console.WriteLine($"J = {J}");
            Console.WriteLine($"K = {K}");
            Console.WriteLine($"L = {L}");
        }
    }
}
