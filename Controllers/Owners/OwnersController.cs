using Prueba.Models;
using Prueba.Services.Owners;
using Microsoft.AspNetCore.Mvc;

namespace Prueba.Controllers.Owners
{
    public class OwnersController : ControllerBase
    {
        private readonly IOwnersRepository _ownersRepository;
        public OwnersController(IOwnersRepository ownersRepository)
        {
            _ownersRepository = ownersRepository;
        }
        [HttpGet]
        [Route("api/owners")]
        public IEnumerable<Owner> GetOwners()
        {
            return _ownersRepository.GetAll();
        }
        [HttpGet]
        [Route("api/owner/{id}")]
        public Owner GetOwner(int id)
        {
            return _ownersRepository.GetById(id);
        }
    }
}