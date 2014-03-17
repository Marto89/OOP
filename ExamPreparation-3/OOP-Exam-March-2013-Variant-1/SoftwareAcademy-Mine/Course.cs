namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course : ICourse
    {

        private string name;
        private ITeacher teacher;
        private IList<string> topics;

        public Course(string name, ITeacher teacher = null)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty!");
                }
                this.name = value;
            }
        }

        public ITeacher Teacher
        {
            get
            {
                return this.teacher;
            }
            set
            {
                this.teacher = value;
            }
        }

        public void AddTopic(string topic)
        {
            if (string.IsNullOrEmpty(topic))
            {
                throw new ArgumentNullException("You must add a topic!");
            }
            this.topics.Add(topic);
        }
        public override string ToString()
        {

           

            var sb = new StringBuilder();

            sb.Append(string.Format("{0}: ", this.GetType().Name));
            sb.Append(string.Format("Name={0}; ", this.Name));
            var teacherName = this.teacher != null ? string.Format("Teacher={0}; ", this.Teacher.Name) : "";
            sb.Append(teacherName);
            var courseTopics = this.topics.Count > 0 ? string.Format("Topics=[{0}]; ", string.Join(", ", this.topics)) : "";
            sb.Append(courseTopics);
            return sb.ToString();
        }
    }
}
