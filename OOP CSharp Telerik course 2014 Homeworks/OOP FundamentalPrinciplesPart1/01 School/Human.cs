using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    public abstract class Human
    {
        private string name;

        //constructor
        public Human(string Name)
        {
            this.name = Name;
        }

        //access modifiers
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

    }
}
