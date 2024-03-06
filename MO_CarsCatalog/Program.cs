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
            Car bmw_e34 = new Car();

            bmw_e34.setWheelDrive(2);
            bmw_e34.setTopSpeed(230);
            bmw_e34.setMark("BMW");
            bmw_e34.setModel("e34");


            Car mercedes_w140 = new Car(2, 200, "Mercedes-Benz", "w140");

            bmw_e34.displayCarInfo();
            mercedes_w140.displayCarInfo();

            Console.ReadKey();
        }

    }
}
