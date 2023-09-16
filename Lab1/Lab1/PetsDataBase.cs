using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class PetsOwnersDataBase
    {
        private static Dictionary<int, int> petsOwnersNumbers;

        private PetsOwnersDataBase()
        {
            petsOwnersNumbers = new Dictionary<int, int>();
        }

        public static Dictionary<int, int> GetDatabaseInstance()
        {
            if (petsOwnersNumbers == null)
            {
                PetsOwnersDataBase database = new PetsOwnersDataBase();
            }
            return petsOwnersNumbers;
        }
    }
}
