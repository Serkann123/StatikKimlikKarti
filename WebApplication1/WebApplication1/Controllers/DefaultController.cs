﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
     
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult deneme()
        {
            return View();
        }
    }
}