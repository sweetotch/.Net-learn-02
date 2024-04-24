namespace MO_WebApp_01.Data.mocks
{
    using MO_WebApp_01.Data.Interfaces;
    using MO_WebApp_01.Data.Models;
    using System.Collections.Generic;

    public class MockCars : ICars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();

        public IEnumerable<Car> Cars 
        { 
            get
            {
                return new List<Car>
                {
                    new Car { 
                        name = "Tesla", 
                        shortDesc = "electric", 
                        longDesc = "is an electric car", 
                        img = "/img/tesla_3.jpg", 
                        price = 45000, 
                        isFavourite = false,
                        available = true, 
                        Category = _carsCategory.AllCategory.First()},
                    new Car {
                        name = "BMW",
                        shortDesc = "Fast",
                        longDesc = "Is an fast car",
                        img = "/img/bmw_e34.jpg",
                        price = 55000,
                        isFavourite = false,
                        available = true,
                        Category = _carsCategory.AllCategory.Last()},
                    new Car {
                        name = "Mercedes",
                        shortDesc = "Comfortable",
                        longDesc = "Is an comfortable car",
                        img = "/img/mercedes_w124.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _carsCategory.AllCategory.Last()}
                };
            }

            //set; 
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int _carId)
        {
            throw new NotImplementedException();
        }
    }
}
