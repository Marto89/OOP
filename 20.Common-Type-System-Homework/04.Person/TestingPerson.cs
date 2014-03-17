//Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so. Write a program to test this functionality.

using System;


namespace _04.Person
{
    class TestingPerson
    {
        static void Main(string[] args)
        {
            Person person = new Person("Miro",5);
            Console.WriteLine(person.ToString());
        }
    }
}
