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

        [HttpGet("get-program")]
        public async Task<IActionResult> GetProgram(string Id)
        {
           var data = await _appRepo.GetProgram(Id);
            return Ok(data);
        }


        [HttpGet("preview")]
        public async Task<IActionResult> GetAllProgram()
        {
            var data = await _appRepo.GetAllProgram();
            return Ok(data);
        }

        [HttpPut("update-program")]
        public async Task<IActionResult> UpdateProgram(ProgramDto program, string Id)
        {
            var data = await _appRepo.UpdateProgram(program, Id);
            return data? Ok(StatusCode(200)) : BadRequest(StatusCode(404));
        }
    }
}
