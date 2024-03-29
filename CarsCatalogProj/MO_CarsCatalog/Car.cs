namespace MO_CarsCatalog
{
    class Car : Vehicle
    {
        private DriveWheels driveWheels;
        private string      model;

        public Car ()
        {
            driveWheels = 0;
            model      = "";
        }

        public Car (DriveWheels driveWheels = 0, string model = "")
        {
            this.driveWheels    = driveWheels;
            this.model          = model;
        }

        public string FullName => $"{Name} {Model}";

        public string Model
        {
            set { model = value; }
            get {  return model; }
        }

        public DriveWheels DriveWheels
        {
            set { driveWheels = value; }
            get { return driveWheels; }
        }

        public void displayCarInfo()
        {
            Console.WriteLine($"\n==== {FullName} ====");
            engine.displayEngineProperties();
            Console.WriteLine($"Drive wheels: {driveWheels}");
            Console.WriteLine($"Top speed: {TopSpeed}");
        }

    }
}
