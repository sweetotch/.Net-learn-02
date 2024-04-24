using MO_WebApp_01.Data.Models;

namespace MO_WebApp_01.Data.Interfaces
{
    public interface ICars
    {
        IEnumerable<Car> Cars { get;}
        IEnumerable<Car> getFavCars { get; set; }
        Car getObjectCar(int _carId);
    }
}
