using System;

namespace _02.Human
{
    class Student : Human
    {
        private double grade;
        public Student(string firstName, string lastName, double grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }
        public double Grade
        {
            get { return this.grade; }
            private set { this.grade = value; }
        }
        public override string ToString()
        {
            return string.Format("First Name:{0}\n", this.FirstName) + string.Format("Last Name:{0}\n", this.LastName) + string.Format("Grade:{0}\n", this.Grade);
        }

    }
}
