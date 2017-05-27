using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //[Route("")]   // default action
        public string Phone()
        {
            return "+1-555-555-5555";
        }

        //[Route("[action]")]
        public string Country()
        {
            return "USA";
        }
    }
}