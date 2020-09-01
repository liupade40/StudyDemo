using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var sql= DependencyResolver.Current.GetService<IDataSource>();
            ViewBag.Message = sql.GetData();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public int code(string rand)
        {
            Random random = new Random();
            int r= random.Next(0, 9999);
            Session["code"] = r.ToString();
            return r;
        }
    }
}