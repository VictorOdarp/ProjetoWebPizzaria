﻿using Microsoft.Identity.Client;

namespace DarpinosPizza.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(int id, string name, string category, double price)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
        }

        public void TotalProducts()
        {
            
        }
    }
}
