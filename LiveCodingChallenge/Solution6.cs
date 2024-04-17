using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingChallenge
{
    public class Solution6
    {
        public static (int,Exception) Devide(int num1, int num2)
        {

            try {
                return (num1 / num2, new Exception(200));
            }catch {
                return (0, new Exception(500, "This operation is not possible"));
            }
        }
    }
}
