using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal abstract class Company
    {
        public abstract IProduct FactoryMethod(string name, Size size);
        public void Advert(IProduct product)
        {
            var concreteproduc = FactoryMethod(product.Name, product.Size);
            Console.WriteLine($"Let us introduce our new invention from our {product.Name}'s factory");
            product.Display();

        }
    }
}
