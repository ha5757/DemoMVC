using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class CheckboxController : Controller
    {
        // GET: Checkbox
        List<EMPDATA> l = null;
        public ActionResult Index()
        {
            l = DBOperations.GetDepts();
            ViewBag.x = l;
            return View();
          
        }
        List<EMPDATA> p = null;
        public ActionResult GetAllEmpData1(int[] n)
        {
           
             p = DBOperations.GetEmpupdate1(n);
            return View(p);
        }
    }
}