using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal interface IStrategy
    {
        public void Visit(string address);
        public void Buy(Product product);
        public void Pay();
        public void Shipment();
    }
}
