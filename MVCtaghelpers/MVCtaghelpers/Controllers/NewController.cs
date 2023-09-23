using Microsoft.AspNetCore.Mvc;

namespace MVCtaghelpers.Controllers
{
    public class NewController : Controller
    {
        public IActionResult Start()
        {
            return View();
        }
    }
}
