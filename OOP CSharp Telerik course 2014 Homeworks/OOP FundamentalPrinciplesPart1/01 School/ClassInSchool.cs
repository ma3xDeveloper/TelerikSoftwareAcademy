using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    public abstract class ClassInSchool: IComment
    {
        private List<Student> students;

        private List<Teacher> teachers;

        internal string identifier;

        public ClassInSchool(string enteredIdentifier)
        {
            this.identifier = enteredIdentifier;
        }

        public List<Student> Student
        {
            get { return this.students; }
            set { this.students = new List<Student>(); }
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public List<Teacher> Teacher
        {
            get { return this.teachers; }
            set { this.teachers = new List<Teacher>(); }
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public string AddComment(string comment)
        {
            return "optional comment";
        }     
    }
}
