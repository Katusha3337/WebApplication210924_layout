using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication210924_layout.Models;

namespace WebApplication210924_layout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Action1()
        {
            return View();
        }

        public IActionResult Action2()
        {
            return View();
        }
    }
}
