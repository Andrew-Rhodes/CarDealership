using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;
using Models;

namespace CarDealershipProject.Controllers
{
    public class BuyController : Controller
    {

        public ActionResult GetAll()
        {
            var repo = Factory.CreateVehicleRepository();
            var AllCars = repo.GetAll();
            return View(AllCars);
        }

        
    }
}