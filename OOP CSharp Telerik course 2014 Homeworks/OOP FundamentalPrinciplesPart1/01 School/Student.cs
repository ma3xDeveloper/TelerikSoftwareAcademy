using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    public class Student : Human, IComment
    {
        //fields
        private string idNumber;

        //constructor
        public Student(string name, string enteredIdNumber)
            : base(name)
        {
            this.idNumber = enteredIdNumber;
        }

        public string AddComment(string comment)
        {
            return "optional comment";
        }
    }
}
