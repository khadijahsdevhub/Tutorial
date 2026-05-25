using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.OOP_Concept.Collections
{
    internal class Generics2<T>
    {
        public void Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;

            Console.WriteLine(d1 + d2);
        }

        public void Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
        public void Mul(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
        public void Div(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        } 

      
    }
    class TestGenerics2
    {
  public static void Main()
        {
            Generics2<int> obj = new Generics2<int>(); 
        }
    }
}
