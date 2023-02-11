//AbstractionByProtected
using System; 

namespace AbstractionByProtected
{
    public abstract class Bird
    {
        protected string name = "Crow";
    }
    //public class FlyingBird: Bird
    //{

    //}
    class Program:Bird 
    {
        static void Main(string[] args)
        {
            Program bird = new Program();  
            Console.WriteLine(bird.name); 
        }
    }
}
