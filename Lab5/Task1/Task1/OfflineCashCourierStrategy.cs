using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class OfflineCashCourierStrategy : IStrategy
    {
        private Dictionary<int, Product> availableProduct;
        private string storeAddress;

        public OfflineCashCourierStrategy(string storeAddress, Dictionary<int, Product> availableProducts)
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
                Console.WriteLine("Sorry, There aren't such product in our offline shop");
                return;
            }
            availableProduct.Remove(product.GetProductId());

            Console.WriteLine("Congratulations on your bought");
            product.DisplayInfo();

        }

        public void Pay()
        {
            Console.WriteLine("Please pay full price when our courier will deliver your product");
        }

        public void Shipment()
        {
            Console.WriteLine("Our courier will ship your order in 2 days");
        }

        public void Visit(string address)
        {
            if (address != storeAddress)
            {
                Console.WriteLine("Oh no, you missed the street");
            }
            Console.WriteLine("Welcome to our store, our consultant will come soon");
        }
    }
}
