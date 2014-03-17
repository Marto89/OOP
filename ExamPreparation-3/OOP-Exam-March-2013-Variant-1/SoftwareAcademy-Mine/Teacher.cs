namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : ITeacher
    {
        private string name;
        private IList<ICourse> courses;

        public Teacher(string name)
        {
            this.Name = name;
            this.courses = new List<ICourse>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty!");
                }
                this.name = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            if(course==null)
            {
                throw new ArgumentNullException("You must add a course!");
            }
            this.courses.Add(course);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append(string.Format("Teacher: Name={0}",this.Name));
            if(courses.Count>0)
            {
                sb.Append(";");
                sb.Append(" Courses=[");
                foreach (var course in this.courses)
                {
                    var currentCourse=course.Name.ToUpper();
                    sb.Append(currentCourse);
                    sb.Append(", ");
                }
                sb.Remove(sb.Length-2,2);
                sb.Append("]");
            }

            return sb.ToString();
        }
    }
}
