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
    
    public class UsersController : ControllerBase
    {
        ProjectContext _db;
        
        public UsersController(ProjectContext db)
        {
            _db = db;
        }

        public List<User> GetUsers()
        {
            return _db.Users.ToList();
        }
    }
}