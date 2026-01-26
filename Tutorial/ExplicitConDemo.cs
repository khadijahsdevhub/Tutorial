using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class ExplicitConDemo
    {
        int i;
        bool b;

        public ExplicitConDemo() {
             i = 5;
             b = true;
        }

        static void Main(string[] args)
        {
            ExplicitConDemo demo1 = new ExplicitConDemo();
             
            Console.WriteLine(demo1.i);
            Console.WriteLine(demo1.b);
            //Console.WriteLine(demo3);
        }
    }
}
