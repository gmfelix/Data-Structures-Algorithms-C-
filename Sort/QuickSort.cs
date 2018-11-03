using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class QuickSort
    {
        protected internal static void Sort(int[] Array, int Start, int End)
        {
            if (End - Start <= 1)
            {
                return;
            }
            int PartitionIndex = Partition(Array, Start, End);
            Sort(Array, Start, PartitionIndex - 1);
            Sort(Array, PartitionIndex, End);
        }

        static int Partition(int[] Array, int Start, int End)
        {
            int Pivot = Array[Start];
            int SmallerThanIndex = Start + 1;
            for (int i = Start + 1; i < End; i++)
            {
                if (Array[i] <= Pivot)
                {
                    int TempSwap = Array[SmallerThanIndex];
                    Array[SmallerThanIndex] = Array[i];
                    Array[i] = TempSwap;
                    SmallerThanIndex++;
                }
            }
            int TempPivot = Array[Start];
            Array[Start] = Array[SmallerThanIndex - 1];
            Array[SmallerThanIndex - 1] = TempPivot;

            return SmallerThanIndex - 1;
        }
    }
}
