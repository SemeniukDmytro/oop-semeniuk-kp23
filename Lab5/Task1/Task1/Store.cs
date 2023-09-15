using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Store
    {
        string storageName;
        public string StorageName { get => storageName; }
        Dictionary<int, Product> _products;
        string? _address;
        public string Address { get => _address; }
        string? _webAddress;
        public string WebAddress { get => _webAddress; }
        List<OrderType> availableOrderTypes;

        public Store(string storageName, Dictionary<int, Product> products, string address = null, string webAddress = null)
        {
            this.storageName = storageName;
            this._products = products;
            this._address = address;
            this._webAddress = webAddress;
            availableOrderTypes = new List<OrderType>();
            GetAvailableOrderTypes();
        }

        private bool Validation() => !string.IsNullOrEmpty(_address) || !string.IsNullOrEmpty(_webAddress);

        public void GetAvailableOrderTypes()
        {
            if (!Validation())
            {
                availableOrderTypes = new List<OrderType>();
                return;
            }
            if (string.IsNullOrEmpty(_address))
                availableOrderTypes.Add(OrderType.OnlineOrder);
            else if (!string.IsNullOrEmpty(_webAddress))
                availableOrderTypes.Add(OrderType.OfflineOrder);
        }


    }
}
