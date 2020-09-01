using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        // GET: Login
        public ActionResult Index(string username,string password,string code)
        {
            if (code!=Session["code"].ToString())
            {
                ViewBag.tip = "验证码错误";
                return View();
            }
            if (username!="admin"||password!="123456")
            {
                ViewBag.tip = "用户名密码错误";
            }
            else
            {
                ViewBag.tip = "登录成功";
            }
            return View();
        }
    }
}