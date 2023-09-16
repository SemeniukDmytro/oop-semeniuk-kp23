using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal interface IOperator
    {
        public string Name { get; set; }
        public void GetAllRates();
        public Rate ChangeRate(Rate rate);
        public void StopSubscription(Rate currentSubscription);
        public void ShowYourRate(Rate currentRate);
    }
}
