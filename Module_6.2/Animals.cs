﻿using System;

namespace Module_6_2
{
    public class Animals: BaseAnimal
    {
        public void WhatDoesAnimalSay()
        {
            Console.WriteLine("Animal is talking");
        }

        public void SetAnimalSkinColor(string value)
        {
            SkinColor = value;
        }

        public string GetAnimalSkinColor()
        {
            return SkinColor;
        }
    }
}
