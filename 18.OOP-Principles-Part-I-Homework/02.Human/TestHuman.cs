//Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _02.Human
{
    class TestHuman
    {
        static Student[] ReadStudent()
        {
            Student[] student = new Student[10];
            student[0] = new Student("Mincho", "Praznikov", 2.3);
            student[1] = new Student("Petur", "Petrov", 3);
            student[2] = new Student("Georgi", "Georgiev", 5.6);
            student[3] = new Student("Ivan", "Ivanov", 1.3);
            student[4] = new Student("Dimitar", "Dimitrov", 3.3);
            student[5] = new Student("Gancho", "Minkov", 4);
            student[6] = new Student("Pencho", "Gerginski", 9);
            student[7] = new Student("Pavel", "Petrov", 9.9);
            student[8] = new Student("Penka", "Penkova", 5.4);
            student[9] = new Student("Dinko", "Dimitrov", 1.2);
            return student;
        }
        static Worker[] ReadWorker()
        {
            Worker[] worker = new Worker[10];
            worker[0] = new Worker("Mincho", "Praznikov", 500, 8);
            worker[1] = new Worker("Petur", "Petrov", 350, 4);
            worker[2] = new Worker("Georgi", "Georgiev", 600, 8);
            worker[3] = new Worker("Ivan", "Ivanov", 750, 8);
            worker[4] = new Worker("Dimitar", "Dimitrov", 550, 12);
            worker[5] = new Worker("Gancho", "Minkov", 250, 4);
            worker[6] = new Worker("Pencho", "Gerginski", 950, 8);
            worker[7] = new Worker("Pavel", "Petrov", 450, 8);
            worker[8] = new Worker("Penka", "Penkova", 250, 4);
            worker[9] = new Worker("Dinko", "Dimitrov", 990, 8);
            return worker;
        }
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding("Cyrillic");
            //Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). 
            Student[] students = ReadStudent();
            var sortedStudents =
                from student in students
                orderby student.Grade ascending
                select student;

            foreach (var n in sortedStudents)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine(new string('-', 80));
            //Initialize a list of 10 workers and sort them by money per hour in descending order. 
            Worker[] workers = ReadWorker();
            var sortedWorkers = workers.OrderByDescending(worker => worker.MoneyPerHour());
            foreach (var n in sortedWorkers)
            {
                Console.WriteLine(n);
            }
            //Merge the lists and sort them by first name and last name.
            var finalAnswer = sortedStudents.Concat<Human>(sortedWorkers)
                                            .OrderBy(x => x.FirstName)
                                            .ThenBy(x => x.LastName);

            Console.WriteLine(new string('-', 80));
            foreach (var n in finalAnswer)
            {
                Console.WriteLine(n);
            }
        }
    }
}
