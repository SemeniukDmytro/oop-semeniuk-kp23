using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Muzzle : IProduct
    {
        public string Name { get; set; }
        public Size Size { get; set; }

        public Muzzle(string name, Size size)
        {
            Name = name;
            Size = size;
        }
        public void Display()
        {
            Console.WriteLine($"The perfect muzzle: {Name} for your pet, size: {Size}");
        }
    }
}
