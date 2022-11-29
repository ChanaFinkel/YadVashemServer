using Microsoft.AspNetCore.Mvc;
using Registrant.Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YadVashemServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrantController : ControllerBase
    {
        private readonly IRegistrantService _registrantService;
        public RegistrantController(IRegistrantService registrantService)
        {
            _registrantService= registrantService;
        }
        // GET: api/<RegistrantController>
        [HttpGet]
        public async Task<ActionResult<List<Entities.Registrant>>> GetAllRegistransAsynv()
        {
            return Ok(await _registrantService.GetAllRegistantsAsync());
        }
    }
}
