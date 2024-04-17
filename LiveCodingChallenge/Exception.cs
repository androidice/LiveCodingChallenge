using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingChallenge
{
    public class Exception
    {
        public int Status;
        public string Message;
        public Exception(int status = 200, string message = "") {
            Status = status;
            this.Message = message;
        }
    }
}
