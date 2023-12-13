﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product.Models;

namespace Product.Services
{
    public class MobileService
    {
        private readonly static IEnumerable<Item> _mobile = new
            List<Item>()
        {
            new Item
            {
                Name = "Iphone 14",
                Image = "ph1.jpg",
                Price = 499.9

            },
            new Item
            {
                Name = "Iphone 14 Mini",
                Image = "ph10.png",
                Price = 399.9

            },
            new Item
            {
                Name = "Iphone 14 pro Max",
                Image = "ph2.jpg",
                Price = 999.9

            },
            new Item
            {
                Name = "Iphone 15",
                Image = "ph3.jpg",
                Price = 699.9

            },
            new Item
            {
                Name = "Iphone 15 Mini",
                Image = "ph4.jpg",
                Price = 599.9

            },
            new Item
            {
                Name = "Iphone 15 Pro Max",
                Image = "ph5.jpg",
                Price = 1599.9

            },
            new Item
            {
                Name = "S21 FE",
                Image = "ph6.png",
                Price = 549.9

            },
            new Item
            {
                Name = "S21 Ultra",
                Image = "ph7.jpg",
                Price = 959.9

            },
            new Item
            {
                Name = "S22 FE",
                Image = "ph8.png",
                Price = 749.9

            },
            new Item
            {
                Name = "S22 Ultra",
                Image = "ph9.jpg",
                Price = 1549.9

            },
            new Item
            {
                Name = "Pixel 8",
                Image = "ph11.jpg",
                Price = 2599.9

            },
            new Item
            {
                Name = "Haier Refrigerator",
                Image = "fdg1.jpg",
                Price = 599.9

            },
            new Item
            {
                Name = "L.G Refrigerator",
                Image = "fdg2.jpg",
                Price = 699.9

            },
            new Item
            {
                Name = "Panasonic Refrigerator",
                Image = "fdg3.jpg",
                Price = 799.9

            },
            new Item
            {
                Name = "Godrej Refrigerator",
                Image = "fdg4.jpg",
                Price = 899.9

            },
            new Item
            {
                Name = "BoSch Refrigerator",
                Image = "fdg5.png",
                Price = 999.9

            },
            new Item
            {
                Name = "Vintage Watches",
                Image = "w1.jpg",
                Price = 999.9

            },
            new Item
            {
                Name = "I Watches",
                Image = "w5.jpg",
                Price = 299.9

            },
            new Item
            {
                Name = "EverLass Watches",
                Image = "w2.jpg",
                Price = 499.9

            },
            new Item
            {
                Name = "Piguet Watches",
                Image = "w3.jpg",
                Price = 399.9

            },
            new Item
            {
                Name = "Cartier Watches",
                Image = "w4.jpg",
                Price = 899.9

            },
            new Item
            {
                Name = "Mac Laptop",
                Image = "l1.jpg",
                Price = 1899.9

            },
            new Item
            {
                Name = "Lenovo Laptop",
                Image = "l2.jpg",
                Price = 1199.9

            },
            new Item
            {
                Name = "Hp Laptop",
                Image = "l3.jpg",
                Price = 1399.9

            },
            new Item
            {
                Name = "Dell Laptop",
                Image = "l4.jpg",
                Price = 1099.9

            },
            new Item
            {
                Name = "Acer Laptop",
                Image = "l5.jpg",
                Price = 1599.9

            }


        };
        public IEnumerable<Item> GetallMobiles() => _mobile;
        public IEnumerable<Item> GetPopularMobiles(int count = 8) => _mobile.OrderBy(p => Guid.NewGuid())
           .Take(count);

        public IEnumerable<Item> SearchMobile(string searchTerm) =>
          string.IsNullOrWhiteSpace(searchTerm)
          ? _mobile
          : _mobile.Where(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));


    }
}
