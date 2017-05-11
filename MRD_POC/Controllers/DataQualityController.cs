using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MRD_POC.Controllers
{
    public class DataQualityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}