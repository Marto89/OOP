using System;
using System.Collections.Generic;

namespace _01.School
{
    public class Class
    {
        private string classID;
        private List<Student> students;
        private List<Teacher> teachers;

        public Class(string id)
        {
            this.ClassID = id;
            this.teachers = new List<Teacher>();
            this.students = new List<Student>();
        }

        public string ClassID
        {
            get { return this.classID;}
            set { this.classID=value;}
        }
        public List<Teacher> Teachers
        {
            get { return this.teachers;}
        }
        public List<Student> Students
        {
            get { return this.students;}
        }
        public override string ToString()
        {
            string result = this.ClassID + " " + this.students.Count + " " + this.teachers.Count;
            return result;
        }
    }
}
