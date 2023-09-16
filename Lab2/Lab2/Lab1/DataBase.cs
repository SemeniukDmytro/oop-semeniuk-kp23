using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public abstract class DataBase
    {
        public abstract List<IPet> Data { get;}
        public abstract void GetDatabaseInfo();
        public abstract void AddToDatabase(IPet pet);
        public abstract void RemoveFromDatabase(IPet pet);
        
        protected bool IsPresented(List<IPet> db, IPet pet)
        {
            return db.Contains(pet);
        }

    }
}
