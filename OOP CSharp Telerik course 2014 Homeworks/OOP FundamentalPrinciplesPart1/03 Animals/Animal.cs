using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animals
{
    public abstract class Animal
    {
        private string name;
        private Sex sex;
        private int age;

        protected Animal(string inttialName, int intialAge, Sex initialSex)
        {
            this.Name = inttialName;
            this.Age = intialAge;
            this.sex = initialSex;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can not be null or empty!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age must be at least 1 !");
                }
                this.age = value;
            }
        }

        public Sex Sex
        {
            get { return sex; }
            protected set { sex = value; }
        }

        public override string ToString()
        {
            return string.Format("My name is {0}, I'm a {1}. I'm {2} and am {3} years old", this.name,
                this.GetType().Name, this.sex, this.age);
        }

        public static double AvarageAge(IEnumerable<Animal> animals) //calculate the average age of each kind of animal using a static method with LINQ
        {
            return animals.Average(x => x.Age);
        }
        
    }
}
