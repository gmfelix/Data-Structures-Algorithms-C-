using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class MergeSort
    {
        protected internal static void Sort(int[] Array, int Start, int End)
        {
            if (End - Start <= 1)
            {
                return;
            }

            int Middle = (Start + End) / 2;

            Sort(Array, Start, Middle);
            Sort(Array, Middle, End);

            Merge(Array, Start, Middle, End, new int[Array.Length]);
        }

        static void Merge(int[] Array, int Start, int Middle, int End, int[] Helper)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Helper[i] = Array[i];
            }

            int LeftIndex = Start;
            int RightIndex = Middle + 1;
            int SortedIndex = Start;

            while (LeftIndex < Middle && RightIndex < End)
            {
                if (Helper[LeftIndex] < Helper[RightIndex])
                {
                    Array[SortedIndex] = Helper[LeftIndex];
                    LeftIndex++;
                }
                else
                {
                    Array[SortedIndex] = Helper[RightIndex];
                    RightIndex++;
                }
                SortedIndex++;
            }

            while (LeftIndex < Middle)
            {
                Array[SortedIndex] = Helper[LeftIndex];
                LeftIndex++;
                SortedIndex++;
            }
        }
    }
}
