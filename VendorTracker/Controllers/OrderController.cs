using Microsoft.AspNetCore.Mvc;

namespace VendorTracker.Controllers
{
    public class OrderController : Controller
    {

        [HttpGet()]
        public ActionResult Index()
        {
            return View();
        }
    }
}