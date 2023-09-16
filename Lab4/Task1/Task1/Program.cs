using Task1;

Ticket pilotsConcertTicket = new Ticket("21-Pilots", 10, 10);
Ticket pilotsConcertTicket11 = pilotsConcertTicket.DeepCopy();
Ticket pilotsConcertTicket12 = pilotsConcertTicket.DeepCopy();
pilotsConcertTicket11.TicketPlace.Seat = 11;
pilotsConcertTicket12.TicketPlace.Seat = 12;
pilotsConcertTicket.ShowTicketInfo();
pilotsConcertTicket11.ShowTicketInfo();
pilotsConcertTicket12.ShowTicketInfo();
Console.WriteLine();
Ticket lpTicket = new Ticket("Linkin Park", 20, 1);
var lpTicket2 = lpTicket.DeepCopy();
lpTicket2.TicketPlace.Seat = 2;
var lpTicket3 = lpTicket.DeepCopy();
lpTicket3.TicketPlace.Seat = 3;
lpTicket.ShowTicketInfo();
lpTicket2.ShowTicketInfo();
lpTicket3.ShowTicketInfo();