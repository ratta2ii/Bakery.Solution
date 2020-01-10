using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using Bakery.Models;

namespace Bakery.Controllers
{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors/new")]
        public ActionResult Index()
        {
            return View();
        }
    }
}