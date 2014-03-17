namespace SoftwareAcademy
{
    using System;
    using System.Text;

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string name, string town, ITeacher teacher=null)
            :base(name,teacher)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The town cannot be empty!");
                }
                this.town = value;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder(base.ToString());

            sb.Append(string.Format("Town={0}", this.town));
            return sb.ToString();
        }
    }
}
