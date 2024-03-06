namespace MO_CarsCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Car
    {
        private int     wheelDrive;
        private int     topSpeed;
        private string  mark;
        private string  model;

        public Car ()
        {
            this.wheelDrive = 0;
            this.topSpeed   = 0;
            this.mark       = "";
            this.model      = "";
        }

        public Car (int wheelDrive = 0, int topSpeed = 0, string mark = "", string model = "")
        {
            this.wheelDrive = wheelDrive;
            this.topSpeed   = topSpeed;
            this.mark       = mark;
            this.model      = model;
        }

        public void setWheelDrive (int wheelDrive = 0)
        {
            this.wheelDrive = wheelDrive;
        }
        public void setTopSpeed (int topSpeed = 0)
        {
            this.topSpeed = topSpeed;
        }
        public void setMark (string mark = "")
        {
            this.mark = mark;
        }
        public void setModel (string model = "")
        {
            this.model = model;
        }

        public int getWheelDrive()
        {
            return this.wheelDrive;
        }
        public int getTopSpeed()
        {
            return this.topSpeed;
        }
        public string getMark()
        {
            return this.mark;
        }
        public string getModel()
        {
            return this.model;
        }

        public void displayCarInfo()
        {
            Console.WriteLine($"\n==== {this.mark} ====");
            Console.WriteLine($"Model: {this.model}");
            Console.WriteLine($"Drive wheels: {this.wheelDrive}");
            Console.WriteLine($"Top speed: {this.topSpeed}");
        }

    }
}
