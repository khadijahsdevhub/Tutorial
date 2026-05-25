using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.OOP_Concept
{
    internal class Students
    {
        public int id { get;   set; }
        public string name { get;   set; }
        public int classNo { get;   set; }
        public char grade { get;   set; }
    }

    class TestStudents
    {
        static void Main()
        {
            Students studentOne = new Students {id=001, name="Adebimpe", classNo=2, grade= 'A' };
            Students studentTwo = new Students { id = 002, name = "Shola", classNo = 6, grade = 'B' };
            Students studentThree = new Students { id = 003, name = "Tijani", classNo = 3, grade = 'F' };
            Students studentFour = new Students { id = 004, name = "Muhammad", classNo = 4, grade = 'C' };

            List<Students> students = new List<Students>();
            students.Add(studentOne);
            students.Add(studentTwo);
            students.Add(studentThree);
            students.Add(studentFour);

            foreach (var student in students)
            {
                Console.WriteLine($"Student Id: {student.id} \n Student name: {student.name} \n Student class: {student.classNo} \n Student grade: {student.grade}");
            }
        }
    }
}
