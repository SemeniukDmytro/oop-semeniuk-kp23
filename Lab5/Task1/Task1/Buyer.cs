using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Buyer
    {
        private OrderType orderType;
        private Delivery delivery;
        private PaymentMethod paymentMethod;
        Product product;
        string shopAddress;

        public Buyer(OrderType orderType, Delivery delivery, PaymentMethod paymentMethod, Product product, string shopAddress)
        {
            this.product = product;
            this.orderType = orderType;
            this.delivery = delivery;
            this.paymentMethod = paymentMethod;
            this.shopAddress = shopAddress;
        }



        public void LookForProduct(IStrategy strategy)
        {
            strategy.Visit(shopAddress);
            strategy.Buy(this.product);
            strategy.Pay();
            strategy.Shipment();
        }

    }
}
