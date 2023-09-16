using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class PetsDataBase : DataBase
    {
        private List<IPet> _pets = new List<IPet>();

        public override List<IPet> Data => _pets;

        public override void GetDatabaseInfo()
        {
            foreach (var item in _pets)
            {
                item.GetAllInfo();
            }
        }
        public override void AddToDatabase(IPet pet)
        {
            if( IsPresented(_pets, pet))
            {
                Console.WriteLine("pet has already been added earlier");
            }
            else
            {
                _pets.Add(pet);
                Console.WriteLine("pet successfully added");
            }
        }


        public override void RemoveFromDatabase(IPet pet)
        {
            if (IsPresented(_pets, pet))
            {
                Console.WriteLine("pet successfully removed");
            }
            else
            {
                _pets.Add(pet);
                Console.WriteLine("there isn't such pet in DataBase");
            }
        }
    }
}
