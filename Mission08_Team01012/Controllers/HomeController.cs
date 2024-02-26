using Microsoft.AspNetCore.Mvc;
using Mission08_Team01012.Models;
using System.Diagnostics;

namespace Mission08_Team01012.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
