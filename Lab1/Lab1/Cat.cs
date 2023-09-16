using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab1
{
    internal class Cat : HomePet
    {
        List<string> placesToStroke;

        public Cat(string name, string qrCodeNumber, int age, int ownerPhoneNumber, List<string> placesToStroke) : base(name, qrCodeNumber, age, ownerPhoneNumber)
        {
            this.placesToStroke = placesToStroke;
        }

        public void ShowPlacesToStroke()
        {
            foreach (var place in placesToStroke)
            {
                Console.WriteLine(place);
            }
        }

        public List<string> GetFavoriteFood(List<string> food)
        {
            var result = new List<string>();
            foreach (string meal in food)
            {
                if (meal.Contains("meat") || meal.Contains("milk"))
                {
                    result.Add(meal);
                }
            }
            return result;
        }

    }
}
