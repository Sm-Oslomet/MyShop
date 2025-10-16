using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyShop.Models;
using MyShop.ViewModels;
using MyShop.DAL;

namespace MyShop.Controllers;

public class ItemController : Controller
{

    private readonly IItemRepository _itemRepository;

    public ItemController(IItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }
    public async Task<IActionResult> Table()
    {
        var items = await _itemRepository.GetAll();
        var itemsViewModel = new ItemsViewModel(items, "Table");
        return View(itemsViewModel);
    }

    public async Task<IActionResult> Grid()
    {
        var items = await _itemRepository.GetAll();
        var itemsViewModel = new ItemsViewModel(items, "Grid");
        return View(itemsViewModel);
    }

    public async Task<IActionResult> Details(int id)
    {
        var item = await _itemRepository.GetItemById(id);
        if (item == null)
            return BadRequest("Item not found. ");
        return View(item);
    }


    [HttpGet]
    public IActionResult Create() // sends user to a view for creating, when they go to the create page
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Item item) // post method for when user clicks on "create" so that the data is sent
    {
        if (ModelState.IsValid)
        {
            
            await _itemRepository.Create(item);
            return RedirectToAction(nameof(Table));
        }
        return View(item);
    }
    [HttpGet]
    public async Task<IActionResult> Update(int id)
    {
        var item = await _itemRepository.GetItemById(id);
        if (item == null)
        {
            return NotFound();
        }
        return View(item);
    }

    [HttpPost]
    public async Task<IActionResult> Update(Item item)
    {
        if (ModelState.IsValid)
        {
            await _itemRepository.Update(item);
            return RedirectToAction(nameof(Table));
        }
        return View(item);
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        var item = await _itemRepository.GetItemById(id);
        if (item == null)
        {
            return NotFound();
        }
        return View(item);
    }

    [HttpPost]
    public async Task <IActionResult> DeleteConfirmed(int id)
    {
        await _itemRepository.Delete(id);
        return RedirectToAction(nameof(Table));
    }
    // public List<Item> GetItems()
    // {
    //     var items = new List<Item>();
    //     var item1 = new Item
    //     {
    //         ItemId = 1,
    //         Name = "Pizza",
    //         Price = 150,
    //         Description = "Delicious Italian dish pizza etc etc etc",
    //         ImageUrl = "/images/pizza.jpg"
    //     };
    //     var item2 = new Item
    //     {
    //         ItemId = 2,
    //         Name = "Fried, chicken leg",
    //         Price = 200,
    //         Description = "Delicious chicken leg fried",
    //         ImageUrl = "/images/chickenleg.jpg"
    //     };
    //     var item3 = new Item
    //     {
    //         ItemId = 3,
    //         Name = "French fries",
    //         Price = 50,
    //         Description = "nice fries",
    //         ImageUrl = "/images/frenchfries.jpg"
    //     };
    //     var item4 = new Item
    //     {
    //         ItemId = 4,
    //         Name = "Grilled ribs",
    //         Price = 250,
    //         Description = "delicious ribs",
    //         ImageUrl = "/images/ribs.jpg"

    //     };
    //     var item5 = new Item
    //     {
    //         ItemId = 5,
    //         Name = "Tacos",
    //         Price = 50,
    //         Description = "Delicious Tacos",
    //         ImageUrl = "/images/tacos.jpg"
    //     };
    //     var item6 = new Item
    //     {
    //         ItemId = 6,
    //         Name = "Fish and Chips",
    //         Price = 180,
    //         Description = "classic fish and chips from britain",
    //         ImageUrl = "/images/fishandchips.jpg"
    //     };
    //     var item7 = new Item
    //     {
    //         ItemId = 7,
    //         Name = "Cider",
    //         Price = 25,
    //         Description = "Delicious cider",
    //         ImageUrl = "/images/cider.jpg"
    //     };
    //     var item8 = new Item
    //     {
    //         ItemId = 8,
    //         Name = "Coke",
    //         Price = 50,
    //         Description = "Classic coke",
    //         ImageUrl = "/images/coke.jpg"
    //     };

    //     items.Add(item1);
    //     items.Add(item2);
    //     items.Add(item3);
    //     items.Add(item4);
    //     items.Add(item5);
    //     items.Add(item6);
    //     items.Add(item7);
    //     items.Add(item8);
    //     return items;
    // }
}