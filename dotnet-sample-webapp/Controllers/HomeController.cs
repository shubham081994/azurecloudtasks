using Microsoft.AspNetCore.Mvc;

namespace dotnet_sample_webapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Hello from Azure Web App!";
            return View();
        }
    }
}
