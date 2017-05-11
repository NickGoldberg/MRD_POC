using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MRD_POC.helpers;

namespace MRD_POC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<FormSettings> formSettings;

        public HomeController(IOptions<FormSettings> formSettings)
        {
            this.formSettings = formSettings;

            

        }
        public IActionResult Index()
        {
            ViewData["ThemeName"] = formSettings.Value.ThemeName;

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
