//Hierarchial Inheritance
using System;

namespace HierarchialInheritance_Feb2
{
    class Vehicle
    {
        public void Name()
        {
            Console.WriteLine("Vehicle Name is Bus");
        }
    }
    class Car : Vehicle 
    { 
        public void Color()
        {
            Console.WriteLine("Car Color is Red");
        }
    }
    class Bike : Vehicle
    { 
        public void Mileage()
        {
            Console.WriteLine("Bike mileage is 40");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Color();
            car.Name();
            Bike bike = new Bike();
            bike.Mileage();
            bike.Name();
        }
    }
}
