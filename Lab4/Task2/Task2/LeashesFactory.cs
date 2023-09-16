using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class LeashesFactory : Company
    {
        public override IProduct FactoryMethod(string name, Size size)
        {
            return new Leash(name, size);
        }
    }
}
