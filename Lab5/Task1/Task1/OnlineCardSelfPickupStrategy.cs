using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class OnlineCardSelfPickupStrategy : IStrategy
    {
        private Dictionary<int, Product> availableProduct;
        private string storeAddress;

        public OnlineCardSelfPickupStrategy(string storeAddress, Dictionary<int, Product> availableProducts)
        {
            this.storeAddress = storeAddress;
            this.availableProduct = availableProducts;
        }
        public void Buy(Product product)
        {
            Console.WriteLine("Hello I am your online consultant, how could I help");
            Console.WriteLine("Wait a moment, I need to check if have such type of product...");
            Thread.Sleep(1000);
            if (!availableProduct.ContainsKey(product.GetProductId()))
            {
                Console.WriteLine("Sorry, There aren't such product in our online shop");
                return;
            }
            availableProduct.Remove(product.GetProductId());

            Console.WriteLine("Congratulations on your bought");
            product.DisplayInfo();

        }

        public void Pay()
        {
            Console.WriteLine("Transaction in process...");
            Thread.Sleep(1000);
            Console.WriteLine("We are waiting you at our warehouse to pick up your product");
        }

        public void Shipment()
        {
            Console.WriteLine("You successfully picked up your product");
        }

        public void Visit(string address)
        {
            if (!address.EndsWith(".com") || address != storeAddress)
            {
                throw new Exception("You entered wrong web address");
            }
            Console.WriteLine("Welcome to our site, our consultant will get in touch with you");
        }
    }
}
