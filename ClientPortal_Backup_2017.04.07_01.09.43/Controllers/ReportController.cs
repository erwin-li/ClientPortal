using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientPortal.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InboundReceiving()
        {
            return View();
        }

        public ActionResult Inventory()
        {
            return View();
        }

        public ActionResult InventoryAnalysis()
        {
            return View();
        }

        public ActionResult OutboundShipping()
        {
            return View();
        }
       
    }
}