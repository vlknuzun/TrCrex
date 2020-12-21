using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrCrexDeneme.Model.Context;
using TrCrexDeneme.Model.Entities;
using TrCrexDeneme.Service.Options;

namespace TrCrex.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        ProjectContext _db;
        CurrencyService _currencyService;
        public HomeController(ProjectContext db)
        {
            _db = db;
        }
        public HomeController(CurrencyService currencyService)
        {
            _currencyService = currencyService;
        }
        [HttpGet]
        public List<Currency> Index()
        {
            return _db.Currencies.ToList();
        }
    }
}