using Microsoft.AspNetCore.Mvc;

namespace VendorTracker.Controllers
{
    public class VendorController : Controller
    {

        [HttpGet()]
        public ActionResult Index()
        {
            return View();
        }
    }
}