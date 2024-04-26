using System.ComponentModel.DataAnnotations;

namespace MO_WebApp_01.Data.Models
{
    public class ShopCartItem
    {
        [Key]
        public int itemId { get; set; } 
        public Car car { get; set; }
        public int price { get; set; }
        public string shopCartId {  get; set; }
    }
}
