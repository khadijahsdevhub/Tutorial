using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.OOP_Concept
{
    internal class MethodOverload
    {
        public void Print()
        {
            Console.WriteLine("Hello");
        }
        public void Print(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }
        public void Print(string name, int age)
        {
            Console.WriteLine($"Hello, {name}. You are {age} years old.");
        }

        static void Main(string[] args)
        {
            MethodOverload mo = new MethodOverload();
            mo.Print("Bob", 30);
            mo.Print("Alice");
          
            mo.Print();
        }
    }
}
