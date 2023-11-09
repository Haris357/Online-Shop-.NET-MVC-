using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterDetailsDemo.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Location()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Links()
        {
            return View();
        }
    }
}