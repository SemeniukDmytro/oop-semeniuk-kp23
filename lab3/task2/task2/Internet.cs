using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Internet
    {
        private int internetGB;
        private int roamingGB;
        public int InternetGB { get => internetGB; }
        public int RoamingGB { get => roamingGB; }
        public Internet(int internetGB, int roamingGB)
        {
            this.internetGB = internetGB;
            this.roamingGB = roamingGB;
        }


    }
}
