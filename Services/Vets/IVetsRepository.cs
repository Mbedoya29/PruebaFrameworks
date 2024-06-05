using Prueba.Models;

namespace Prueba.Services.Vets
{
    public interface IVetsRepository
    {
        IEnumerable<Vet> GetAll();
        Vet GetById(int id);
        void CreateVet (Vet vet);
        void UpdateVet (int id, Vet vet);
    }
}