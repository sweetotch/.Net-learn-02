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
        public  EngineType  engineType;

        public Vehicle()
        {
            this.name = "";
            this.topSpeed = 0;
        }

        public Vehicle (string _name = "", int _topSpeed = 0)
        {
            this.name       = _name; 
            this.topSpeed   = _topSpeed;
        }

        public void setName(string name = "")
        {
            this.name = name;
        }

        public void setTopSpeed(int topSpeed = 0)
        {
            this.topSpeed = topSpeed;
        }

        public string getName()
        {
            return this.name;
        }

        public int getTopSpeed()
        {
            return this.topSpeed;
        }

        public enum EngineType
        {
            Gasoline = 3,
            Diesel = 1,
            Electricity = 4
        }
    }
}
