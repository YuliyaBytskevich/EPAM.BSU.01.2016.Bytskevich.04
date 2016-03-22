﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayBubbleSortUpdate2
{
    public class ComparerForLineSums : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            if (x.Sum() < y.Sum())
                return -1;
            if (x.Sum() > y.Sum())
                return 1;
            return 0;
        }
    }
}
