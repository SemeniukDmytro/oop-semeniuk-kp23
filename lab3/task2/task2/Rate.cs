using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Rate
    {
        private Internet internet;
        private Minutes minutes;
        private SMS sms;
        private int price;
        private string name;
        public string Name { get => name; }
        public Rate(Internet internet, Minutes minutes, SMS sms, int price, string name)
        {
            this.internet = internet;
            this.minutes = minutes;
            this.sms = sms;
            this.price = price;
            this.name = name;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Rate: {name}\nInternet: within Ukraine {internet.InternetGB}, roaming: {internet.RoamingGB}" +
                $"\nMinutes:  within Ukraine {minutes.WithinUkraine}, roaming: {minutes.InRoaming}\n" +
                $"SMS: within Ukraine {sms.WithinUkraine}, roaming: {sms.InRoaming}" +
                $"Price: {price}");
        }
    }
}
