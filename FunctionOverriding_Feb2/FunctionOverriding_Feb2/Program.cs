//Function Overriding 
using System;

namespace FunctionOverriding_Feb2
{
    class CoolDrink
    {
        public virtual void Show()
        {
            Console.WriteLine("CoolDrink - Base Class");
        }
    }

    class Maaza : CoolDrink
    {
        public override void Show()
        {
            Console.WriteLine("Maaza - Derived Class");
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            CoolDrink maaza = new Maaza();
            maaza.Show(); 
        }
    }
}
