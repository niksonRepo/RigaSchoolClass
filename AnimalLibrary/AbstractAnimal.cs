using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLibrary
{
    public abstract class AbstractAnimal
    {
        public abstract void RandomAnimalSound();

        public void Sleep()
        {
            Console.WriteLine("Zzzzz");
        }
    }
}
