namespace MO_WebApp_01.Data.mocks
{
    using MO_WebApp_01.Data.Interfaces;
    using MO_WebApp_01.Data.Models;
    using System.Collections.Generic;

    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategory
        {
            get 
            {
                return new List<Category> 
                {
                    new Category { categoryName = "Electro cars", desc = "Modern vehicle type" },
                    new Category { categoryName = "Combustion cars", desc = "Classic combustion vehicle design" }
                };
            }
        }
    }
}
