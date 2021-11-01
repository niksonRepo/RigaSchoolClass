using System;

namespace Module_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fox = new Animals()
            {
                Name = "Fox",
                TypeOfAnimals = AnimalTypes.Mammal.ToString()
            };

            Console.WriteLine($"Is animal mammal: {fox.IsMammals} - yes Position {(int)AnimalTypes.Mammal}");
            Console.ReadLine();
        }
    }
}
