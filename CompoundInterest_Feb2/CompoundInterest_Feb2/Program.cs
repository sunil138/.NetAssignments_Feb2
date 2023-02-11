using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundInterest_Feb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total=0, principle, rate, noOfYears,result;
            Console.WriteLine("Enter Principle");
            principle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter rate");
            rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter no.of years");
            noOfYears = Convert.ToDouble(Console.ReadLine());
            result = (principle * (1 + rate / 100)); 
            Console.WriteLine("Compound interest is: " + result); 
        }
    }
}
