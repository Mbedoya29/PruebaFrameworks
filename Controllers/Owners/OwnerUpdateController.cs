using Prueba.Models;
using Prueba.Services.Owners;
using Microsoft.AspNetCore.Mvc;

namespace Prueba.Controllers.Owners
{
    public class OwnerUpdateController : ControllerBase
    {
        private readonly IOwnersRepository _ownersRepository;
        public OwnerUpdateController(IOwnersRepository ownersRepository)
        {
            _ownersRepository = ownersRepository;
        }
        [HttpPut("api/owner/{Id}")]
        public void UpdateOwner(int Id, [FromBody] Owner owner) => _ownersRepository.UpdateOwner(owner.Id, owner);
    }
}