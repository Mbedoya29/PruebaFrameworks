using Prueba.Models;

namespace Prueba.Services.Pets
{
    public interface IPetsRepository
    {
        IEnumerable<Pet> GetAll();
        Pet GetById(int id);
        void CreatePet (Pet pet);
        void UpdatePet (int id, Pet pet);
        IEnumerable<Pet> OwnerAndPets (int id);
        IEnumerable<Pet> BirthdayPets (DateTime date);
    }
}