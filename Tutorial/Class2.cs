using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Class2:Class1
    {
        public Class2(): base(10)
        {
            Console.WriteLine("Class 2 constructor is called");

        }
        public void Test3()
        {
            Console.WriteLine("Method 3");
        }

        static void Main(string[] args)
        {
            Object obj = new Object();
            Class2 class2 = new Class2();
            Class1 class1 = new Class1(12);

        }
    }
}
