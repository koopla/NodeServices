using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.NodeServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(INodeServices nodeServices)
        {
            NodeServices = nodeServices;
        }

        INodeServices NodeServices { get; }

        public async Task<IActionResult> Index()
        {
            var result = await NodeServices.InvokeAsync<int>("./addNumbers", 1, 2);
            return Content("1 + 2 = " + result);
        }
    }
}
