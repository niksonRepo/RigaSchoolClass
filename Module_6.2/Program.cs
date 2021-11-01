using System;
using AnimalLibrary;

namespace Module_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new Animals()
            {
                Name = "Fox",
                TypeOfAnimals = ""
            };

            var fox = new Fox()
            {
                Name = "Foxy",
                SkinColor = "Orange",
                IsMammals = true,
                TypeOfAnimals = ""
            };

            //fox.

            Console.WriteLine($"Is animal mammal: {animal.IsMammals} - yes Position ");
            Console.ReadLine();
        }
    }
}
