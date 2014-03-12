using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    public class Discipline
    {
        //fields
        private string disciplineName;
        private int numOfLectures;
        private int numOfExercises;

        //constructor
        public Discipline(string enteredDisciplineName, int enteredNumOfLectures, int enteredNumOfExercises)
        {
            this.disciplineName = enteredDisciplineName;
            this.numOfExercises = enteredNumOfExercises;
            this.numOfLectures = enteredNumOfLectures;
        }

        //access modifiers
        public string DisciplineName
        {
            get { return this.disciplineName; }
            set { this.disciplineName = value; }
        }

        public int NumOfLectures
        {
            get { return this.numOfLectures; }
            set { this.numOfLectures = value; }
        }

        public int NumOfExercises
        {
            get { return this.numOfExercises; }
            set { this.numOfExercises = value; }
        }


    }
}
