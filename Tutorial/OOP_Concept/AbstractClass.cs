using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.OOP_Concept
{
    internal class AbstractClass
    {
    }

    internal abstract class AbsParent{
        public void Add(int x, int y)
        {
            Console.WriteLine($"The sum of {x} and {y} is: {x+y}");
        }

        public void Sub(int x, int y)
        {
            Console.WriteLine($"The difference of {x} and {y} is: {x - y}");
        }

        public abstract void Mul(int x, int y);
        public abstract void Div(int x, int y);

    }

    internal  class AbsChild : AbsParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine($"The product of {x} and {y} is: {x * y}");
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine($"The quotient of {x} and {y} is: {x / y}");
        }

        public static void Main(string[] args)
        {
            AbsChild child = new AbsChild();

            child.Add(100, 22);
            child.Sub(100, 42);
            child.Mul(100, 2);
            child.Div(100, 4);
        }
    }


      
}
