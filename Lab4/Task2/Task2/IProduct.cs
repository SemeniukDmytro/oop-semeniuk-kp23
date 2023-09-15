using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal interface IProduct
    {
        public string Name { get; set; }
        public Size Size { get; set; }
        public void Display();
    }
}
