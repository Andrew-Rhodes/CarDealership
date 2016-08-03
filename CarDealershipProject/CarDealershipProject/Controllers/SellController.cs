using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;

namespace CarDealershipProject.Controllers
{
    public class SellController : Controller
    {
        // GET: Sell
        public ActionResult SellHome()
        {
            var repo = Factory.CreateVehicleRepository();
            var Selling = repo.GetSale();
            return View(Selling);
        }
    }
}