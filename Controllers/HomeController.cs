using Microsoft.AspNetCore.Mvc;

namespace CorsoDotnet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() {

            return View();
        }
        
    }
}