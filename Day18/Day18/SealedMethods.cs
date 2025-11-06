using System;

namespace SealedMethods
{
    class Parent
    {
        public virtual void Show()
        {
            Console.WriteLine("Show method in the parent class");
        }
    }

    class Child : Parent
    {
        // This method cannot be overriden any further
        // because we are marking it as sealed
        public override sealed void Show()
        {
            Console.WriteLine("Show method in the child class");
        }
    }

    class GrandChild : Child
    {
        // This will give us an error
        //public override void Show()
        //{
        //    Console.WriteLine("Show method in grandchild");
        //}
    }
}
