using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using CodingLei_Model.SearchModel;
using CodingLei_Model.TableModel;

namespace CodingLei_Admin.Controllers.Account
{
 
    public class UserInfoController : Controller
    {
        public static string path = System.Web.HttpContext.Current.Server.MapPath("/Models/") + "data5.xml";

        // GET: UserInfo
        public ActionResult UserInfoIndex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetUserInfoList(DemoSearchModel search, int id = 0)
        {
            IList<UserInfoModel> modelList = new List<UserInfoModel>();

            XElement doc = XElement.Load(path);
            var a = doc.Descendants("User");
            modelList =
                    doc.Descendants("User")
                       .Select(
                           x =>
                           new UserInfoModel
                           {
                               UserId = Convert.ToInt32(x.Attribute("UserId").Value),
                               UserName = x.Element("UserName").Value.ToString(),
                               Tell = x.Element("Tell").Value.ToString(),
                               Enabled = Convert.ToBoolean(x.Element("Enabled").Value)
                           })
                       .ToList();
            return PartialView("UserInfoResultView", modelList);
        }

        public ActionResult SaveUserInfo()
        {
            string username = Request["UserId"];
            string password = Request["UserName"];

            return null;
        }
    }
}