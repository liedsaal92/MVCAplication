﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication.Controllers
{
    public class MasterPageController : Controller
    {
        //
        // GET: /MasterPage/

        public ActionResult Index()
        {
            return View();
        }

    }
}
