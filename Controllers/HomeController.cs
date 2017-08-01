using Microsoft.AspNetCore.Mvc;
using CarDealer.Models;
using System.Collections.Generic;

namespace CarDealer.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult GetIndex()
        {
            return View("Index");
        }

        [HttpPost("/")]
        public ActionResult Index()
        {
            Car myCar = new Car();
            myCar.SetMakeModel(Request.Form["make-model"]);
            myCar.SetMileage(int.Parse(Request.Form["mileage"]));
            myCar.SetPrice(float.Parse(Request.Form["price"]));
            myCar.Save();
            return View(Car.AllCars());
        }

        [HttpGet("/form")]
        public ActionResult Form()
        {
            return View();
        }
    }
}
