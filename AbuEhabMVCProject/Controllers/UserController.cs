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
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        // All Data
        public JsonResult GetData([DataSourceRequest] DataSourceRequest request)
        {
            using (MVCProjectData db = new MVCProjectData())
            {
                var q = db.Users.ToList();
                return Json(q.ToDataSourceResult(request));
            }
        }


        // Insert New
        public JsonResult Create_User([DataSourceRequest] DataSourceRequest request, User User)
        {
            using (MVCProjectData db = new MVCProjectData())
            {
                if (User != null && ModelState.IsValid)
                {
                    User u = new User();
                    u.UserName = User.UserName;
                  
                    db.Users.Add(u);
                    db.SaveChanges();
                    User.Id = u.Id;
                }

                return Json(new[] { User }.ToDataSourceResult(request, ModelState));
            }
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult Update_User([DataSourceRequest] DataSourceRequest request, User Usr)
        {
            using (MVCProjectData db = new MVCProjectData())
            {
                if (User != null && ModelState.IsValid)
                {
                    User u = db.Users.Single(c => c.Id == Usr.Id);
                   u.UserName = Usr.UserName;
                   
            
                }
                db.SaveChanges();
                return Json(ModelState.IsValid ? true : ModelState.ToDataSourceResult());
            }
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult Delete_User([DataSourceRequest] DataSourceRequest request, User Usr)
        {
            using (MVCProjectData db = new MVCProjectData())
            {
                if (User != null && ModelState.IsValid)
                {
                    User emp = db.Users.Single(c => c.Id == Usr.Id);
                    db.Users.Remove(emp);
                }

                db.SaveChanges();
                return Json(ModelState.IsValid ? true : ModelState.ToDataSourceResult());
            }
        }
    }
}