using Prueba.Models;
using Prueba.Services.Pets;
using Microsoft.AspNetCore.Mvc;

namespace Prueba.Controllers.Pets
{
    public class PetsController : ControllerBase
    {
        private readonly IPetsRepository _petsRepository;
        public PetsController(IPetsRepository petsRepository)
        {
            _petsRepository = petsRepository;
        }
        [HttpGet]
        [Route("api/pets")]
        public IEnumerable<Pet> GetPets()
        {
            return _petsRepository.GetAll();
        }
        [HttpGet]
        [Route("api/pet/{id}")]
        public Pet GetPet(int id)
        {
            return _petsRepository.GetById(id);
        }
    }
}