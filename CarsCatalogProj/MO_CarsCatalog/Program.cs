namespace MO_CarsCatalog
{
    class Program
    {
        private const string switchDefault = "Selected option is not on the list !";

        private LegalEntity  currentEntity;
        Car             bmw_e34 = new();
        Car             mercedes_w124 = new();
        Car             subaru_Forester = new();

        static void Main(string[] args)
        {
            Program carsCatalog = new();

            carsCatalog.initCars();
            carsCatalog.selectLegalEntity();
            carsCatalog.menu();

            Console.ReadKey();
        }

        public void initCars()
        {
            bmw_e34.ParmLegalEntity = LegalEntity.Cahul;
            bmw_e34.DriveWheels = DriveWheels.rearWheelDrive;
            bmw_e34.TopSpeed = 230;
            bmw_e34.Name = "BMW    ";
            bmw_e34.Model = "   e34";
            bmw_e34.setEngine(2.2f, 6, 180, EngineType.Inline, EngineFuelType.Gasoline);

            mercedes_w124.ParmLegalEntity = LegalEntity.Cantemir;
            mercedes_w124.DriveWheels = DriveWheels.rearWheelDrive;
            mercedes_w124.Name = " Mercedes-Benz";
            mercedes_w124.Model = "w124 ";
            mercedes_w124.TopSpeed = 210;
            mercedes_w124.setEngine(2.0f, 4, 150, EngineType.Inline, EngineFuelType.Diesel);

            subaru_Forester.ParmLegalEntity = LegalEntity.Cahul;
            subaru_Forester.DriveWheels = DriveWheels.allWheelDrive;
            subaru_Forester.TopSpeed = 190;
            subaru_Forester.Name = "Subaru";
            subaru_Forester.Model = "Forester";
            subaru_Forester.setEngine(1.8f, 4, 150, EngineType.Opposite, EngineFuelType.Gasoline);
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
            this.displayCar(bmw_e34, _displayAllCars);
            this.displayCar(mercedes_w124, _displayAllCars);
            this.displayCar(subaru_Forester, _displayAllCars);

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
