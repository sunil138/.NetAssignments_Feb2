using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample_Feb2
{
     class Birds
    {
        public void FlyingCategory()
        {
            Console.WriteLine("Birds Will Fly");
        }
        public void NonFlyingCategory()
        {
            Console.WriteLine("Birds Will Fly");
        }
    }
    class Pigeon:Birds
    {
        public void Fly()
        {
            Console.WriteLine(" Pigeon will fly");
        }
        public void NonFly()
        {
            Console.WriteLine("some birds will not fly"); ;
        }
    }
    internal class Program
    {
        //string vehicleName = "BMW";
        //string modelname = "2017 Edition";
        //string year="2017"; 
        static void Main(string[] args)
        {
            Pigeon kabutar = new Pigeon();
            kabutar.FlyingCategory();
            kabutar.NonFlyingCategory();
            kabutar.Fly();
            kabutar.NonFly();
            //Program program = new Program();
            //Console.WriteLine("Vehicle Name is: "+program.vehicleName);
            //Console.WriteLine("Model Name is: "+program.modelname);
            //Console.WriteLine("Year is: "+program.year);   
        }
    }
}
