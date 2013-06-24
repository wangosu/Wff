using mvcSimple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcSimple.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page is here.";
            string pass = ""; 
            using (var db = new UsersContext())
            {
                //pass = db.Membership.Where(s => s.UserId.Equals("abc2")).FirstOrDefault().Password.ToString();
                UserProfile profile = db.UserProfiles.Where<UserProfile>(s => s.UserId == 1).FirstOrDefault();
                pass = profile.UserName;

            }
            ViewBag.Message += pass; 
            return View();
        }
    }
}
