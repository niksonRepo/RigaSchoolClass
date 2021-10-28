using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly
{
    public class Car
    {
        private string Color; //by default is null
        private string Model; //by default is null

        public string color
        {
            get {return this.Color;}
            set {this.Color = value;}
        }

        public string model
        {
            get { return this.Model;}
            set { this.Model = value; }
        }

        public Car(string car)
        {
            this.Color = "green";
            Model = car == CarConstants.bmw
                ? CarConstants.bmw 
                : CarConstants.audi;
        }

        public Car()
        {
        }

        public void ChangeModelName(string model)
        {
            this.Model = model;
        }
    }
}
