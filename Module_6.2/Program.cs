using System;

namespace Module_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new Animals()
            {
                Name = "Fox",
                TypeOfAnimals = AnimalTypes.Mammal.ToString()
            };

            var fox = new Fox
            {
                Name = "Foxy",
                SkinColor = "Orange",
                IsMammals = true,
                TypeOfAnimals = AnimalTypes.Mammal.ToString()
            };

            //fox.

            Console.WriteLine($"Is animal mammal: {animal.IsMammals} - yes Position {(int)AnimalTypes.Mammal}");
            Console.ReadLine();
        }
    }
}
