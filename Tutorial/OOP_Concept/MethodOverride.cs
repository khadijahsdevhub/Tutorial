using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.OOP_Concept
{
    internal class MethodOverride
    {
        public virtual void Show () {
        Console.WriteLine("Base class method");
        }

        public void Display()
        {
            Console.WriteLine("Base class display method");
        }
    }

    class Derived : MethodOverride
    {
        public override void Show () {
        Console.WriteLine("Derived class method");
        }
    }

    class Derived2 : MethodOverride
    {
        public override void Show()
        {

            Console.WriteLine("Derived2 class method"); // This will override the base class Show method
        }
        public new void Display()
        {
            Console.WriteLine("Derived2 class display method"); // This will hide the base class Display method
        }



        static void Main(string[] args)
        {
            MethodOverride mo1 = new MethodOverride();
            mo1.Show(); // Output: Base class method
            Derived d = new Derived();
            d.Show(); // Output: Derived class method
            MethodOverride mo2 = new Derived();
            mo2.Show(); // Output: Derived class method
            MethodOverride mo3 = new Derived2();
            mo3.Show(); // Output: Derived2 class method
        }
    }
        
}
