using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TODOList.Controllers
{
    public class TODOListController : Controller
    {
        // GET: TODOList
        public ActionResult Index()
        {
            return View();
        }
    }
}