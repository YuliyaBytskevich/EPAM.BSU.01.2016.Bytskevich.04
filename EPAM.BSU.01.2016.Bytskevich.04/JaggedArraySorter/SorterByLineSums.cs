using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySorter
{
    public class SorterByLineSums: JaggedArrayBubbleSorter
    {
        public override int GetLineParameter(int[] arrayLine)
        {
            int sum = 0;
            foreach (int number in arrayLine)
            {
                sum += number;
            }
            return sum;
        }
    }
}
