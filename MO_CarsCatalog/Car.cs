namespace MO_CarsCatalog
{
    using MO_CarsCatalog.CustLibraries;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Car : Vehicle
    {
        private DriveWheels driveWheels;
        private string      model;

        public Car ()
        {
            this.driveWheels = 0;
            this.model      = "";
        }

        public Car (DriveWheels driveWheels = 0, string model = "")
        {
            this.driveWheels = driveWheels;
            this.model      = model;
        }

        public void setDriveWheels(DriveWheels driveWheels = 0)
        {
            this.driveWheels = driveWheels;
        }

        public void setModel (string model = "")
        {
            this.model = model;
        }

        public DriveWheels getDriveWheels()
        {
            return this.driveWheels;
        }

        public string getModel()
        {
            return this.model;
        }

        public void displayCarInfo()
        {
            Console.WriteLine($"\n==== {this.getName()} ====");
            Console.WriteLine($"Model: {this.model}");
            engine.displayEngineProperties();
            Console.WriteLine($"Drive wheels: {this.driveWheels}");
            Console.WriteLine($"Top speed: {this.getTopSpeed()}");
        }

    }
}
