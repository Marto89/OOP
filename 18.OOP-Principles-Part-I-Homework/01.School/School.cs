using System;
using System.Collections.Generic;
using System.Text;

namespace _01.School
{
    public class School
    {
        private List<Class> classes;

        public School()
        {
            this.classes = new List<Class>();
        }
        public List<Class> Classes
        {
            get
            {
                return this.classes;
            }
            set
            {
                this.classes = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var n in this.Classes)
            {
                sb.AppendLine(n.ToString());
                foreach (var k in n.Students)
                {
                    sb.AppendLine(k.ToString());
                }
                foreach (var k in n.Teachers)
                {
                    sb.AppendLine(k.ToString());
                    foreach (var i in k.NumberOfDisc)
                    {
                        sb.AppendLine(i.ToString());
                    }
                }
            }
            return sb.ToString();
        }
    }
}
