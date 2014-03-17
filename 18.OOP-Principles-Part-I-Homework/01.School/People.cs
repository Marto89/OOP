using System;

namespace _01.School
{
    public class People
    {
        private string name;

        public People(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return this.name; }
        }
    }
}
