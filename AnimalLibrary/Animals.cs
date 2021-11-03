using System;

namespace AnimalLibrary
{
    public class Animals :BaseAnimal, IAnimal, IAnimalBody
    {
        public virtual void WhatDoesAnimalSay()
        {
            Console.WriteLine("Animal is talking");
        }
        
        public void WhatDoesAnimalDo()
        {
            Console.WriteLine("Jump jump");
        }

        public void SetAnimalSkinColor(string value)
        {
            //SkinColor = value;
        }

        public string GetAnimalSkinColor()
        {
            return "SkinColor";
        }

    }
}
