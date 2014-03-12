using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StudentsAndWorkers
{
    public class Worker : Human
    {
        private double workHoursPerDay;
        private double weekSalary;

        public Worker(string firstName, string lastName, double initialWorkHoursPerDay, double initialWeekSalary)
            : base(firstName, lastName)
        {
            this.workHoursPerDay = initialWorkHoursPerDay;
            this.weekSalary = initialWeekSalary;
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Work Hours Per Day can not be a negative number");
                }
                this.workHoursPerDay = value;
            }
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Week Salary can not be a negative number");
                }
                this.weekSalary = value;
            }
        }

        public double MoneyPerHour() //method that returns money earned by hour by the worker
        {
            return this.weekSalary / this.workHoursPerDay;
        }
    }
}
