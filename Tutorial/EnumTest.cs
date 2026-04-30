using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{

    public enum Days:byte
    {
        Monday,Tuesday, Wednesday, Thursday, Friday,
    }
    internal class EnumTest
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello World");

            Days day1 = 0;
            Console.WriteLine( day1);

            Days day2 = (Days)2;
            Console.WriteLine(day2);

            Days day3 = Days.Wednesday;
            Console.WriteLine((int)day3);

            foreach(byte b in Enum.GetValues(typeof(Days))) 
                Console.WriteLine($"{b} : {(Days)b}");
            Console.ReadLine();
        }
    }
}
