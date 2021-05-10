using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCooking.Models.Util;

namespace WebAppCooking.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ThisWeeks()
        {
            //result                 Use model to do logic work                        
            List<string> menuPicks = RandomLunshGenerator.GenerateMenu();

            //send result to view so it can show it to the user
            return View(menuPicks);
        }
    }
}
