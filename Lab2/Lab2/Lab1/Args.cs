using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Args
    {
        public int code;
        public string reason;
        public string status;
        public override string ToString()
        {
            return $"Error code: {code}\nReason: {reason}\nStatus: {status}";
        }

    }
}
