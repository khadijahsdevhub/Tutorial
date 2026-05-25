using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.OOP_Concept.Collections
{
    internal class DictionaryCollection
    {
        public static void Main()
        {
            Dictionary<string,object> dict = new Dictionary<string,object>();
            dict.Add("id", 001);
            dict.Add("fullname", "Adebola Grasshopper");
            dict.Add("salary", 23000);

            foreach (string  key in dict.Keys)
            {
                Console.WriteLine(key + ": " + dict[key]);
            }
        }
    }
}
