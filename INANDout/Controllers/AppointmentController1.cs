using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INANDout.Controllers
{
    public class AppointmentController1 : Controller
    {
        public IActionResult Index()
        {
            // return View();
            string datetime = DateTime.Now.ToShortDateString();
            return Ok(datetime);
        }
    }
}
