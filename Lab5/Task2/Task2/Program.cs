// See https://aka.ms/new-console-template for more information
using Task2;

Person person = new Person("Eddie", true,  new List<Person>() { }, 100);
Person person1 = new Person("Tommy", false, new List<Person>(), 100 );
Person person2 = new Person("Carteo", false, new List<Person>(), 100);
Person person3 = new Person("Dimas", false, new List<Person>(), 100 );
Person person4 = new Person("Glibas", false, new List<Person>(), 100);
Person person5 = new Person("Maryna", false, new List<Person>(), 100);
Person person6 = new Person("Sofia", true, new List<Person>(), 100);
Person you = new Person("Franklin", false, new List<Person>(), 100, 100, "asd");

person.AddFriend(person1);
person.AddFriend(person2);
person1.AddFriend(person6);
person6.AddFriend(person5);
person6.AddFriend(person4);
person1.AddFriend(person3);
you.AddFriend(person5);
you.SellTicket();
