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

            Car bmw_e34 = new Car();

            bmw_e34.setWheelDrive(2);
            bmw_e34.setTopSpeed(230);
            bmw_e34.setName("BMW");
            bmw_e34.setModel("e34");
            bmw_e34.engineType = Vehicle.EngineType.Gasoline;

            bmw_e34.displayCarInfo();


            Car mercedes_w124 = new Car (2);
            mercedes_w124.setName("Mercedes-Benz");
            mercedes_w124.setTopSpeed(210);
            mercedes_w124.engineType = Vehicle.EngineType.Diesel + 2;
            mercedes_w124.displayCarInfo();

            if (bmw_e34.engineType > mercedes_w124.engineType)
            {
                Console.WriteLine("\n\nbmw engine type is bigger");
            }
            else
            {
                Console.WriteLine("mercedes engine type is bigger");
            }

            //Program.method3(ref bmw_e34);
            //bmw_e34.displayCarInfo();

            Console.ReadKey();
        }

        public static void method1(int _i)
        {
            _i += 10;
        }

        public static void method2(ref int _i)
        {
            _i += 10;
        }

        public static void method3(ref Car _car)
        {
            _car.setName("Redacted");
        }
    }
}
