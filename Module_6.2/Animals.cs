using System;

namespace Module_6_2
{
    public class Animals
    {
        //Fields
        #region Fields

        private string name;
        private string skinColor;
        private string typeOfAnimals;
        private bool isMammals;

        #endregion

        //Properties
        #region Properties

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string SkinColor
        {
            get { return skinColor; }
            set { skinColor = value; }
        }

        public string  TypeOfAnimals
        {
            get { return typeOfAnimals; }
            set { typeOfAnimals = value; }
        }

        public bool IsMammals
        {
            get
            {
                return Enum.IsDefined(typeof(AnimalTypes), typeOfAnimals);
            }
            set { isMammals = value; }
        }

        #endregion
        
        public void WhatDoesAnimalSay()
        {
            Console.WriteLine("Animal is talking");
        }

        public void SetAnimalSkinColor(string value)
        {
            skinColor = value;
        }

        public string GetAnimalSkinColor()
        {
            return skinColor;
        }
    }
}
