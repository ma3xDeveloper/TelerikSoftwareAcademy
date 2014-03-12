using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StudentsAndWorkers
{
    public class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Gandalf", "Gandalfov", 2));
            students.Add(new Student("Bilbo", "Bilbov", 1));
            students.Add(new Student("Lara", "Croft", 3));
            students.Add(new Student("Super", "Mario", 7));
            students.Add(new Student("Hristo", "Stoichkov", 6));
            students.Add(new Student("Dimitar", "Berbatov", 3));
            students.Add(new Student("Leo", "Messi", 9));
            students.Add(new Student("Kristiano", "Ronaldo", 4));
            students.Add(new Student("Ronaldo", "The Fenomen", 6));
            students.Add(new Student("Diego", "Maradona", 4));

            var sortedByGrade = students.OrderBy(x => x.Grade); // sorting students with LINQ by grade
            foreach (var item in sortedByGrade)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " GRADE: " + item.Grade);
            }
            Console.WriteLine(); Console.WriteLine();

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Ivan", "Ivanov", 300.23, 2));
            workers.Add(new Worker("Gimli", "Mimli", 130.23, 88));
            workers.Add(new Worker("Lego", "Lassss", 132, 55));
            workers.Add(new Worker("Petar", "Petrov", 334.23, 11));
            workers.Add(new Worker("Diego", "Forlan", 2342, 17));
            workers.Add(new Worker("Havier", "Mscherano", 1221, 8));
            workers.Add(new Worker("Pele", "P", 656.46, 9));
            workers.Add(new Worker("Kasias", "K", 3456, 8));
            workers.Add(new Worker("Fernando", "Torres", 654, 13));
            workers.Add(new Worker("Daniel", "Sturr", 43, 3));

            var sortedByMPH = workers.OrderByDescending(x => x.MoneyPerHour());  // sorting workers with LINQ by money per hour in descending order

            foreach (var item in sortedByMPH)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " WeekSalary: " + item.WeekSalary + " WorkHoursPerDay: " + item.WorkHoursPerDay + " MoneyPerHour: " + item.MoneyPerHour());
            }
            Console.WriteLine();

            List<Human> allHumansMerge = new List<Human>(); // merge all hummans with .AddRange
            allHumansMerge.AddRange(sortedByGrade);
            allHumansMerge.AddRange(sortedByMPH);
            Console.WriteLine("----ALL Merged Humans list:");
            foreach (var h in allHumansMerge)
            {
                Console.WriteLine(h);
            }

            var sortedallHumansMergeByFirstNameThenByLastName =
                allHumansMerge
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName);

            Console.WriteLine();
            Console.WriteLine("----ALL Merged and finaly sorted Humans list:");
            foreach (var human in sortedallHumansMergeByFirstNameThenByLastName)
            {
                Console.WriteLine(human);
            }
        }
    }
}
