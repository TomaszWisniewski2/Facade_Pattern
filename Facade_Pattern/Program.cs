﻿using System;

namespace Facade_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalFacade facade = new AnimalFacade();

            facade.CreateCompleteAnimal();
            Console.ReadKey();

        }
    }
}
