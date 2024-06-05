using Prueba.Models;
using Prueba.Services.Pets;
using Microsoft.AspNetCore.Mvc;

namespace Prueba.Controllers.Pets
{
    public class PetUpdateController : ControllerBase
    {
        private readonly IPetsRepository _petsRepository;
        public PetUpdateController(IPetsRepository petsRepository)
        {
            _petsRepository = petsRepository;
        }
        [HttpPut("api/pet/{Id}")]
        public void UpdatePet(int Id, [FromBody] Pet pet) => _petsRepository.UpdatePet(pet.Id, pet);
    }
}