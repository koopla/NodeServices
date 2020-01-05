using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => Content("Hello world!");
    }
}
