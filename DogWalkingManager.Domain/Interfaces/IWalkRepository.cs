using DogWalkingManager.Domain.Entities;

namespace DogWalkingManager.Domain.Interfaces
{
    /// <summary>
    /// Defines operations for managing dog walks.
    /// </summary>
    public interface IWalkRepository
    {
        void Add(Walk walk);
        IEnumerable<Walk> GetAll();
    }
}
