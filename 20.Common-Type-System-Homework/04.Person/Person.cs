using System;

namespace _04.Person
{
    class Person
    {
        private string name;
        private int? age;

        public Person(string name,int? age=null)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public override string ToString()
        {
            return this.Age == null ? string.Format("Name is {0} unknown years!", this.Name) : string.Format("Name is {0} and years is {1}!", this.Name, this.Age);
        }
    }
}
