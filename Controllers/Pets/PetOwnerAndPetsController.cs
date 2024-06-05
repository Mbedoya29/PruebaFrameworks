using Prueba.Models;
using Prueba.Services.Pets;
using Microsoft.AspNetCore.Mvc;

namespace Prueba.Controllers.Pets
{
     public class PetOwnerAndPetsController : ControllerBase
    {
        private readonly IPetsRepository _petsRepository;
        public PetOwnerAndPetsController(IPetsRepository petsRepository)
        {
            _petsRepository = petsRepository;
        }

        [HttpGet]
        [Route("api/pets/{Id}/owner")]
        public IEnumerable<Pet> OwnerAndPets(int Id) => _petsRepository.OwnerAndPets(Id);

    }
}