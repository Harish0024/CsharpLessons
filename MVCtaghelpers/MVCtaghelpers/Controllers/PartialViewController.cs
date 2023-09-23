using Microsoft.AspNetCore.Mvc;

namespace MVCtaghelpers.Controllers
{
    public class PartialViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tabs() 
        {
            ViewData["data1"] = "Tom and jerry are good friends";
            return View();
        }
    }
}
