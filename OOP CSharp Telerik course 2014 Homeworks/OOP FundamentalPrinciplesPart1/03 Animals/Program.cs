using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animals
{
    class Program
    {
        static void Main()
        {
            Animal[] animals = new Animal[]{
                new Frog("Kvaki", 2, Sex.Male),
                new Kitten("Kitka", 6),
                new Frog("Jabcho", 1, Sex.Female),
                new Dog("Murdjou", 11, Sex.Female),
                new Tomcat("Tomcho", 8),
                new Cat("Pisana", 1, Sex.Female),
                new Dog("Sharo", 31, Sex.Male)
            };

            Console.WriteLine("The avarage age of all Animals is: {0:0.0}", Animal.AvarageAge(animals));
            
            foreach (ISound animial in animals)
            {
                Console.WriteLine("{0}. AND I am saying to you '{1}'", animial, animial.ProduceSound());
            }
        }
    }
}
