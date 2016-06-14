using AbuEhabMVCProject.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AbuEhabMVCProject.Controllers
{
    public class ActitvityController : Controller
    {
        // GET: Actitvity
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetData([DataSourceRequest] DataSourceRequest request)
        {
            using (MVCProjectData db = new MVCProjectData())
            {
                var q = db.Actitvities .ToList();
                return Json(q.ToDataSourceResult(request));
            }
        }
    }
}