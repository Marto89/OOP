using System;
using System.Collections.Generic;

namespace _01.School
{
    public class Teacher : People
    {
        private List<Disciplines> numberOfDisc;
        public Teacher(string name)
            :base(name)
        {
            this.NumberOfDisc =new List<Disciplines>();
        }
        public List<Disciplines> NumberOfDisc
        {
            get { return this.numberOfDisc;}
            set { this.numberOfDisc=value;}
        }
        public override string ToString()
        {
            string result = this.Name + " " + this.NumberOfDisc.Count;
            return result;
        }
    }
}
