// See https://aka.ms/new-console-template for more information
using Lab1;

public class Program
{
    private const int maxGarbage = 100;
    static void Main(string[] args)
    {

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
    static void MakeSomeGarbage()
    {
        HomePet tolya;
        for (int i = 0; i < maxGarbage; i++)
        {
            tolya = new HomePet("tolya", "1234567", 16, 229299);
            Thread.Sleep(1);
        }
    }
}


