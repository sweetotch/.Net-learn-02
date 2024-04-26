using Microsoft.AspNetCore.Mvc;
using MO_WebApp_01.Data.Interfaces;
using MO_WebApp_01.Data.Models;
using MO_WebApp_01.View_Models;
//using System.Web.Mvc;

namespace MO_WebApp_01.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly ICars _carsRep;
        private readonly ShopCart _shopCart;

        public ShopCartController (ICars carsRep, ShopCart shopCart)
        {
            _carsRep = carsRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj); //html страница
        }

        //БУдет переадресовывать на другую страницу
        public RedirectToActionResult addToCart (int id) 
        {
            var item = _carsRep.Cars.FirstOrDefault(i => i.id == id);

            if (item != null)
            {
                _shopCart.AddToCart(item);
            }

            //Если пользователь добавляет товар в корз. то мы переадресуем его на страницу Index
            return RedirectToAction("Index");

        }
    }
}
