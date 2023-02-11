//SingleInheritance
using System;

namespace SingleLevelInheritance_Feb2
{
    class Animal
    {
        public void Sleep() 
        {
            Console.WriteLine("Sleeping");
        }
    }

    class Dog : Animal
    { 
        public void Bark()  
        {
            Console.WriteLine("Dog is Barking");  
        }
    }

    class Program 
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Bark(); 
            dog.Sleep(); 
        }
    }
}
