using System;

namespace MultipleInheritance
{
    interface IAnimal
    {
        void Eat();
    }

    interface IPet
    {
        void Play();
    }

    class Dog: IAnimal , IPet
    {
        public void Eat()
        {
            Console.WriteLine("Animal eating");
        }

        public void Play()
        {
            Console.WriteLine("Pet playing");
        }
    }
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Dog d = new Dog();
        //    d.Eat();
        //    d.Play();
        //}
    }
}
