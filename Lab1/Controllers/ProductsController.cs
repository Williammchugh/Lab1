﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        { 
            ViewBag.Message = "Hello world";
            return View();
        }
        public ActionResult Products()
        {
            return View();
        }
        public ActionResult Details(string product)
        {
            ViewBag.Product = product;
            return View();
        }
    }
}