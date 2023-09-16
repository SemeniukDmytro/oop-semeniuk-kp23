using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Ticket
    {
        public string ConcertName { get; set; }
        public TicketPlace TicketPlace { get; set; }

        public Ticket(string concertName, int seat, int row)
        {
            ConcertName = concertName;
            TicketPlace = new TicketPlace(seat, row);
        }

        public Ticket ShallowCopy()
        {
            return (Ticket)this.MemberwiseClone();
        }
        public Ticket DeepCopy()
        {
            Ticket other = (Ticket)MemberwiseClone();
            other.ConcertName = String.Copy(ConcertName);
            other.TicketPlace = new TicketPlace(TicketPlace.Row, TicketPlace.Seat);
            return other;
        }
        public void ShowTicketInfo()
        {
            Console.WriteLine($"Concert: {ConcertName}, row: {TicketPlace.Row}, seat {TicketPlace.Seat}");
        }
    }
}
