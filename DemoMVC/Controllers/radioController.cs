﻿using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class radioController : Controller
    {
        // GET: radio
        List<DEPTDATA> dlist = null;
        List<EMPDATA> l = null;
        public ActionResult Index()
        {
            dlist = DBOperations.getDepts();
            ViewBag.d = dlist;
            return View();
        }
        public ActionResult radiobtn()
        {

            dlist = DBOperations.getDepts();
            ViewBag.d = dlist;

            if (Request.Form["txtsd"] != null && Request.Form["txted"] != null)
            {
                DateTime start = DateTime.Parse(Request.Form["txtsd"]);
                DateTime end = DateTime.Parse(Request.Form["txted"]);
                l = DBOperations.GetDisplay(start, end);
                ViewBag.list = l;
            }
            if (Request.Form["ddldeptno"] != null)
            {
                int deptno = int.Parse(Request.Form["ddldeptno"]);
                l = DBOperations.GetDept(deptno);
                ViewBag.list = l;
            }



            return View("Index");
        }
    }
}