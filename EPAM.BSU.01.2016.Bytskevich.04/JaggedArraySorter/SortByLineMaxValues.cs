using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySorter
{
    public class SortByLineMaxValues: JaggedArrayBubbleSorter
    {
        public override int GetLineParameter(int[] arrayLine)
        {
            int maxAbs = -1;
            foreach (int number in arrayLine)
            {
                if (number > maxAbs)
                    maxAbs = number;
            }
            return maxAbs;
        }
    }
}
