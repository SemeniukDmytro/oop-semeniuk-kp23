using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class CollarsFactory : Company
    {
        public override IProduct FactoryMethod(string name, Size size)
        {
            return new Collar(name, size);
        }
    }
}
