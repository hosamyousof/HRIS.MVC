﻿using HRIS.Web.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRIS.Web.Controllers
{
    public class ReferencesController : BaseController
    {
        public ReferencesController()
        {

        }
        public ActionResult Index()
        {
            return View();
        }
    }
}