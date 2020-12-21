using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrCrexDeneme.Core.Service;
using TrCrexDeneme.Model.Entities;
using TrCrexDeneme.Service.Options;

namespace TrCrexDeneme.WebUII.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}