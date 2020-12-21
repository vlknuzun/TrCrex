using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrCrexDeneme.Model.Context;
using TrCrexDeneme.Model.Entities;

namespace TrCrex.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CurrenciesController : ControllerBase
    {
        ProjectContext _db;
        public CurrenciesController(ProjectContext db)
        {
            _db = db;
        }

        [HttpGet]
        public List<Currency> GetCurrencies()
        {
            return _db.Currencies.ToList();
        }
    }
}