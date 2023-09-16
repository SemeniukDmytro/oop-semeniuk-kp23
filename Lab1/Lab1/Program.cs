using Lab1;

public class Program
{
    static void Main(string[] args)
    {
        HomePet ashley = new HomePet("Ashley", "0001111", 12, 204999);
        Console.WriteLine(ashley.GetInfoAboutPet("0001111"));
        Cat bob = new Cat("Bonny", "1234567", 25, 1999, new List<string>() { "chin", "back" });
        bob.ShowPlacesToStroke();
        Console.WriteLine(bob.GetInfoAboutPet("1234567"));
        using (var pet = new HomePet("Fluffy", "1234567", 5, 1234567))
        {
            pet.GetInfoAboutPet(pet.QrCodeNumber);
        }
        MyGarbageCollector mgb = new MyGarbageCollector();
        mgb.ShowMemoryUsage();
    }
}