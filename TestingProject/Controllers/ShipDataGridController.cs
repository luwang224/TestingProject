using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestingProject.Controllers
{
    public class ShipDataGridController : Controller
    {
        // GET: ShipDataGrid
        public ActionResult ShipInformation()
        {
            return View();
        }
        public ActionResult About()
        {
            return View("~/Views/about.cshtml");
        }
    }
}