namespace MO_CarsCatalog
{
    class Vehicle
    {
        private int                 topSpeed;
        private string              name;
        private LegalEntity         legalEntity;
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

        public LegalEntity ParmLegalEntity
        {
            set { legalEntity = value; }
            get { return legalEntity; }
        }

    }
}
