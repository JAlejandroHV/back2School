﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace backToSchool.Controllers
{
    public class HomeController : Controller
    {
        //-------------------------------------------
        //             Esta es la vista Index
        //-------------------------------------------

        public ActionResult Index()
        {
            return View();
        }






        //-------------------------------------------
        //             Esta es la vista About
        //-------------------------------------------
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }






        //-------------------------------------------
        //             Esta es la vista Contact
        //-------------------------------------------
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}