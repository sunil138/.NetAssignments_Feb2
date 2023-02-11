using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Feb2
{
    public abstract class Vehicle
    {
        public abstract void speed(); 
        
    }

    public class Bike : Vehicle
    {
        public override void speed()
        {
            Console.WriteLine("Bike mileage is 45");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle bike = new Bike();   
            bike.speed();
        }
    }
}
