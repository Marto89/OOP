using System;


namespace _01.School
{
    public class Disciplines
    {
        private string name;
        private int numberOfLect;
        private int numberOfExc;

        public Disciplines(string name,int numberOfLect,int numberOfExc)
        {
            this.Name = name;
            this.NumberOfExc = numberOfExc;
            this.NumberOfLect = numberOfLect;
        }
        public string Name
        {
            get { return this.name;}
            set { this.name=value;}
        }

        public int NumberOfExc
        {
            get { return this.numberOfExc;}
            set { this.numberOfExc=value;}
        }

        public int NumberOfLect
        {
            get { return this.numberOfLect;}
            set { this.numberOfLect=value;}
        }
        public override string ToString()
        {
            string result = this.name + " " + this.NumberOfLect + " " + this.NumberOfExc;
            return result;
        }
    }
}
