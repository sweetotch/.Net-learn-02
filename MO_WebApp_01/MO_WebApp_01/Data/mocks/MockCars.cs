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
                        img = "https://gas-kvas.com/grafic/uploads/posts/2023-10/1696455850_gas-kvas-com-p-kartinki-mashina-tesla-2.jpg", 
                        price = 45000, 
                        isFavourite = false,
                        available = true, 
                        Category = _carsCategory.AllCategory.First()},
                    new Car {
                        name = "BMW",
                        shortDesc = "Fast",
                        longDesc = "Is an fast car",
                        img = "https://content.onliner.by/news/original_size/24664d1e3b351b93631773a7f8ff2431.jpeg",
                        price = 55000,
                        isFavourite = false,
                        available = true,
                        Category = _carsCategory.AllCategory.Last()},
                    new Car {
                        name = "Mercedes",
                        shortDesc = "Comfortable",
                        longDesc = "Is an comfortable car",
                        img = "https://carsweek.ru/upload/iblock/dd9/dd97e5258884defd2745ad8a8747051c.jpg",
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
