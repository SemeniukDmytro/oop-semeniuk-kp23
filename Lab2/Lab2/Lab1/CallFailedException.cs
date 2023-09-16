using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class CallFailedException : Exception
    {
        public Args args;
        public CallFailedException(Args args) : base(args.ToString())
        {
            this.args = args;
        }
    }
}
