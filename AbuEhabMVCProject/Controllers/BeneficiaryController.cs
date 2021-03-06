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
    public class BeneficiaryController : Controller
    {
        // GET: Beneficiary
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetData([DataSourceRequest] DataSourceRequest request)
        {
            using (MVCProjectData db = new MVCProjectData())
            {
                var q = db.Beneficiaries .ToList();
                return Json(q.ToDataSourceResult(request));
            }
        }
    }
}