namespace MO_WebApp_01.View_Models
{
    using MO_WebApp_01.Data.Models;

    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }

        public string currCategory { get; set; }
    }
}
