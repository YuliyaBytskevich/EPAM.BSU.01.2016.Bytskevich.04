using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayBubbleSortUpdate2
{
    public static class JaggedArrayBubbleSorter
    {
        public static void Sort(int[][] source, IComparer<int[]> comparer, bool isDecreasingOrder = false)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            bool thereWerePermutations = true;
            for (int i = 0; (i < source.Length - 1) && thereWerePermutations; i++)
            {
                thereWerePermutations = false; 
                for (int j = 0; j < source.Length - i - 1; j++)
                {
                    if ((comparer.Compare(source[j], source[j+1]) > 0 && !isDecreasingOrder) || (comparer.Compare(source[j], source[j + 1]) < 0 && isDecreasingOrder))
                    {
                        Swap(ref source[j], ref source[j + 1]);
                        thereWerePermutations = true;
                    }
                }
            }
        }

        private static void Swap(ref int[] first, ref int[] second)
        {
            int[] temp;
            temp = first;
            first = second;
            second = temp;
        }
    }
}