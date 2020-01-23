//Kelly Vu
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {

            //these are parallel arrays. all have same amount of inputs
            int[] studentIds = new int[3];
            string[] studentFirstNames = new string[3];
            string[] studentLastNames = { "Harris", "Ackerman", "Johnson"};
            studentIds[0] = 1;
            studentIds[1] = 2;
            studentFirstNames[0] = "Katie";
            studentFirstNames[1] = "Kelly";
            studentFirstNames[2] = "Adam";
            //use a loop for collections to display. It's easier

            for (int i = 0; i < studentIds.Length; i++)
            {
                Console.WriteLine($"{studentLastNames[i]}, {studentFirstNames[i]}, [{studentIds[i]}].");
            }

            //Dictionary- key value pairs

            Dictionary<int, string> student = new Dictionary<int, string>();
            student.Add(1, "Kelly Vu");
            student.Add(2, "Adam Ack");
            student.Add(3, "Keith Urban");

            if (student.ContainsKey(1))
            {
                student[1] = "Some new value";

            }
            else
            {
                student.Add(1, "Some value");
            }

            foreach (var key in student.Keys)
            {
                Console.WriteLine($"{student[key]}.");
            }


            //making instances and objects

            List<Student> studs = new List<Student>();

            Student Kelly = new Student();

            Kelly.FirstName = "Kelly";
            Kelly.LastName = "Vu";
            Kelly.ID = 1;

            studs.Add(Kelly);

            for (int i = 0; i < studentIds.Length; i++)
            {
                Student s = new Student();
                s.FirstName = studentFirstNames[i];

                studs.Add(s);
            }

            foreach (var studetn in studs)
            {
                Console.WriteLine($"{student.LastName}");
            }



            Console.ReadKey();


        }
    }
}
