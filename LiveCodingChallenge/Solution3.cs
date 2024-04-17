using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingChallenge
{
    public class Solution3
    {
        public static int CalculateAverage(int[] nums)
        {
            int average = 0;
            average = nums.Sum(x => x)/ nums.Length;
            return average;
        }
    }
}
