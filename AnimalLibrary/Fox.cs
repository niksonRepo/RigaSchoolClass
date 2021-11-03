using System;

namespace AnimalLibrary
{
    public class Fox : Animals
    {
        public override void WhatDoesAnimalSay()
        {
            Console.WriteLine("Fox say frrrrr");
        }
        
        public string WhatDoesFoxSay()
        {
            return "Fox say frrrrr";
        }

        public string WhatDoesFoxSay( string talk)
        {
            return talk;
        }
    }
}
