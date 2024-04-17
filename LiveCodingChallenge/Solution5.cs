using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingChallenge
{
    public class Solution5
    {
        public static bool ValidateList(List<int> list)
        {
            bool valid = true;
            foreach (int item in list)
            {
               if(item > int.MaxValue) { 
                    valid = false;
                    break;
                }
            }

            return valid;
        }
    }
}
