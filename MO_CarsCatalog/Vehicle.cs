namespace MO_CarsCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Vehicle
    {
        private int         topSpeed;
        private string      name;

        protected Vehicle.EngineProperties engine;

        public Vehicle()
        {
            this.name = "";
            this.topSpeed = 0;
            this.engine = new Vehicle.EngineProperties();
        }

        public Vehicle (string _name = "", int _topSpeed = 0)
        {
            this.name       = _name; 
            this.topSpeed   = _topSpeed;
            this.engine = new Vehicle.EngineProperties();
        }

        public void setName(string name = "")
        {
            this.name = name;
        }

        public void setTopSpeed(int topSpeed = 0)
        {
            this.topSpeed = topSpeed;
        }

        public void setEngine(float capacity, int cilinders, int horsePowers, EngineType engineType, EngineFuelType engineFuelType)
        {
            this.engine.capacity        = capacity;
            this.engine.cilinders       = cilinders;
            this.engine.horsePowers     = horsePowers;
            this.engine.engineType      = engineType;
            this.engine.engineFuelType  = engineFuelType;
        }

        public string getName()
        {
            return this.name;
        }

        public int getTopSpeed()
        {
            return this.topSpeed;
        }

        public enum EngineFuelType
        {
            Gasoline = 1,
            Diesel = 2,
            Electricity = 3
        }

        public enum EngineType
        {
            Inline = 1,
            V = 2,
            Opposite = 3
        }

        public enum DriveWheels
        {
            frontWheelDrive = 1,
            rearWheelDrive = 2,
            allWheelDrive = 3
        }

        public struct EngineProperties
        {
            public float           capacity;
            public int             cilinders;
            public int             horsePowers;
            public EngineType      engineType;
            public EngineFuelType  engineFuelType;


            public void displayEngineProperties()
            {
                string engineTypeStr;

                Console.WriteLine("Engine properties:");
                
                switch (engineType)
                {
                    case EngineType.Inline:
                        engineTypeStr = "L";
                        break;

                    case EngineType.V:
                        engineTypeStr = "V";
                        break;

                    case EngineType.Opposite:
                        engineTypeStr = "B";
                        break;
                    default: 
                        throw new Exception ("Engine type is not set correctly.");
                            break;
                }

                Console.WriteLine($"\t{engineFuelType} {engineTypeStr}{cilinders} {capacity} liter {horsePowers}hp");

            }

        }
    }
}
