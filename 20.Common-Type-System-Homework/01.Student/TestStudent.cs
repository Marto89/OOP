﻿/*
 * Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties. Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
 Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
 Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).
 */
using System;

namespace _01.Student
{
    class TestStudent
    {
        static void Main()
        {
            Student firstStudent = new Student("Ancho", "Genchev", "Praznikov", "2555", "Sofia", "0883987456", "minchopraznikov@abv.bg", "4", University.TU, Specialty.ATT, Faculty.Transporten);
            Student secondStudent = new Student("Mincho", "Genchev", "Praznikov", "2554", "Sofia", "0883987456", "minchopraznikov@abv.bg", "3", University.TU, Specialty.ATT, Faculty.Transporten);

            Console.WriteLine(Object.Equals(firstStudent, secondStudent));
            Console.WriteLine(firstStudent.ToString());
            Console.WriteLine(firstStudent.GetHashCode());
            Student newStudent = (Student)firstStudent.Clone();
            Console.WriteLine(firstStudent.CompareTo(secondStudent));
            Console.WriteLine(newStudent.ToString());
        }
    }
}
