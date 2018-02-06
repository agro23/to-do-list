using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class ItemsController : Controller
    {

        // [HttpGet("/items")]
        // public ActionResult Index()
        // {
        //     Item newItem = new Item(Request.Query["new-item"]);
        //     return View(newItem);
        // }
        //
        // [HttpGet("/items/new")]
        // public ActionResult CreateForm()
        // {
        //     return View();
        // }

        // [HttpGet("/items")]
        // public ActionResult Index()
        // {
        //     return View();
        // }

        // [HttpGet("/items")]
        [HttpGet("/Items")]
        // [HttpGet("/")]

        public ActionResult Index()
        {
            List<Item> allItems = Item.GetAll();
            return View(allItems);
        }

        // [HttpGet("/items/new")]
        [HttpGet("/Items/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/Items")]
        public ActionResult Create()
        {
          Item newItem = new Item (Request.Form["new-item"]);
          newItem.Save();
          List<Item> allItems = Item.GetAll();
          return View("Index", allItems);
          // return View("Items", newItem);
        }

        // [HttpPost("/items/delete")]
        [HttpPost("/Items/delete")]
        public ActionResult DeleteAll()
        {
            Item.ClearAll();
            return View();
        }

    }
}
