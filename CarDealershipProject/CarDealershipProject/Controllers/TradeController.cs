using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;

namespace CarDealershipProject.Controllers
{
    public class TradeController : Controller
    {
        // GET: Trade
        public ActionResult Index()
        {
            var repo = Factory.CreateVehicleRepository();
            var trades = repo.GetTrades();
            return View(trades);
        }
    }
}