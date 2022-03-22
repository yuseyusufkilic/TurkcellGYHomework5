using basicASPNETCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basicASPNETCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Name = "Yuse Yusuf";            
            return View();
        }

        [HttpGet]
        public IActionResult Invitation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Invitation(Participant participant,string checkPart )
        {
            if (checkPart=="participate")
            {
                return View("Thanks");

            }
            else if(checkPart=="notparticipate")
            {
                return View("Sad");

            }
            return View();
        }
    }
}
