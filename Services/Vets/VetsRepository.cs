using Prueba.Models;
using Prueba.Data;

namespace Prueba.Services.Vets
{
    public class VetsRepository : IVetsRepository
    {
        private readonly BaseContext _context;
        public VetsRepository(BaseContext context)
        {
            _context = context;
        }
        public IEnumerable<Vet> GetAll()
        {
            return _context.Vets.ToList();
        }
        public Vet GetById(int id)
        {
            return _context.Vets.Find(id);
        }
        public void CreateVet(Vet vet)
        {
            _context.Vets.Add(vet);
            _context.SaveChanges();
        }
        public void UpdateVet(int id, Vet vet)
        {
            _context.Vets.Update(vet);
            _context.SaveChanges();
        }
    }
    
}