using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class MobileOperator : IOperator
    {
        private List<Rate> rates;
        private string name;

        public string Name { get => name; set => name = value; }

        public MobileOperator(List<Rate> rates, string name)
        {
            this.rates = rates;
            this.name = name;
        }

        public void GetAllRates()
        {
            foreach (var rate in rates)
            {
                rate.GetInfo();
            }
        }

        public Rate ChangeRate(Rate newRate)
        {
            if (!rates.Contains(newRate))
            {
                Console.WriteLine("There isn't such option in our rates list");
                return null;
            }
            else
            {
                Console.WriteLine($"Congratulations your current rate changed to {newRate.Name}");
                return newRate;
            }
        }

        public void StopSubscription(Rate currentRate)
        {
            if (currentRate != null)
            {
                Console.WriteLine("Thanks for time you've been with us");
            }
            else
            {
                Console.WriteLine("You don't use any of our Rates");
            }

        }

        public void ShowYourRate(Rate currentRate)
        {
            if(currentRate != null)
            {
                currentRate.GetInfo();
            }
            else
            {
                Console.WriteLine("You aren't our subscriber");
            }
        }
    }
}
