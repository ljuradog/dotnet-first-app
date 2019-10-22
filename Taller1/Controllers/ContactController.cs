using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taller1.Models;

namespace Taller1.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        // POST: Contact/Index
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Contact model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction(nameof(Thanks));
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

        // GET: Contact/Thanks
        public ActionResult Thanks()
        {
            return View();
        }
    }
}