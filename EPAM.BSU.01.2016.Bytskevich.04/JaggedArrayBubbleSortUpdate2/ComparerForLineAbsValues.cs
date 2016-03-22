using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayBubbleSortUpdate2
{
    class ComparerForLineAbsValues : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            int xMaxAbs = -1, yMaxAbs = -1;
            foreach (int number in x)
            {
                if (Math.Abs(number) > xMaxAbs)
                    xMaxAbs = number;
            }
            foreach (int number in y)
            {
                if (Math.Abs(number) > yMaxAbs)
                    yMaxAbs = number;
            }
            if (xMaxAbs < yMaxAbs)
                return -1;
            if (xMaxAbs > yMaxAbs)
                return 1;
            return 0;
        }
    }
}
