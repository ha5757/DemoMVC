using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class ValidationController : Controller
    {
        // GET: Validation
        public ActionResult Index()
        {
           
            return View();
        }
        
        public ActionResult Getback(Validationcls V)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("AddPage");
            }
            return View("Index");
        }
        public ActionResult AddPage()
        {
            return View();
        }
    }
}