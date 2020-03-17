using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class EventsExController : Controller
    {
        // GET: EventsEx
       
        public ActionResult Index()
        {
            //step1,getDept retrive all dept data
            ViewBag.EL = DBOperations.delDept();
            return View();
        }
        public ActionResult GetData()
        {
            //it will not work for onblur,onchange ;it will only work for submit
            //int empno = int.Parse(Request.Form["ddlEmpno"]);
            int empno = int.Parse(Request.QueryString["empno"]);
            ViewBag.msg = DBOperations.DeleteEmp(empno);
            //to get the data after refreshing
            ViewBag.EL = DBOperations.delDept();
            return View("Index");
        }
        public ActionResult Emp()
        {
            return View();
        }

        public ActionResult GetEmp()
        {
            int empno = int.Parse(Request.QueryString["e"]);
            EMPDATA emp = DBOperations.Emp(empno);
            return View("Emp", emp);
        }
        public ActionResult Update(EMPDATA E)
        {
            int empno = int.Parse(Request.Form["EMPNO"]);
            string m = DBOperations.GetEmpnoData(empno, E);
            ViewBag.res = m;
            return View("Emp");
        }
        public ActionResult Date()
        {

            return View();
        }  
        public ActionResult Display()
        {
           
                DateTime startdate = DateTime.Parse(Request.Form["txtstartdate"]);
                DateTime enddate = DateTime.Parse(Request.Form["txtenddate"]);
                List<EMPDATA> L = DBOperations.GetDisplay(startdate, enddate);
                return View("Date",L);
            
            
        }
        
        
    }
}