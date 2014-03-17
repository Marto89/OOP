namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course, ILocalCourse
    {
        private string lab;

        public LocalCourse(string name, string lab, ITeacher teacher = null)
            :base(name,teacher)
        {
            this.Lab = lab;
        }
        public string Lab
        {
            get
            {
                return this.lab; ;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The laboratories cannot be empty!");
                }
                this.lab=value;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder(base.ToString());
            sb.Append(string.Format("Lab={0}", this.lab));
            return sb.ToString();
        }
    }
}
