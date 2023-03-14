using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiskStartupSchool.DTO;
using MiskStartupSchool.Services;

namespace MiskStartupSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly IApplicationRepo _appRepo;

        public ApplicationController(IApplicationRepo apprepo)
        {
            _appRepo = apprepo;
        }
        [HttpPost("add-application")]
        public async Task<IActionResult> AddApplication([FromBody] ApplicationDto application)
        {
            return Ok(await _appRepo.Add(application));
        }
    }
}
