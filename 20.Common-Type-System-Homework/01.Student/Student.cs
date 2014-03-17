using System;

namespace _01.Student
{
    public enum Specialty { ATT, KST, Telekomunikacii, Avtomatika, Elektronika, Elektrotehnika, Ikonomika, NedvijimaSobstvenost, Finansi, Pedagogika, Psihologiq, Pravo, Istoriq }
    public enum University { UNSS, TU, KlimentOhridski, NBU }
    public enum Faculty { Transporten, Schetovodstvo, Ikonomika, FMI, Avtomatika, Stopanski }
    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string socialSecurityNumber;
        private string permanentAdress;
        private string mobilePhone;
        private string eMail;
        private string course;
        private Specialty speciality;
        private University university;
        private Faculty faculty;

        public Student(string firstName, string middleName, string lastName, string socialSecurityNumber, string permanentAdress, string mobilePhone, string eMail, string course, University university, Specialty speciality, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SocialSecurityNumber = socialSecurityNumber;
            this.PermanentAdress = permanentAdress;
            this.MobilePhone = mobilePhone;
            this.EMail = eMail;
            this.Course = course;
            this.university = university;
            this.speciality = speciality;
            this.faculty = faculty;

        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string SocialSecurityNumber
        {
            get { return this.socialSecurityNumber; }
            set { this.socialSecurityNumber = value; }
        }
        public string PermanentAdress
        {
            get { return this.permanentAdress; }
            set { this.permanentAdress = value; }
        }
        public string MobilePhone
        {
            get { return this.mobilePhone; }
            set { this.mobilePhone = value; }
        }
        public string EMail
        {
            get { return this.eMail; }
            set { this.eMail = value; }
        }
        public string Course
        {
            get { return this.course; }
            set { this.course = value; }
        }
        public Specialty Speciality
        {
            get { return this.speciality; }
        }
        public University University
        {
            get { return this.university; }
        }
        public Faculty Faculty
        {
            get { return this.faculty; }
        }
        public override bool Equals(object obj)
        {
            Student newStudent = obj as Student;
            if (newStudent == null)
            {
                return false;
            }
            if (this.Course == newStudent.Course)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }
        public static bool operator !=(Student student1, Student student2)
        {

            return !(Student.Equals(student1, student2));
        }
        public override string ToString()
        {
            return string.Format("First Name: {0}\nMiddle Name: {1}\nLast Name: {2}\nSSN: {3}\nPermanent Adress: {4}\nMobile Phone: {5}\nEmail: {6}\nCourse: {7}\nUniversity: {8}\nFaculty: {9}\nSpeciality: {10}\n", this.FirstName, this.MiddleName, this.LastName, this.SocialSecurityNumber, this.PermanentAdress, this.MobilePhone, this.EMail, this.Course, this.University, this.Faculty, this.Speciality);
        }
        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode() ^ this.LastName.GetHashCode() ^ this.SocialSecurityNumber.GetHashCode() ^ this.PermanentAdress.GetHashCode() ^ this.MobilePhone.GetHashCode() ^ this.EMail.GetHashCode() ^ this.Course.GetHashCode() ^ this.University.GetHashCode() ^ this.Faculty.GetHashCode() ^ this.Speciality.GetHashCode();
        }
        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SocialSecurityNumber, this.PermanentAdress, this.MobilePhone, this.EMail, this.Course, this.university, this.speciality, this.faculty);
        }

        public int CompareTo(Student student)
        {
            if (this.FirstName != student.FirstName)
            {
                return this.FirstName.CompareTo(student.FirstName);
            }
            return this.SocialSecurityNumber.CompareTo(student.socialSecurityNumber);
        }
    }
}
