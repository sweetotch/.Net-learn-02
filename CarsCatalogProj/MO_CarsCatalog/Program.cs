namespace MO_CarsCatalog
{
    class Program
    {
        private const string switchDefault = "Selected option is not on the list !";

        private LegalEntity     currentEntity;
        internal List<Car> cars = new();

        static void Main(string[] args)
        {
            Program carsCatalog = new();

            carsCatalog.initCars();
            carsCatalog.selectLegalEntity();
            carsCatalog.menu();

            Console.ReadKey();
        }

        /// <summary>
        /// Initializes(Hardcodes) 3 cars in catalog
        /// </summary>
        public void initCars()
        {
            //TODO: Reimplement using Files functionality
            Car car = new();

            car.ParmLegalEntity = LegalEntity.Cahul;
            car.DriveWheels = DriveWheels.rearWheelDrive;
            car.TopSpeed = 230;
            car.Name = "BMW    ";
            car.Model = "   e34";
            car.setEngine(2.2f, 6, 180, EngineType.Inline, EngineFuelType.Gasoline);

            cars.Add(car);
            car = new();

            car.ParmLegalEntity = LegalEntity.Cantemir;
            car.DriveWheels = DriveWheels.rearWheelDrive;
            car.Name = " Mercedes-Benz";
            car.Model = "w124 ";
            car.TopSpeed = 210;
            car.setEngine(2.0f, 4, 150, EngineType.Inline, EngineFuelType.Diesel);

            cars.Add(car);
            car = new();

            car.ParmLegalEntity = LegalEntity.Cahul;
            car.DriveWheels = DriveWheels.allWheelDrive;
            car.TopSpeed = 190;
            car.Name = "Subaru";
            car.Model = "Forester";
            car.setEngine(1.8f, 4, 150, EngineType.Opposite, EngineFuelType.Gasoline);

            cars.Add(car);
            car = new();
        }

        public void menu()
        {
            string readOperation;

            Console.Clear();
            Console.WriteLine($"Main menu [{this.CurrentEntity}]");
            Console.WriteLine("Choose the operation below");
            Console.WriteLine("1 — Display available cars in stock");
            Console.WriteLine("2 — Display all cars");
            Console.WriteLine("0 — [EXIT]");

            readOperation = Console.ReadLine();

            switch (readOperation.Trim())
            {
                case "1":
                    this.displayCars();
                    break;

                case "2":
                    this.displayCars(true);
                    break;

                case "0":
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine(switchDefault);
                    break;
            }

            Console.WriteLine("\nSelect the next operation:");
            Console.WriteLine("1 — Go back to the main menu");
            Console.WriteLine("2 — Change current legal entity");
            Console.WriteLine("0 — [EXIT]");

            readOperation = Console.ReadLine();

            switch (readOperation.Trim())
            {
                case "1":
                    this.menu();
                    break;

                case "2":
                    this.selectLegalEntity();
                    this.menu();
                    break;

                case "0":

                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine(switchDefault);
                    break;
            }
        }

        public void selectLegalEntity()
        {
            string readOperation;

            Console.Clear();
            Console.WriteLine("Enter your current legal entity: ");

            Console.WriteLine("Welcome to store '123' ! \n Select legal entity:");
            Console.WriteLine("1 — Chisinau");
            Console.WriteLine("2 — Cahul");
            Console.WriteLine("3 — Cantemir");


            readOperation = Console.ReadLine();

            switch(readOperation.Trim())
            {
                case "1":
                    this.CurrentEntity = LegalEntity.Chisinau;
                    break;
                case "2":
                    this.CurrentEntity = LegalEntity.Cahul;
                    break;
                case "3":
                    this.CurrentEntity = LegalEntity.Cantemir;
                    break;
                default:
                    Console.WriteLine(switchDefault);
                    break;
            }
        }

        public void displayCars(bool _displayAllCars = false)
        {
            foreach (Car car in cars)
            {
                this.displayCar(car, _displayAllCars);
            }

        }

        public void displayCar(Car _car, bool _displayAllCars = false)
        {
            if (_displayAllCars)
            {
                _car.displayCarInfo();
            }
            else if (_car.ParmLegalEntity == this.CurrentEntity)
            {
                _car.displayCarInfo();
            }
        }

        public LegalEntity CurrentEntity
        {
            set { this.currentEntity = value; }
            get { return this.currentEntity; }
        }

    }
}
