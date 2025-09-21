using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using MyShop.Models;

namespace MyShop.Controllers;

public class ItemController : Controller
{
    public IActionResult Table()
    {
        var items = GetItems();
        ViewBag.CurrentViewName = "Table";
        return View(items);
    }

    public IActionResult Grid()
    {
        var items = GetItems();
        ViewBag.CurrentViewName = "Grid";
        return View(items);
    }

    public List<Item> GetItems()
    {
        var items = new List<Item>();
        var item1 = new Item
        {
            ItemId = 1,
            Name = "Pizza",
            Price = 150,
            Description = "Delicious Italian dish pizza etc etc etc",
            ImageUrl = "/images/pizza.jpg"
        };
        var item2 = new Item
        {
            ItemId = 2,
            Name = "Fried, chicken leg",
            Price = 200,
            Description = "Delicious chicken leg fried",
            ImageUrl = "/images/chickenleg.jpg"
        };
        var item3 = new Item
        {
            ItemId = 3,
            Name = "French fries",
            Price = 50,
            Description = "nice fries",
            ImageUrl = "/images/frenchfries.jpg"
        };
        var item4 = new Item
        {
            ItemId = 4,
            Name = "Grilled ribs",
            Price = 250,
            Description = "delicious ribs",
            ImageUrl = "/images/ribs.jpg"

         };
        var item5 = new Item {
            ItemId = 5,
            Name = "Tacos",
            Price = 50,
            Description = "Delicious Tacos",
            ImageUrl = "/images/tacos.jpg"
        };
        var item6 = new Item {
            ItemId = 6 ,
            Name = "Fish and Chips",
            Price = 180,
            Description = "classic fish and chips from britain",
            ImageUrl = "/images/fishandchips.jpg"
        };
        var item7 = new Item {
             ItemId = 7,
            Name = "Cider",
            Price = 25,
            Description = "Delicious cider",
            ImageUrl = "/images/cider.jpg"
        };
        var item8 = new Item {
            ItemId = 8,
            Name = "Coke",
            Price = 50,
            Description = "Classic coke",
            ImageUrl = "/images/coke.jpg"
        };

        items.Add(item1);
        items.Add(item2);
        items.Add(item3);
        items.Add(item4);
        items.Add(item5);
        items.Add(item6);
        items.Add(item7);
        items.Add(item8);
        return items;
    }
}