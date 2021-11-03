using System;
using AnimalLibrary;

namespace Module_6_2_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fox = new Fox()
            {
                //IsMammals = true
            };
            fox.WhatDoesAnimalSay();

            var animal = new Animals();
            animal.WhatDoesAnimalSay();

            Console.ReadLine();
        }
    }
}
