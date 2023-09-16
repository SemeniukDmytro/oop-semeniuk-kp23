using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Collar : IProduct
    {
        public string Name { get; set ; }
        public Size Size { get; set ; }

        public Collar(string name, Size size)
        {
            Name = name;
            Size = size;
        }
        public void Display()
        {
            Console.WriteLine($"The perfect collar: {Name} for your pet, size: {Size}");
        }
    }
}
