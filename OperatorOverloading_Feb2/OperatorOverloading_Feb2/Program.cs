//Operator Overloading
using System; 

namespace OperatorOverloading_Feb2
{
    class Calculator
    {
        int numberOne, numberTwo,result;
        public Calculator(int numberOne,int numberTwo)
        {
            this.numberOne = numberOne;
            this.numberTwo= numberTwo;  
        }

        public static Calculator operator -(Calculator c)
        {
            //c.numberOne = -c.numberOne;
            //c.numberTwo = -c.numberTwo;
            c.result = c.numberOne - c.numberTwo; 
;            return c;
        }
        public void print()
        {
            //Console.WriteLine("NumberOne= " + numberOne);
            //Console.WriteLine("Numbertwo= " + numberTwo);
            Console.WriteLine("Result is: " + result); 
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(50,30);
            calculator = -calculator;  
            calculator.print(); 
        }
    }
}
