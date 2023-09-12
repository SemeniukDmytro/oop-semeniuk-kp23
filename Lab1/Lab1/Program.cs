// See https://aka.ms/new-console-template for more information
using Lab2;

public class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("saymon", "1234567", 5, 09727, true, new List<string>() { "attack", "protect"}, "Sally");
        Cat cat = new Cat("george", "7654321", 7, 99969, new List<string>() { "back", "chin" });
        PetsDataBase dataBase = new PetsDataBase();
        dataBase.AddToDatabase(cat);
        dataBase.AddToDatabase(dog);
        foreach(var pet in dataBase.Data)
        {
            pet.GetAllInfo();
        }
        dog.Play();
        dog.Play();

    }
}


