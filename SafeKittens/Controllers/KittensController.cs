using Microsoft.AspNetCore.Mvc;
using SafeKittens.Application.Services;
using System.Net;

namespace SafeKittens.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KittensController : ControllerBase
    {
        private readonly ILogger<Kitten> _logger;
        private readonly IKittensService _kittensService;

        public KittensController(ILogger<Kitten> logger, IKittensService kittensService)
        {
            _logger = logger;
            _kittensService = kittensService;
        }

        [HttpPost()]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Conflict)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> RegisterKitten([FromBody] Kitten request)
        {
            _kittensService.GetKitten();

            return Ok();
        }

        //[HttpGet()]
        //[ProducesResponseType((int)HttpStatusCode.OK)]
        //[ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        //[ProducesResponseType((int)HttpStatusCode.Forbidden)]
        //[ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        //public async Task<IActionResult> Get()
        //{

        //}
    }
}
