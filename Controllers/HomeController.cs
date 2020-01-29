using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUD.Models;

namespace CRUD.Controllers
{
    public class HomeController : Controller
    {
        private HomeContext dbContext;
        public HomeController( HomeContext context)
        {
            dbContext = context;
        } 




        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.Dishes = dbContext.Dishes.ToList();
            return View("Index");
        } //displays the home page






        [HttpGet("add")]
        public IActionResult AddDish()
        {
            return View("AddDish");
        }//displays the form to create a new dish






        [HttpPost("create")]
        public IActionResult CreateDish(Dish addDish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Dishes.Add(addDish);
                dbContext.SaveChanges();
                return RedirectToAction("Index", addDish);
            }
            else
            {
                return View("AddDish", addDish);
            }
        } //add a new dish to our database




        [HttpGet("{dishId}")]
        public IActionResult SingleDish(int dishId)
        {
            Dish SingleDish = dbContext.Dishes.FirstOrDefault( d => d.DishId == dishId);
            ViewBag.singleDish = SingleDish;
            return View("SingleDish", SingleDish);
        }


        [HttpGet("delete/{dishId}")]
        public IActionResult DeleteDish(int dishId)
        {
            Dish removeDish = dbContext.Dishes.FirstOrDefault( d => d.DishId == dishId);
            dbContext.Dishes.Remove(removeDish);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet("edit/{dishId}")]
        public IActionResult EditDish(int dishId)
        {
            Dish retriveDish = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);
            ViewBag.SingleDish = retriveDish;
            return View("EditDish");
        }
        


        [HttpPost("edit/{dishId}")]
        public IActionResult edit(Dish editedDish, int dishId)
        {
            Dish oldDish = dbContext.Dishes.FirstOrDefault( d => d.DishId == dishId);
            ViewBag.singleDish = oldDish;

            if(ModelState.IsValid)
            {
                oldDish.Name = editedDish.Name;
                oldDish.Chef = editedDish.Chef;
                oldDish.Calories = editedDish.Calories;
                oldDish.Tastiness = editedDish.Tastiness;
                oldDish.Description = editedDish.Description;
                oldDish.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("EditDish");
            }
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
