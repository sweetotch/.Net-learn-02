namespace MO_WebApp_01.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MO_WebApp_01.Data.Interfaces;
    using MO_WebApp_01.View_Models;
    using System;  public class CarsController : Controller
    {
        private readonly ICars          _cars;
        private readonly ICarsCategory  _allCategories;

        public CarsController(ICars iCars, ICarsCategory iCarsCategories)
        {
            _cars           = iCars; 
            _allCategories  = iCarsCategories;
        }

        //возвращает целую html страницу
        public ViewResult List()
        {
            ViewBag.Title = "Страница с авто VB";
            CarsListViewModel obj = new CarsListViewModel();

            obj.allCars = _cars.Cars;
            obj.currCategory = "Автомобили";

            return View(obj); //html страница

        }

    }

}
