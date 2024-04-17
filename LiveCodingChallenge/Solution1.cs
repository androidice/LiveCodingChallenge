using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingChallenge
{
    public class Solution1
    {
        public static Exception OpenFile(string filePath)
        {
            Exception ex;
            try
            {
                File.Open(filePath, FileMode.Open);
                ex = new Exception(200);
            }
            catch 
            {
                ex = new Exception(500, "There is a problem in opening the file");
            }
            return ex;
        }
    }
}
