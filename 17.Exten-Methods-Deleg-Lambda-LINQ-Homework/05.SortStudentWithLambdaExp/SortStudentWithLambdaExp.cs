using System;
using System.Linq;

namespace _05.SortStudentWithLambdaExp
{
    class SortStudentWithLambdaExp
    {

        static void Main()
        {
            var students = new[]
            {
                new{FirstName="Ivan",LastName="Ivanov",age=25},
                new{FirstName="Georgi",LastName="Georgiev",age=22},
                new{FirstName="Petur",LastName="Petrov",age=18},
            };

            var sortedStudentLamda = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);
            Console.WriteLine("Sorted with Lambda expresions:\n");
            foreach (var n in sortedStudentLamda)
            {
                Console.WriteLine("{0} {1}", n.FirstName, n.LastName);
            }
            var sortedStudentLINQ =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select new { firstName = student.FirstName, lastName = student.LastName };
            Console.WriteLine("\nSorted with LINQ:\n");
            foreach (var n in sortedStudentLINQ)
            {
                Console.WriteLine("{0} {1}",n.firstName,n.lastName);
            }
        }
    }
}
