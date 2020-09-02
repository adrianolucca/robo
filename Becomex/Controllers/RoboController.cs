using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo.Domain.Entities;
using Modelo.Domain.Interfaces.Services;

namespace Becomex.Controllers
{
    [Route("Robo/")]
    [ApiController]
    public class RoboController : ControllerBase
    {
        private readonly IRoboService _roboService;


        public RoboController(IRoboService roboService)
        {
            _roboService = roboService;
        }

    
        [HttpPost]
        [Route("api/NextMove")]
        public IActionResult NextMove(Robo robo)
        {
            Robo roboRetorno = new Robo();
            try
            {
                roboRetorno = _roboService.NextMove(robo);
                return Ok(roboRetorno);
            }
            catch (Exception ex)
            {        
                
                return BadRequest(roboRetorno);
            }
        }
      
    }
}
