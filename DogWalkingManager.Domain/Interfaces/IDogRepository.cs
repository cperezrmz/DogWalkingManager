using DogWalkingManager.Domain.Entities;

namespace DogWalkingManager.Domain.Interfaces
{
    /// <summary>
    /// Defines operations for managing dogs.
    /// </summary>
    public interface IDogRepository
    {
        void Add(Dog dog);
        void Delete(Guid dogId);
        Dog GetById(Guid id);
        IEnumerable<Dog> GetAll();
    }
}
