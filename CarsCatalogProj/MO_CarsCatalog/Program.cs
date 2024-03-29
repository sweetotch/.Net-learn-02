namespace MO_CarsCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 10;
            //Program.method1(i);
            //Program.method2(ref i);

            Car bmw_e34         = new ();
            Car mercedes_w124   = new ();
            Car subaru_Forester = new ();

            bmw_e34.setDriveWheels(DriveWheels.rearWheelDrive);
            bmw_e34.setTopSpeed(230);
            bmw_e34.setName("BMW");
            bmw_e34.setModel("e34");
            bmw_e34.setEngine(2.2f, 6, 180, EngineType.Inline, EngineFuelType.Gasoline);
            bmw_e34.displayCarInfo();
            
            mercedes_w124.setDriveWheels(DriveWheels.rearWheelDrive);
            mercedes_w124.setName("Mercedes-Benz");
            mercedes_w124.setTopSpeed(210);
            mercedes_w124.setEngine(2.0f, 4, 150, EngineType.Inline, EngineFuelType.Diesel);
            mercedes_w124.displayCarInfo();

            subaru_Forester.setDriveWheels(DriveWheels.allWheelDrive);
            subaru_Forester.setTopSpeed(190);
            subaru_Forester.setName("Subaru");
            subaru_Forester.setModel("Forester");
            subaru_Forester.setEngine(1.8f, 4, 150, EngineType.Opposite, EngineFuelType.Gasoline);
            subaru_Forester.displayCarInfo();

            Console.ReadKey();
        }

    }
}
