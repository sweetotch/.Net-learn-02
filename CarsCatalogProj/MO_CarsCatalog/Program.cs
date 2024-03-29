namespace MO_CarsCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw_e34         = new ();
            Car mercedes_w124   = new ();
            Car subaru_Forester = new ();

            bmw_e34.DriveWheels = DriveWheels.rearWheelDrive;
            bmw_e34.TopSpeed    = 230;
            bmw_e34.Name        = "BMW";
            bmw_e34.Model       = "e34";
            bmw_e34.setEngine(2.2f, 6, 180, EngineType.Inline, EngineFuelType.Gasoline);
            bmw_e34.displayCarInfo();
            
            mercedes_w124.DriveWheels   = DriveWheels.rearWheelDrive;
            mercedes_w124.Name          = "Mercedes-Benz";
            mercedes_w124.Model         = "w124";
            mercedes_w124.TopSpeed      = 210;
            mercedes_w124.setEngine(2.0f, 4, 150, EngineType.Inline, EngineFuelType.Diesel);
            mercedes_w124.displayCarInfo();

            subaru_Forester.DriveWheels = DriveWheels.allWheelDrive;
            subaru_Forester.TopSpeed    = 190;
            subaru_Forester.Name        = "Subaru";
            subaru_Forester.Model       = "Forester";
            subaru_Forester.setEngine(1.8f, 4, 150, EngineType.Opposite, EngineFuelType.Gasoline);
            subaru_Forester.displayCarInfo();

            Console.ReadKey();
        }
    }
}
