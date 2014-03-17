using System;
using System.Linq;
using System.Text;

namespace _04.FindStudentBetween18And24Years
{
    class FindStudentBetween18And24Years
    {
        static void Main()
        {
            var students = new[]
            {
                new{FirstName="Marin",LastName="Petrov",Age=20},
                new{FirstName="Georgi",LastName="Georgiev",Age=26},
                new{FirstName="Ivan",LastName="Ivanov",Age=18},
            };
            var seekingStudent =
                from student in students
                where (student.Age >= 18 && student.Age <= 24)
                select new {firstName=student.FirstName,lastName=student.LastName };
            foreach (var n in seekingStudent)
            {
                Console.WriteLine("{0} {1}",n.firstName,n.lastName);
            }
        }
    }
}
