namespace MO_CarsCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Car : Vehicle
    {
        private int     wheelDrive;
        private string  model;

        public Car ()
        {
            this.wheelDrive = 0;
            this.model      = "";
        }

        public Car (int wheelDrive = 0, string model = "")
        {
            this.wheelDrive = wheelDrive;
            this.model      = model;
        }

        public void setWheelDrive (int wheelDrive = 0)
        {
            this.wheelDrive = wheelDrive;
        }

        public void setModel (string model = "")
        {
            this.model = model;
        }

        public int getWheelDrive()
        {
            return this.wheelDrive;
        }

        public string getModel()
        {
            return this.model;
        }

        public void displayCarInfo()
        {
            Console.WriteLine($"\n==== {this.getName()} ====");
            Console.WriteLine($"Model: {this.model}");
            Console.WriteLine($"Engine type: {this.engineType}");
            Console.WriteLine($"Drive wheels: {this.wheelDrive}");
            Console.WriteLine($"Top speed: {this.getTopSpeed()}");
        }

    }
}
