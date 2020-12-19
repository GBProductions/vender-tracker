using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Controllers
{
    public class VendorController : Controller
    {

        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            return View(allVendors);
        }
    }
}