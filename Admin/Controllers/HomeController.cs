﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            //Response.Redirect("~/Customers");
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            return View();
        }
    }
}
