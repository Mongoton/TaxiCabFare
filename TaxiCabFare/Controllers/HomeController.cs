using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaxiCabFare.Models;


namespace TaxiCabFare.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Index(TaxiFareModel rideinfo)
        {
            string result = "";
            try
            {
                int above6min = Int32.Parse(rideinfo.TaxiAbove6Min);
                int below6min = Int32.Parse(rideinfo.TaxiBelow6Min);
                DateTime taxidate = DateTime.Parse(rideinfo.RideDate);
            }
            catch (Exception e)
            {
                result = "Please enter valid values";
            }
            return Json(new { result });
        }
    }
}
