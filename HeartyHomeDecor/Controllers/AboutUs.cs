using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeartyHomeDecor.Controllers
{
    public class AboutUs : Controller
    {
        public IActionResult AboutUsDetail()
        {
            return View();
        }
    }
}
