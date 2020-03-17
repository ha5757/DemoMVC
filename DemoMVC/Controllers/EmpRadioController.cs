using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class EmpRadioController : Controller
    {
        // GET: EmpRadio
        List<EMPDATA> l = null;
        public ActionResult Index()
        {
            l = DBOperations.GetDepts();
            ViewBag.x = l;
            return View();
        }
        public ActionResult GetAllEmpData()
        {
            int empno = Convert.ToInt32(Request.Form["n"].ToString());
            EMPDATA emp = DBOperations.GetEmpupdate(empno);
            return View(emp);
        }
    }
}