using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySorter
{
    public abstract class JaggedArrayBubbleSorter
    {
        struct JaggedArrayLine
        {
            public int parameter;
            public int[] lineAddress;
        }

        public void Sort(int[][] source, bool inIncreasingOrder = true)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            JaggedArrayLine[] jaggedArrLines = new JaggedArrayLine[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                jaggedArrLines[i].parameter = GetLineParameter(source[i]);
                jaggedArrLines[i].lineAddress = source[i]; 
            }
            bool thereWerePermutations = true;
            for (int i = 0; (i < source.Length - 1) && thereWerePermutations; i++)
            {
                thereWerePermutations = false;
                for (int j = 0; j < source.Length - i - 1; j++)
                {
                    if ((inIncreasingOrder && jaggedArrLines[j].parameter > jaggedArrLines[j + 1].parameter) || (!inIncreasingOrder && jaggedArrLines[j].parameter < jaggedArrLines[j + 1].parameter))
                    {
                        Swap(ref jaggedArrLines[j], ref jaggedArrLines[j + 1]);
                        thereWerePermutations = true;
                    }
                }
            }
            for (int i = 0; i < source.Length; i++)
                source[i] = jaggedArrLines[i].lineAddress;
        }

        private static void Swap (ref JaggedArrayLine first, ref JaggedArrayLine second)
        {
            JaggedArrayLine temp;
            temp = first;
            first = second;
            second = temp;
        }

        public abstract int GetLineParameter(int[] arrayLine);

    }
}
