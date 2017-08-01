using Microsoft.AspNetCore.Mvc;
using CarDealer.Models;
using System.Collections.Generic;
using System;

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
            if ((Request.Form["mileage"]).ToString().Length > 0 && (Request.Form["price"]).ToString().Length > 0)
            {
                myCar.SetMileage(int.Parse(Request.Form["mileage"]));
                myCar.SetPrice(float.Parse(Request.Form["price"]));
            }
            else
            {
                //throw error
            }
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
