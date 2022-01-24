using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XSDproject
{
    public class Animals
    {
        //Only positive integers
        public int Id { get; set; }
        public string Name { get; set; }
        //Max lenght 50
        public string Description { get; set; }
        //Only positive integers
        public int Age { get; set; }
        //Range 50 - 100
        public int Speed { get; set; }
        public string Type { get; set; }
    }
}
