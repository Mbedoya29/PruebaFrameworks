using Prueba.Models;

namespace Prueba.Services.Owners
{
    public interface IOwnersRepository
    {
        IEnumerable<Owner> GetAll();
        Owner GetById(int id);
        void CreateOwner (Owner owner);
        void UpdateOwner (int id, Owner owner);
    }
}