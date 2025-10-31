namespace Destructors
{
    internal class DestructorDemo
    {
        public DestructorDemo()
        {
            Console.WriteLine("Constructor object created");
        }

        ~DestructorDemo()
        {
            Console.WriteLine("Object destroyed");
        }
        static void Main(string[] args)
        {
            DestructorDemo obj1 = new DestructorDemo();
            DestructorDemo obj2 = new DestructorDemo();

            // making obj1 eligible for garbage collection
            obj1 = null;
            GC.Collect();
        }
    }
}
