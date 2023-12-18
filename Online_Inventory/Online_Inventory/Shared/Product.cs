﻿using System;
namespace Online_Inventory.Pages
{
	public class Product
	{
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string CountryOfOrigin { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Notes { get; set; }
    }
}

