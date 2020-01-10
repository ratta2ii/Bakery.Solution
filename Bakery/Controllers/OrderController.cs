using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Controllers
{
    public class OrderController : Controller
    {

        [HttpGet("/vendors/{vendorId}/orders/new")]
        public ActionResult New(int vendorId)
        {
            Vendor vendor = Vendor.Find(vendorId);
            return View(vendor);   
        }

        [HttpGet("/orders")]
        public ActionResult Index()
        {
            return View();
        }

        // [HttpGet("/vendors/@Model["vendor"].Id/orders/{orderId}.")]
        // public ActionResult
        

    }
}