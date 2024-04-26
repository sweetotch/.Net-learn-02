using MO_WebApp_01.Data.Interfaces;
using MO_WebApp_01.Data.Models;
using System.Net.NetworkInformation;

namespace MO_WebApp_01.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)//IApplicationBuilder app)
        {

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla",
                        shortDesc = "electric",
                        longDesc = "is an electric car",
                        img = "/img/tesla_3.jpg",
                        price = 45000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Electro cars"]
                    },
                    new Car
                    {
                        name = "BMW",
                        shortDesc = "Fast",
                        longDesc = "Is an fast car",
                        img = "/img/bmw_e34.jpg",
                        price = 55000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Combustion cars"]
                    },
                    new Car
                    {
                        name = "Mercedes",
                        shortDesc = "Comfortable",
                        longDesc = "Is an comfortable car",
                        img = "/img/mercedes_w124.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Combustion cars"]
                    }
                );
            }

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories 
        { 
            get {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Electro cars", desc = "Modern vehicle type" },
                        new Category { categoryName = "Combustion cars", desc = "Classic combustion vehicle design" }
                    };

                    category = new Dictionary<string, Category>();
                    
                    foreach(Category c in list)
                    {
                        category.Add(c.categoryName, c);
                    }
                }

                return category;
            }
        }
    }
}
