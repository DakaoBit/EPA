using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EPA.Areas.Air.Controllers
{
    public class HomeController : Controller
    {
        // GET: Air/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}