using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1
{
    public class Display
    {
        //fields
        private int? size;

        private int? colors;

        //properties to encapsulate the data fields 
        public int? Size
        {
            get { return size; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Can NOT be a negative number!");
                }
                else
                {
                    this.size = value;
                }
            }
        }

        public int? Colors
        {
            get { return colors; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Can NOT be a negative number!");
                }
                else
                {
                    this.colors = value;
                }
            }
        }


    }
}
