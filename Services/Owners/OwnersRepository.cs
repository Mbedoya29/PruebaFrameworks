using Prueba.Models;
using Prueba.Data;

namespace Prueba.Services.Owners
{
    public class OwnersRepository : IOwnersRepository
    {
        private readonly BaseContext _context;
        public OwnersRepository(BaseContext context)
        {
            _context = context;
        }
        public IEnumerable<Owner> GetAll()
        {
            return _context.Owners.ToList();
        }
        public Owner GetById(int id)
        {
            return _context.Owners.Find(id);
        }
        public void CreateOwner(Owner owner)
        {
            _context.Owners.Add(owner);
            _context.SaveChanges();
        }
        public void UpdateOwner(int id, Owner owner)
        {
            _context.Owners.Update(owner);
            _context.SaveChanges();
        }
    }
    
}