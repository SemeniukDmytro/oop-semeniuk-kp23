using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Client
    {
        string _fullName;
        string _phoneNumber;
        Rate _currentRate;
        public Client(string s_fullName, string phoneNumber, Rate currentRate)
        {
            _fullName = s_fullName;
            _phoneNumber = phoneNumber;
            _currentRate = currentRate;
        }
        public void ViewRates(IOperator mobileOperator)
        {
            mobileOperator.GetAllRates();
        }
        public void ChangeRate(IOperator mobileOperator, Rate rate)
        {
            _currentRate = mobileOperator.ChangeRate(rate);
        }
        public void DisplayCurrentRate()
        {
            Console.Write($"Client {this._fullName} has ");
            if (_currentRate == null) Console.WriteLine(" no tariff");
            else _currentRate.GetInfo();
        }
        public void StopSubscription(IOperator mobileOperator)
        {
            mobileOperator.StopSubscription(_currentRate);
        }
    }

}
