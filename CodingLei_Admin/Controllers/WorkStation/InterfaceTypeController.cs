using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodingLei_Business.Business;
using CodingLei_Model.SearchModel;

namespace CodingLei_Admin.Controllers.WorkStation
{
    public class InterfaceTypeController : Controller
    {
        // GET: InterfaceType
        public ActionResult InterfaceTypeIndex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetInterfaceTypeList(DemoSearchModel search, int id = 0)
        {
            search.PageSize = 2;
            search.PageIndex = (id == 0 ? 1 : id);
            var model = new InterfaceTypeBusiness().GetInterfaceTypeList();
            ViewData["TotalCount"] = model.Count();
            var modelView = model.Skip(search.PageSize * (search.PageIndex - 1)).Take(search.PageSize).ToList();

            return PartialView("InterfaceTypeResultView", modelView);
        }

    }
}