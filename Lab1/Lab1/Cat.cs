using Lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2
{
    internal class Cat : HomePet, IActivity, IHomeProtector, IPet
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

        void IHomeProtector.MakeSound()
        {
            Console.WriteLine("Cat is sleeping");
        }

        public void Attack()
        {
            Console.WriteLine("Cat is sleeping");
        }

        public void ProtectHost()
        {
            Console.WriteLine("Cat is sleeping");
        }

        public void Play()
        {
            Console.WriteLine("Cat has caught a mouse");
        }

        public void HaveAMeal()
        {
            Console.WriteLine("Mrrr, this chicken is so delicious");
        }

        void IActivity.MakeSound()
        {
            Console.WriteLine("Mrrr");
        }

        public void GetAllInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, QR: {QrCodeNumber}, Owner's phone number: {OwnerPhoneNumber}");
        }
    }
}
