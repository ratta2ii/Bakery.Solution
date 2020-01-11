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


        [HttpGet("/vendors/{id}")]
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor selectedVendor = Vendor.Find(id);
            List<Order> vendorOrders = selectedVendor.Orders;
            model.Add("vendor", selectedVendor);
            model.Add("orders", vendorOrders);
            return View(model);
        }


        [HttpPost("/vendors/{vendorId}/orders")]
        public ActionResult Create(int vendorId, string title, string description, float price)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor vendorLocated = Vendor.Find(vendorId);
            Order newOrder = new Order(title, description, price);
            vendorLocated.AddOrder(newOrder);
            List<Order> vendorOrders = vendorLocated.Orders;
            model.Add("orders", vendorOrders);
            model.Add("vendor", vendorLocated);
            return View("Show", model);
        }       
    
    }
}