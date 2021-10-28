using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly_2
{
    public class Pill
    {
        public Pill()
        {

        }

        string stringVariable = "";

        bool isTruOrFalse;

        public string FishOil { get; set; }

        public int PillIngridientsCount { get; set; }

        public string Poweder { get; set; }
        
        public void HealHuman()
        {
            string fishOilSecondProperty = FishOil;

            FishOil = "MedicineFishoil";
        }

        public void GetUsHealty()
        {

        }
    }
}
