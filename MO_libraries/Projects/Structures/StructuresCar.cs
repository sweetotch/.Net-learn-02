global using EnumsCar;
using System;

namespace StructuresCar
{
    public struct EngineProperties
    {
        public float          capacity;
        public int            cilinders;
        public int            horsePowers;
        public EngineType     engineType;
        public EngineFuelType engineFuelType;

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
                    throw new Exception("Engine type is not set correctly.");
            }

            Console.Write($"{engineFuelType} {engineTypeStr}{cilinders} {capacity} liter {horsePowers}hp\n");
        }
    }
}
