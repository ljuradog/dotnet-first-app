using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Taller1.Filters;
using Taller1.Models;

namespace Taller1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        // POST: Home/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (model.UserName == "Leo" && model.Password == "123")
                    {
                        HttpContext.Session.SetString("Autenticated", "True");
                        return RedirectToAction("Secure");
                    }
                    else
                    {
                        return View();
                    }
                }
                else
                {
                    return View();
                }
                // TODO: Add insert logic here

            }
            catch
            {
                return View();
            }
        }

        [CustomAuthFilter]
        public IActionResult Secure()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}
