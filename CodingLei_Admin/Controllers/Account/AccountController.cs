using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodingLei_Business.Business;


namespace CodingLei_Admin.Controllers.Account
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult LoginSubmit()
        {
            string username = Request["UserName"];
            string password = Request["PassWord"];
            return Json(new LoginBusiness().LoginSubmit(username, password));
        }
    }
}