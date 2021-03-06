﻿using AbuEhabMVCProject.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AbuEhabMVCProject.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetData([DataSourceRequest] DataSourceRequest request)
        {
            using (MVCProjectData db = new MVCProjectData())
            {
                var q = db.Projects .ToList();
                return Json(q.ToDataSourceResult(request));
            }
        }
    }
}