using Prueba.Models;
using Prueba.Services.Vets;
using Microsoft.AspNetCore.Mvc;

namespace Prueba.Controllers.Vets
{
    [ApiController]
    [Route("api/vet")]
    public class VetCreateController : ControllerBase
    {
        private readonly IVetsRepository _vetsRepository;
        public VetCreateController(IVetsRepository vetsRepository)
        {
            _vetsRepository = vetsRepository;
        }
        [HttpPost]
        public IActionResult CreateVet([FromBody] Vet vet)
        {
            _vetsRepository.CreateVet(vet);
            return Ok();
        }
    }
}