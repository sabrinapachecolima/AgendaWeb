using Microsoft.AspNetCore.Mvc;

namespace AgendaWeb.Presentation.Controllers

{
    // classe de controle do  Aspenet MVC
    public class HomeController : Controller
    {
        // Método utilizado para abrir a página /Home/Index
        public IActionResult Index()
        {
            return View();
        }
    }
}
