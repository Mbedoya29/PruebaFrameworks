using Prueba.Models;
using Prueba.Services.Owners;
using Microsoft.AspNetCore.Mvc;

namespace Prueba.Controllers.Owners
{
    [ApiController]
    [Route("api/owner")]
    public class OwnerCreateController : ControllerBase
    {
        private readonly IOwnersRepository _ownersRepository;
        public OwnerCreateController(IOwnersRepository ownersRepository)
        {
            _ownersRepository = ownersRepository;
        }
        [HttpPost]
        public IActionResult CreateOwner([FromBody] Owner owner)
        {
            _ownersRepository.CreateOwner(owner);
            return Ok();
        }
    }
}