using Microsoft.AspNetCore.Mvc;

namespace ObormotCatCafe.Controllers
{
    public class HomeController : Controller
    {
        // Главная страница
        public IActionResult Index()
        {
            return View();
        }

        // Страница "О нас"
        public IActionResult About()
        {
            return View();
        }

        // Страница "Меню"
        public IActionResult Menu()
        {
            return View();
        }

        // Страница "Контакты"
        public IActionResult Contact()
        {
            return View();
        }
    }
}
