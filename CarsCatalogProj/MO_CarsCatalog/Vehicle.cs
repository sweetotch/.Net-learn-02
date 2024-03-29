namespace MO_CarsCatalog
{
    class Vehicle
    {
        private int                 topSpeed;
        private string              name;
        protected EngineProperties  engine;

        public Vehicle()
        {
            name = "";
            topSpeed = 0;
            engine = new EngineProperties();
        }

        public Vehicle (string name = "", int topSpeed = 0, EngineProperties engine = new EngineProperties())
        {
            this.name       = name; 
            this.topSpeed   = topSpeed;
            this.engine     = engine;
        }

        public void setEngine(float capacity, int cilinders, int horsePowers, EngineType engineType, EngineFuelType engineFuelType)
        {
            engine.capacity        = capacity;
            engine.cilinders       = cilinders;
            engine.horsePowers     = horsePowers;
            engine.engineType      = engineType;
            engine.engineFuelType  = engineFuelType;
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public int TopSpeed
        {
            set { topSpeed = value; }
            get { return topSpeed; }
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

                Console.Write("\nEngine: ");
                
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
                }

                Console.Write($"{engineFuelType} {engineTypeStr}{cilinders} {capacity} liter {horsePowers}hp\n");
            }

        }
    }
}
