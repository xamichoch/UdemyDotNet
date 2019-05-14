using Microsoft.AspNetCore.Mvc;

namespace CorsoDotnet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() {

            return Content("Sono la tua home preferita!");
        }
        
    }
}