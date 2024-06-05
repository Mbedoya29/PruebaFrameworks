using Prueba.Models;
using Prueba.Services.Vets;
using Microsoft.AspNetCore.Mvc;

namespace Prueba.Controllers.Vets
{
    public class VetsController : ControllerBase
    {
        private readonly IVetsRepository _vetsRepository;
        public VetsController(IVetsRepository vetsRepository)
        {
            _vetsRepository = vetsRepository;
        }
        [HttpGet]
        [Route("api/vets")]
        public IEnumerable<Vet> GetVets()
        {
            return _vetsRepository.GetAll();
        }
        [HttpGet]
        [Route("api/vet/{id}")]
        public Vet GetVet(int id)
        {
            return _vetsRepository.GetById(id);
        }
    }
}