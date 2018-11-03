using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class BinarySearch
    {
        protected internal static int Search(int[] Array, int Element)
        {
            int Low = 0;
            int High = Array.Length - 1;
            while(Low <= High)
            {
                int CurrentIndex = (High + Low) / 2;
                if(Array[CurrentIndex] == Element)
                {
                    return CurrentIndex;
                }
                if(Array[CurrentIndex] < Element)
                {
                    Low = CurrentIndex + 1; 
                }
                else
                {
                    High = CurrentIndex-1;
                }
            }
            return -1;
        }
    }
}
