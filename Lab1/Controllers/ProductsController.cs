using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Products()
        { 
            ViewBag.Message = "Hello world";
            return View();
        }
    }
}