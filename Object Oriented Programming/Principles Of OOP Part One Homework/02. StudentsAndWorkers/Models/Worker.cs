namespace _02.StudentsAndWorkers.Models
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : this(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary should be positive");
                }
                this.weekSalary = value;
            }
       }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Work hours cannot be negative.");
                }
                this.workHoursPerDay = value;
            }
        }


        public decimal MoneyPerHour()
        {
            int workDays = 5;
            decimal result = (weekSalary / workDays)/  this.WorkHoursPerDay;

            return result;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(string.Format("Worker: {0} {1}", this.FirstName, this.LastName));
            builder.AppendLine(string.Format("Work hours per day: {0} hours;", this.WorkHoursPerDay));
            builder.AppendLine(string.Format("Week salary: {0:F2} BGN", this.WeekSalary));
            builder.AppendLine(string.Format("Money per hour: {0:F2} BGN/hour", this.MoneyPerHour()));

            return builder.ToString();
        }
    }
}