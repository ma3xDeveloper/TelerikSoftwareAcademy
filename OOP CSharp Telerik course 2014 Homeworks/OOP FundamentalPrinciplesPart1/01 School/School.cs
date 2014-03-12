using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    public abstract class School
    {
        private List<ClassInSchool> schoolClasses;

        //constructor
        public School()
        {
            this.schoolClasses = new List<ClassInSchool>();
        }


        //adding class
        public void AddClass(ClassInSchool addedClass)
        {
            this.schoolClasses.Add(addedClass);
        }
    }
}