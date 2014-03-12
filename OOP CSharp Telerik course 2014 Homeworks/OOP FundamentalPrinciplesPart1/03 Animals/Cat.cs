using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animals
{
    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, Sex sex)
            : base(name, age, sex)
        {
        }
        public string ProduceSound()
        {
            return "Miaaauuuuuuu";
        }
    }
}
