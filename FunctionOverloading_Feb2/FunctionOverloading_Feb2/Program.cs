//Function OverLoading
using System; 

namespace FunctionOverloading_Feb2
{
     class Program
    {
        public static int Add(int a,int b)
        {
            return a + b;
        }
        public static float Add(float a, float b)
        {
            return a + b; 
        }
        public static string Add(string a, string b)
        {
            return a + " " + b;
        }
        static void Main(string[] args)
        {
            int result = Add(12, 34);
            Console.WriteLine("Addition of integers are: " + result);
            float resultOne = Add(4.4f, 8.9f);
            Console.WriteLine("Addition of float are: " + resultOne);
            string resultTwo = Add("Sunil", "Yaswanth");
            Console.WriteLine("Addition of Strings are: " + resultTwo);
        }
    }
}
