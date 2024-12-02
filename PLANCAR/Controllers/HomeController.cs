using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PLANCAR.Models;
using PLANCAR_DAO.IDAO;

namespace PLANCAR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDepartementDAO _departementDAO;

        public HomeController(ILogger<HomeController> logger, IDepartementDAO departementDAO)
        {
            _logger = logger;
            _departementDAO = departementDAO;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
