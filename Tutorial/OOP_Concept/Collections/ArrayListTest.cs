using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.OOP_Concept.Collections
{
    internal class ArrayListTest
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Console.WriteLine(list.Capacity);
            list.Add(100);
            list.Add(200);
            list.Add(300);
            list.Add(400);
            list.Add(500);
            Console.WriteLine(list.Capacity);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            foreach(object obj in list)
            {
                Console.WriteLine(obj+ " ");
            }

            list.Insert(3, 350);
            Console.WriteLine(list.Capacity);
            foreach (object obj in list)
            {
                Console.WriteLine(obj + " ");
            }
            list.Remove(200);
            list.RemoveAt(0);
            Console.WriteLine(list.Capacity);
            foreach (object obj in list)
            {
                Console.WriteLine(obj + " ");
            }

        }
    }
}
