using Microsoft.AspNetCore.Mvc;

namespace CorsoDotnet.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index() {
            return Content("Ciao Mondo dal primo controller .NET 3");
        }
        
        public IActionResult Detail(string id) {
            return Content($"Sono il dettaglio {id}");
        }

    }
}