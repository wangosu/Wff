using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc3.Controllers
{
    public class ApplicationInfoController : Controller
    {
        //
        // GET: /System/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GeneralHelp()
        {
            string helpEmail = System.Configuration.ConfigurationManager.AppSettings["helpEmail"].ToString();
            return View();
        }

    }
}
