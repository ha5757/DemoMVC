using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class XyzController : Controller
    {
        // GET: Xyz
        public ActionResult Index()
        {
            ViewBag.str = "My First MVC Project";
            ViewData["str1"] = "My First Project";
            TempData["str2"] = "Harishma project";
            return View();
        }
        public ActionResult SendObject()
        {
            Emp E = new Emp();
            E.Empno = 100;
            E.Ename = "sai";
            E.Salary = 100000;
            return View(E);
        }
        public ActionResult SendObjects()
        {
            List<Emp> L = new List<Emp>();
            Emp E = null;
            E = new Emp();
            E.Empno = 1;
            E.Ename = "hari";
            E.Salary = 10000;
            L.Add(E);
            E = new Emp();
            E.Empno = 2;
            E.Ename = "reddy";
            E.Salary = 20000;
            L.Add(E);

            return View(L);
        }
        public ActionResult SendObjectB()
        {
            Emp E = null;
            E = new Emp();
            E.Empno = 1;
            E.Ename = "hariPAPA";
            E.Salary = 10000;
            //ViewBag.xyz = E;
            ViewData["xyz"] = E;
            return View(E);

        }
        public ActionResult SendObjectVB()
        {
            List<Emp> L = new List<Emp>();
            Emp E = null;
        E = new Emp();
        E.Empno = 1;
            E.Ename = "hari";
            E.Salary = 10000;
            L.Add(E);
            E = new Emp();
        E.Empno = 2;
            E.Ename = "reddy";
            E.Salary = 20000;
            L.Add(E);
            ViewBag.Xyz = L;
            return View();
        }
        public ActionResult SendObjectsVB()
        {
            List<Emp> L = new List<Emp>();
            Emp E = null;
            E = new Emp();
            E.Empno = 1;
            E.Ename = "hari";
            E.Salary = 10000;
            L.Add(E);
            E = new Emp();
            E.Empno = 2;
            E.Ename = "reddy";
            E.Salary = 20000;
            L.Add(E);
            ViewData["xyz"] = L;
            return View();
        }
    }
}