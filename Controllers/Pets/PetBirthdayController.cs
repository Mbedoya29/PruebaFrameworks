using Prueba.Models;
using Prueba.Services.Pets;
using Microsoft.AspNetCore.Mvc;

namespace Prueba.Controllers.Pets
{
     public class PetBirthdayController : ControllerBase
    {
        private readonly IPetsRepository _petsRepository;
        public PetBirthdayController(IPetsRepository petsRepository)
        {
            _petsRepository = petsRepository;
        }

        [HttpGet]
        [Route("api/pets/{date}/birthday")]
        public IEnumerable<Pet> BirthdayPets(DateTime date) => _petsRepository.BirthdayPets(date);
    }
}