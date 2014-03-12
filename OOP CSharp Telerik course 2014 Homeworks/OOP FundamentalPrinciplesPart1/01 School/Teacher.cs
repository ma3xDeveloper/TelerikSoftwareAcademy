using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    public class Teacher : Human, IComment
    {
        private List<Discipline> disciplines;

        //constructor
        public Teacher(string name, Discipline enteredDiscipline)
            : base(name)
        {
            disciplines = new List<Discipline>();
            disciplines.Add(enteredDiscipline);
        }

        //adding discipline
        public void AddDiscipline(Discipline addedDiscipline)
        {
            disciplines.Add(addedDiscipline);
        }

        public string AddComment(string comment)
        {
            return "optional comment";
        }
    }
}
