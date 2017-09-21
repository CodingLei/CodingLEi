using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  CodingLei_Model.ExtendModel;
using System.Web;
using CodingLei_Common.Helper;
using CodingLei_Model.TableModel;

namespace CodingLei_Business.Business
{
    public class LoginBusiness
    {
        public ReturnInfoModel LoginSubmit(string username, string password)
        {
            var employeeModel = DBHelper.Context.From<Employee>().Where(d => d.Phone == username && d.LoginPassword == password).ToList();
            if (employeeModel == null || employeeModel.Count <= 0)
            {
                return ReturnInfo.Failure("用户名或密码不正确！");
            }

            HttpCookie userCookie = HttpContext.Current.Response.Cookies["LoginInfo"];
            if (userCookie != null)
            {
                HttpContext.Current.Response.Cookies.Remove("LoginInfo");
            }
            userCookie = new HttpCookie("LoginInfo");
            userCookie.Values["UserName"] = username;
            userCookie.Values["Password"] = password;
            userCookie.Expires = DateTime.Now.AddDays(1);
            HttpContext.Current.Response.Cookies.Add(userCookie);
            return ReturnInfo.Success();
        }
    }
}
