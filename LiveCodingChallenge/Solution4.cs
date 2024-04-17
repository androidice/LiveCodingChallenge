using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingChallenge
{
    public class Solution4
    {
        public static (int,Exception )TryParse(string input) {
            Exception ex;
            try {
               return  (int.Parse(input), new Exception(200));
            }
            catch
            {
               return (0, new Exception(500, "Input Cannot be parsed"));
            }
        }
    }
}
