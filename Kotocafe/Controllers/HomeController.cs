using Microsoft.AspNetCore.Mvc;

namespace ObormotCatCafe.Controllers
{
    public class HomeController : Controller
    {
        // ������� ��������
        public IActionResult Index()
        {
            return View();
        }

        // �������� "� ���"
        public IActionResult About()
        {
            return View();
        }

        // �������� "����"
        public IActionResult Menu()
        {
            return View();
        }

        // �������� "��������"
        public IActionResult Contact()
        {
            return View();
        }
    }
}
