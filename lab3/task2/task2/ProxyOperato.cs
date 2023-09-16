using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class ProxyOperator : IOperator
    {
        MobileOperator mobileOperator;
        string _PUKCode;
        public string Name
        {
            get
            {
                return mobileOperator.Name;
            }
            set
            {
                throw new InvalidOperationException("Cannot set name of proxy operator!");
            }
        }
        public ProxyOperator(MobileOperator mobileOperator, string PUKCode)
        {
            this._PUKCode = PUKCode;
            this.mobileOperator = mobileOperator;
        }
        private bool CheckAccess()
        {
            Console.WriteLine("Input PUK code: ");
            string PUKCode = Console.ReadLine().Trim();
            return (PUKCode == PUKCode);
        }
        private bool EnterPUKCode()
        {
            if (!CheckAccess())
            {
                Console.WriteLine("Wrong PUK code!");
                return false;
            }
            return true;
        }

        public void GetAllRates()
        {
            if (EnterPUKCode())
                mobileOperator.GetAllRates();
        }

        public Rate ChangeRate(Rate rate)
        {
            if (EnterPUKCode())
            {
                return mobileOperator.ChangeRate(rate);
            }
            else return null;
        }

        public void StopSubscription(Rate currentRate)
        {
            if (EnterPUKCode())
                mobileOperator.StopSubscription(currentRate);

        }

        public void ShowYourRate(Rate currentRate)
        {
            if (EnterPUKCode())
                mobileOperator.ShowYourRate(currentRate);
        }
    }

}
