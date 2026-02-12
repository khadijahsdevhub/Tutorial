using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.OOP_Concept { 

    public class Person
{
        int Id;
        string? Name, Address, PhoneNo, Gender;
        short Age;
}

    internal class Student :Person
    {
        string? Class;
        char? Grade;

    }
}
