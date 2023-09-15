using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Product : IEquatable<Product>
    {
        private int _id;
        private string _name;
        private string _description;
        private int _price;

        public string Name { get => _name; }
        public string Description { get => _description; }

        public Product(int id, string name, string description, int price)
        {
            _id = id;
            _name = name;
            _description = description;
            _price = price;
        }
        public int GetProductId() => _id;
        public void DisplayInfo()
        {
            Console.WriteLine($"Product name: {_name}, price: {_price}\n" +
                $"Description: {_description}");
        }

        public bool Equals(Product? other)
        {
            return other._id != null && this._id == other._id;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Product objAsProduct = obj as Product;
            if (objAsProduct == null) return false;
            else return Equals(objAsProduct);
        }
        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }
    }
}
