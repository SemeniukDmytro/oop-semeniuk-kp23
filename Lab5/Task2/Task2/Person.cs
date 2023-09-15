using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Person
    {
        private string name;
        private bool isReadyToBuy;
        public bool IsReadyToBuy { get => isReadyToBuy; }
        private string ticket;
        List<Person> friends;
        public List<Person> Friends { get => friends; set => friends = value; }
        private int money;
        private int ticketPrice;

        public Person (string name, bool isReadyToBuy, List<Person> friends, int money, int ticketPrice = 0, string ticket = null)
        {
            this.name = name;
            this.isReadyToBuy = isReadyToBuy;
            this.ticket = ticket;
            this.friends = friends;
            this.money = money;
            this.ticketPrice = ticketPrice;
        }

        public void AddFriend(Person friend)
        {
            if (friends.Contains(friend)) return;
            friends.Add(friend);
            friend.friends.Add(this);
        }

        public List<Person> GetAllFriends()
        {
            return friends;
        }
        public void SellTicket()
        {
            BFS bfs = new BFS(this);
            while (bfs.MoveNext())
            {
                Person friend = bfs.Current();
                if (friend.isReadyToBuy == true)
                {
                    Console.WriteLine($"Hallelujah you sold the ticket, your money saved you sold ticket to {friend.name}");
                    money += ticketPrice;
                    friend.ticket = ticket;
                    friend.money -= ticketPrice;
                    break;
                }
            }
        }
    }
}
