using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal static class DataBaseManager
    {
        static Dictionary<int, int> dataBase;
        static DataBaseManager()
        {
            dataBase = PetsDataBase.GetDatabaseInstance();
        }
        
        public static void AddToDb(string qrCode, int phoneNumber)
        {
            if (qrCode.Length == 7 && !IsPresentedInDB(qrCode))
            {
                dataBase.Add(int.Parse(qrCode), phoneNumber);
            }
        }

        public static bool IsPresentedInDB(string qrCode)
        {
            return dataBase.ContainsKey(int.Parse(qrCode)) ? true : false;
        }

        public static void RemoveFromDb(string qrCode)
        {
            if (IsPresentedInDB(qrCode))
            {
                dataBase.Remove(int.Parse(qrCode));
            }
        }
    }
}
