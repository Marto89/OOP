using System;

namespace _02.Human
{
    class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            private set { this.weekSalary = value; }
        }
        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            private set { this.workHoursPerDay = value; }
        }
        public decimal MoneyPerHour()
        {
            return (this.WeekSalary / 5) / this.WorkHoursPerDay;
        }
        public override string ToString()
        {
            return string.Format("First Name:{0}\n", this.FirstName) + string.Format("Last Name:{0}\n", this.LastName) + string.Format("Week Salary:{0:c}\n", this.WeekSalary) + string.Format("WorkHours per Day:{0} ч.\n", this.WorkHoursPerDay) + string.Format("Money per Hour:{0:c}\n", this.MoneyPerHour());
        }
    }
}
