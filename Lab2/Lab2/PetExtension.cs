﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public static class PetExtension
    {
        public static void  YellOnPet(this HomePet pet)
        {
            Console.WriteLine("pet is running away");
        }
    }
}
