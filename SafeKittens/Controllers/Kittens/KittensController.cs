using Microsoft.AspNetCore.Mvc;
using SafeKittens.Application.Services.KittensService;
using SafeKittens.Domain.Models;
using System.Net;

namespace SafeKittens.Controllers.Kittens
{
    [ApiController]
    [Route("[controller]")]
    public class KittensController : ControllerBase
    {
        private readonly IKittensService _kittensService;

        public KittensController(IKittensService kittensService)
        {
            _kittensService = kittensService;
        }

        [HttpPost()]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Conflict)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> Post([FromBody] Kitten request)
        {
            await _kittensService.RegisterKitten(request);

            return Created();
        }

        [HttpGet()]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.Forbidden)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetCollection()
        {
            var result = await _kittensService.GetKittens();

            return Ok(result);
        }

        [HttpGet("{kittenId}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.Forbidden)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> Get([FromRoute] Guid kittenId)
        {
            var result = await _kittensService.GetKitten(kittenId);

            return Ok(result);
        }
    }
}
