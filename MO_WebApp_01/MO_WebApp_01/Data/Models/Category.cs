﻿namespace MO_WebApp_01.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public string desc { get; set; }

        public List<Car> Cars{ get; set; }
    }
}
