using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class StaticConDemo
    {
        static int y;
        int x;
        static StaticConDemo()
        {
            Console.WriteLine("Static Constructor Invoked");
        }
        public StaticConDemo()
        {
            Console.WriteLine("Non Static Constructor Invoked");
        }
        static void Main(string[] args)
        {
            StaticConDemo demo1 = new StaticConDemo();
           // StaticConDemo demo2 = new StaticConDemo();

            Console.WriteLine("X:" + demo1.x);
            Console.WriteLine("Y:" + y);

        }
    }
}
 