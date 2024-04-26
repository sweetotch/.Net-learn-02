﻿using System.ComponentModel.DataAnnotations;

namespace MO_WebApp_01.Data.Models
{
    public class Car
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }
        public string longDesc { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }
        public bool isFavourite { get; set; }
        public bool available { get; set; }
        public int categoryId { get; set; }
        public virtual Category Category{ get; set; }

    }
}
