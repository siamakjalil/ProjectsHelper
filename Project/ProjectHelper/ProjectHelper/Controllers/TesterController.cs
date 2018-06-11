using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Helper;


namespace ProjectHelper.Controllers
{
    public class TesterController : Controller
    {
        // GET: Tester
        public ActionResult Index()
        {
            string str = "1397/02/20 10:15:43";
            var test = str.ToMiladiDateTime();
            return View();
        }
    }
}