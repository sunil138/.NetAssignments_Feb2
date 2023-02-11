//Multilevel Inheritance
using System;

namespace MultiLevelInheritance_Feb2
{
    class GrandFather
    {
        public void Property()
        {
            Console.WriteLine("GrandFather's Property");
        }
    }

    class Father:GrandFather
    {
        public void Money()
        {
            Console.WriteLine("Father's Money");
        }
    }

    class Son:Father
    {
        public void Land()
        {
            Console.WriteLine("Son's Land");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Son son = new Son();
            son.Property();
            son.Money();
            son.Land(); 
        }
    }
}
