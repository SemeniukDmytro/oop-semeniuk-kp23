using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class DogsDatabase : DataBase
    {
        private List<IPet> _dogs;
        public override List<IPet> Data => _dogs;
        public override void GetDatabaseInfo()
        {
            foreach (var item in _dogs)
            {
                item.GetAllInfo();
            }
        }
        public override void AddToDatabase(IPet pet)
        {
            if (IsPresented(_dogs, pet))
            {
                Console.WriteLine("dog has already been added earlier");
            }
            else
            {
                _dogs.Add(pet);
                Console.WriteLine("dog successfully added");
            }
        }


        public override void RemoveFromDatabase(IPet pet)
        {
            if (IsPresented(_dogs, pet))
            {
                Console.WriteLine("dog successfully removed");
            }
            else
            {
                _dogs.Add(pet);
                Console.WriteLine("there isn't such dog in DataBase");
            }
        }
    }
}
