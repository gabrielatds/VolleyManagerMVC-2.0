using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolleyMVC.Controllers
{
    public class TimesControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
