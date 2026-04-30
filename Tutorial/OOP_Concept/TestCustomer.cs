using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.OOP_Concept
{
    internal class TestCustomer
    {
        public TestCustomer() { }

        public static void Main(string[] args)
        {
          Customer  CustomerOne = new Customer(001, "Adebimpe", false, 5000.00);
            Console.WriteLine("Initial Data");
            Console.WriteLine($" Custmer Id:{CustomerOne.CustId} \n Customer name: {CustomerOne.Cname} \n Customer status: {CustomerOne.Status} \n Customer Balance: {CustomerOne.Balance} ");

            Console.WriteLine(" \n" + "Modified Data for Inactive Customer");

            //CustomerOne.CustId = 002; //Assignment failed because there is no set access given
            CustomerOne.Cname += " Tijani";
            Console.WriteLine($"Customer name: {CustomerOne.Cname}");  // Did not update because status is false;

            CustomerOne.Balance -= 3000;
            Console.WriteLine($"Customer balance: {CustomerOne.Balance}");


            Console.WriteLine(" \n" + "Modified Data for Active Customer");

            CustomerOne.Status = true; //Set status to active
            CustomerOne.Cname += " Tijani";
            Console.WriteLine($"Customer name: {CustomerOne.Cname}");  // Did not update because status is false;

            CustomerOne.Balance -= 3000;
            Console.WriteLine($"Customer balance: {CustomerOne.Balance}");

            CustomerOne.Balance -= 1600;
            Console.WriteLine($"Customer balance: {CustomerOne.Balance}"); // returned old balcance because of the  >= 500 condition



        }
    }
}
