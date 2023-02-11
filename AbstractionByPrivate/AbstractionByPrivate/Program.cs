//AbstractionByPrivate
using System;

namespace AbstractionByPrivate
{
    public abstract class Teacher
    {
        private string teacherName="Prudhvi"; 
    }
    public class Student:Teacher
    {
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Teacher student = new Student();
            //Console.WriteLine(student.teacherName); //It generates an error because private data member can be access inside the class only.
        }
    }
}
