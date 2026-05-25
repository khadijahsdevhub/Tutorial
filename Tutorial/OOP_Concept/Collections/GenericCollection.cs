using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.OOP_Concept.Collections
{
    internal class GenericCollection
    {

        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(100);
            list.Add(200);
            list.Add(300);
            list.Add(400);
            list.Add(500);
            Console.WriteLine(list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i] + " ");
                Console.WriteLine(" ");
            }

            list.Insert(3, 350); 
            list.RemoveAt(2);
            

            foreach (int i in list)
            {
                Console.WriteLine(i + " ");
            }

        }
              
    }
}
