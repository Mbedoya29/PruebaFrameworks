using Prueba.Models;
using Prueba.Services.Vets;
using Microsoft.AspNetCore.Mvc;

namespace Prueba.Controllers.Vets
{
    public class VetUpdateController : ControllerBase
    {
        private readonly IVetsRepository _vetsRepository;
        public VetUpdateController(IVetsRepository vetsRepository)
        {
            _vetsRepository = vetsRepository;
        }
        [HttpPut("api/vet/{Id}")]
        public void UpdateVet(int Id, [FromBody] Vet vet) => _vetsRepository.UpdateVet(vet.Id, vet);
    }
}