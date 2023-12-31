﻿using Lab2;

public class Program 
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("saymon", "1234567", 5, 09727, true, new List<string>() { "attack", "protect" }, "Sally");
        Cat cat = new Cat("george", "7654321", 7, 99969, new List<string>() { "back", "chin" });
        PetsDataBase dataBase = new PetsDataBase();
        dataBase.AddToDatabase(cat);
        dataBase.AddToDatabase(dog);
        foreach (IHomeProtector pet in dataBase.Data)
        {
            pet.GetAllInfo();
            pet.ProtectHost();
        }
        dataBase.Data.ForEach(pet => pet.GetAllInfo());
        PetOwner steve = new PetOwner("Steve", "1234567", 09727, "Peremohy Ave 10");

        dog.PetGetLost += steve.OnPetGetLost;
        dog.CallOwner();
        dog.YellOnPet();

    }
}

