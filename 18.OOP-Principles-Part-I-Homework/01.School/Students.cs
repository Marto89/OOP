using System;

namespace _01.School
{
    public class Student : People
    {
        private int iD;

        public Student(string name, int iD)
            : base(name)
        {
            this.ID = iD;
        }

        public int ID
        {
            get { return this.iD; }
            set { this.iD=value;}
        }
        public override string ToString()
        {
            string result = this.Name +" "+this.ID;
            return result;
        }
    }
}
