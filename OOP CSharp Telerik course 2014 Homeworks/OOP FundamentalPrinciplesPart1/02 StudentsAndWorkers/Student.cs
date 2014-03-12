using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StudentsAndWorkers
{
    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int studentGrade)
            : base(firstName, lastName)
        {
            this.grade = studentGrade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Grade can not be a negative number");
                }
                this.grade = value;
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.grade;
        }
    }
}
