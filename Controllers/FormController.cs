using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab2zadanie.Models;

namespace lab2zadanie.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //get
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FormModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Created", model);
            }
            return View(model);
        }
    }
}
