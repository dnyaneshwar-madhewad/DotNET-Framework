
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassConcepts
{
    class Program
    {
        static void Main1()
        {
            //System.Console.WriteLine("Hello World");
            //System.Console.ReadLine();

            System.Console.WriteLine("Inside Main Method 1 of class Program ");
            System.Console.ReadLine();

        }
        static void Main()
        {
            Class1 o1 = new Class1();
            o1.Display();
            Console.WriteLine("Inside Main Method 2 of class Program");
            Console.ReadLine();
        }

    }

    public class Class1
    {
        public void Display()
        {
            Console.WriteLine("Hello this is class 1 and Diplay method");
        }

    }
}