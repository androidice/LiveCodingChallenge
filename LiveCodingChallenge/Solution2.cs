using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingChallenge
{
    public class Solution2
    {
        public static Exception Validate(int num) {
            Exception ex;
            if (num < 0 || num > 100) {
                return new Exception(500, "Number should be greater than zero and less than 100");
            }
            return new Exception(200);
        }
    }
}
