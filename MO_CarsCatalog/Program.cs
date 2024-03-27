namespace MO_CarsCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            //int i = 10;
            //Program.method1(i);
            //Program.method2(ref i);

            Car bmw_e34         = new Car();
            Car mercedes_w124   = new Car();
            Car subaru_Forester = new Car();

            bmw_e34.setDriveWheels(Vehicle.DriveWheels.rearWheelDrive);
            bmw_e34.setTopSpeed(230);
            bmw_e34.setName("BMW");
            bmw_e34.setModel("e34");
            bmw_e34.setEngine(2.2f, 6, 180, Vehicle.EngineType.Inline, Vehicle.EngineFuelType.Gasoline);
            bmw_e34.displayCarInfo();
            
            mercedes_w124.setDriveWheels(Vehicle.DriveWheels.rearWheelDrive);
            mercedes_w124.setName("Mercedes-Benz");
            mercedes_w124.setTopSpeed(210);
            mercedes_w124.setEngine(2.0f, 4, 150, Vehicle.EngineType.Inline, Vehicle.EngineFuelType.Diesel);
            mercedes_w124.displayCarInfo();

            subaru_Forester.setDriveWheels(Vehicle.DriveWheels.allWheelDrive);
            subaru_Forester.setTopSpeed(190);
            subaru_Forester.setName("Subaru");
            subaru_Forester.setModel("Forester");
            subaru_Forester.setEngine(1.8f, 4, 150, Vehicle.EngineType.Opposite, Vehicle.EngineFuelType.Gasoline);
            subaru_Forester.displayCarInfo();

            Console.ReadKey();
        }

    }
}
