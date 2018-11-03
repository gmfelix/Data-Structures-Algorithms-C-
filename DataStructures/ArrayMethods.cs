using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class ArrayMethods
    {
        protected internal static int[] GenerateRandomNumberArray(int x)
        {
            Random RandomGen = new Random();
            int[] Array = new int[x];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = i;
            }
            return Array;
        }

        protected internal static void PrintArray(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }
        }
    }
}
