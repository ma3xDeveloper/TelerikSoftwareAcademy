using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ReturnIndexOfBigger
{
    class IsBiggerThanNeighborsClass
    {
        public static bool CheckBiggerThanNeighbors(int[] array, int index)
        {
            if (array[index - 1] < array[index] && array[index] > array[index + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
