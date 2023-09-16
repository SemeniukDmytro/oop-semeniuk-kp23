using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class TicketPlace
    {
        public int Row { get; set; }
        public int Seat { get; set; }

        public TicketPlace(int row, int seat)
        {
            Row = row;
            Seat = seat;
        }
    }
}
