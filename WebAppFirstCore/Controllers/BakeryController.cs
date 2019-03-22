using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using WebAppFirstCore.Models;

namespace WebAppFirstCore.Controllers
{
    public class BakeryController : Controller
    {
        ICakeService _cakeService;

        public BakeryController(ICakeService cakeService)   //D.I.
        {
            _cakeService = cakeService;
        }

        public IActionResult Index()
        {
            return View(_cakeService.AllCakes());
        }
        [HttpPost]
        public IActionResult Index(string name, int price, string details)
        {
            _cakeService.CreateCake(name, price, details);

            return View(_cakeService.AllCakes());
        }

        public IActionResult AJAXPartialExample(int id)
        {
            return PartialView("_Cake", _cakeService.FindCake(id));
        }
    }
}