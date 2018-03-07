using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebHelpers.Controllers
{
    public class WebHelpersController : Controller
    {
        // GET: WebHelpers
        public ActionResult ChartTekVeri()
        {
            return View();
        }

        public ActionResult ChartIkiVeri()
        {
            return View();
        }

        public ActionResult PieChart()
        {
            return View();
        }
        public ActionResult WebMailGonder()
        {
            return View();
        }
    }
}