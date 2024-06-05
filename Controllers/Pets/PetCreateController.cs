using Prueba.Models;
using Prueba.Services.Pets;
using Microsoft.AspNetCore.Mvc;

namespace Prueba.Controllers.Pets
{
    [ApiController]
    [Route("api/pet")]
    public class PetCreateController : ControllerBase
    {
        private readonly IPetsRepository _petsRepository;
        public PetCreateController(IPetsRepository petsRepository)
        {
            _petsRepository = petsRepository;
        }
        [HttpPost]
        public IActionResult CreatePet([FromBody] Pet pet)
        {
            _petsRepository.CreatePet(pet);
            return Ok();
        }
    }
}