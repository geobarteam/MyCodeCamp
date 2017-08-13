using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCodeCamp.Data;

namespace MyCodeCamp.Controllers
{
    [Route("api/camps")]
    public class CampsController: Controller
    {
        private ICampRepository _repo;
        public CampsController(ICampRepository repo){
            this._repo = repo;
        }

        
        [HttpGet]
        public IActionResult Get()
        {
            var camps = this._repo.GetAllCamps();
            return Ok(camps);
        }
    }
}
