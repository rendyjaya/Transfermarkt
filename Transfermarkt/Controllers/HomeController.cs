using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Transfermarkt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Transfer Aktivität diese Season";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Aktuelle News";

            return View();
        }
    }
}