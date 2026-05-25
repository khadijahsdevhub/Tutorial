using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.OOP_Concept.Collections
{
    internal class HashCollection
    {
        public static void Main(string[] args)
        {
            Hashtable htable = new Hashtable();
            htable.Add("Name", 100);
            htable.Add("Age", 200);
            htable.Add("City", 300);
            htable.Add("Country", 400);
            htable.Add("Email", 500);

            foreach (object key in htable.Keys)
            {
                Console.WriteLine("{0}: {1}", key, htable[key]);
            }


        } 
    }
}

        