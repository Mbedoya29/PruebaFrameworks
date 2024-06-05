using Prueba.Models;
using Prueba.Data;

namespace Prueba.Services.Pets
{
    public class PetsRepository : IPetsRepository
    {
        private readonly BaseContext _context;
        public PetsRepository(BaseContext context)
        {
            _context = context;
        }
        public IEnumerable<Pet> GetAll()
        {
            return _context.Pets.ToList();
        }
        public Pet GetById(int id)
        {
            return _context.Pets.Find(id);
        }
        public void CreatePet(Pet pet)
        {
            _context.Pets.Add(pet);
            _context.SaveChanges();
        }
        public void UpdatePet(int id, Pet pet)
        {
            _context.Pets.Update(pet);
            _context.SaveChanges();
        }
        public IEnumerable<Pet> OwnerAndPets(int id)
        {
            return _context.Pets.Where(p => p.OwnerId == id).ToList();
        }
        public IEnumerable<Pet> BirthdayPets(DateTime date)
        {
            return _context.Pets.Where(p => p.DateBirth == date).ToList();
        }
    }
}