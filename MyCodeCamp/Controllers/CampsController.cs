using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyCodeCamp.Controllers
{
    public class CampsController: Controller
    {
        [HttpGet("api/[controller]")]
        public IActionResult Get()
        {
            return Ok(new {Name = "Shawn", FavoriteColor = "Blue"});
        }
    }
}
