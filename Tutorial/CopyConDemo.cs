using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class CopyConDemo
    {
        int i;
        bool b;
        public CopyConDemo(int x, bool y)
        {
            i = x;
            b = y;
        }
        // Copy Constructor
        public CopyConDemo(CopyConDemo obj)
        {
            i = obj.i;
            b = obj.b;
        }
        static void Main(string[] args)
        {
            CopyConDemo demo1 = new CopyConDemo(10, false);
            CopyConDemo demo2 = new CopyConDemo(demo1);
            Console.WriteLine(demo2.i);
            Console.WriteLine(demo2.b);
        }
    }
}
