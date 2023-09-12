using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class PetsDataBase
    {
        private static Dictionary<int, int> petsOwnersNumbers;

        private PetsDataBase()
        {
            petsOwnersNumbers = new Dictionary<int, int>();
        }

        public static Dictionary<int, int> GetDatabaseInstance()
        {
            if (petsOwnersNumbers == null)
            {
                PetsDataBase database = new PetsDataBase();
            }
            return petsOwnersNumbers;
        }
    }
}
