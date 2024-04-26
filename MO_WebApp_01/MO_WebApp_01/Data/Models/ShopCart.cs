using Microsoft.EntityFrameworkCore.SqlServer;
using System.Data.Entity;

namespace MO_WebApp_01.Data.Models
{
    public class ShopCart
    {
        public readonly AppDBContent appDBContent;

        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public string shopCartID { get; set; }
        public List<ShopCartItem> listShopItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { shopCartID = shopCartId };

        }

        public void AddToCart(Car car)
        {
            this.appDBContent.ShopCartItem.Add(new ShopCartItem
            {
                shopCartId = shopCartID,
                car = car,
                price = car.price

            });

            appDBContent.SaveChanges();
        }

        public List<ShopCartItem> getShopItems ()
        {
            return appDBContent.ShopCartItem.Where(c => c.shopCartId == shopCartID).Include(s => s.car).ToList();
        }

    }
}
