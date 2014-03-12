using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StudentsAndWorkers
{
    public abstract class Human
    {
        public string firstName;
        public string lastName;

        protected Human(string initialFirstName, string initialLastName)
        {
            this.firstName = initialFirstName;
            this.lastName = initialLastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First Name can not be null or empty!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last Name can not be null or empty!");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
