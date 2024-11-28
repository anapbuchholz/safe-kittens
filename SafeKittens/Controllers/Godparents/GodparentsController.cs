using Microsoft.AspNetCore.Mvc;
using SafeKittens.Application.Services.GodparentsService;
using SafeKittens.Controllers.Godparents.Contracts;
using System.Net;

namespace SafeKittens.Controllers.Godparents
{
    [ApiController]
    [Route("[controller]")]
    public class GodparentsController : ControllerBase
    {
        private readonly IGodparentsService _godparentsService;

        public GodparentsController(IGodparentsService godparentsService)
        {
            _godparentsService = godparentsService;
        }

        [HttpPost()]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Conflict)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> Post([FromBody] GodparentRequest request)
        {
            //await _godparentsService.
            return Created();
        }

    }
}
