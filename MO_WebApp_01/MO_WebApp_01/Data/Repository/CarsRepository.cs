using Microsoft.EntityFrameworkCore.SqlServer;
using MO_WebApp_01.Data.Interfaces;
using MO_WebApp_01.Data.Models;
using System.Data.Entity;

namespace MO_WebApp_01.Data.Repository
{
    public class CarsRepository : ICars
    {
        public readonly AppDBContent appDBContent;

        public CarsRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);

        public IEnumerable<Car> getFavCars => appDBContent.Car.Where(p => p.isFavourite).Include(c => c.Category);

        //IEnumerable<Car> ICars.getFavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car getObjectCar(int _carId) => appDBContent.Car.FirstOrDefault(p => p.id == _carId);
    }
}
