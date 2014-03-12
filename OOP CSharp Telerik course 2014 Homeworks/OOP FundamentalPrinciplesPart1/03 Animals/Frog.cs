using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Animals
{
    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, Sex sex)
            : base(name, age, sex)
        {
        }
        public string ProduceSound()
        {
            return "Gwwwaaaaaakkkkk";
        }
    }
}
