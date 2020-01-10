using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using Bakery.Models;

namespace Bakery.Controllers
{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> vendorList = Vendor.GetAll();
            return View(vendorList);
        }


        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }


        [HttpPost("/vendors")]
        public ActionResult Create(string name, string description)
        {
            Vendor newVendor = new Vendor(name, description);
            return Redirect("/");
        }
       
    

    }
}