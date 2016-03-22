using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySorter
{
    public class SortingByLineAbsValues : JaggedArrayBubbleSorter
    {
        public override int GetLineParameter(int[] arrayLine)
        {
            int maxAbs = -1;
            foreach (int number in arrayLine)
            {
                if (Math.Abs(number) > maxAbs)
                    maxAbs = Math.Abs(number);
            }
            return maxAbs;
        }
    }
}
