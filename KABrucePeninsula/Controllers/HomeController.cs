using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KABrucePeninsula.Models;

namespace KABrucePeninsula.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("SignUp");
        }

        [HttpGet]
        public ViewResult SignUpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult SignUpForm(Responses guestResponses)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponses);
                return View("Thanks", guestResponses);
            }
            else
            {
                return View();
            }
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }


    }
}
