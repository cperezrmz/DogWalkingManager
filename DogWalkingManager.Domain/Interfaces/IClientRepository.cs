using DogWalkingManager.Domain.Entities;

namespace DogWalkingManager.Domain.Interfaces
{
    /// <summary>
    /// Defines operations for managing clients.
    /// </summary>
    public interface IClientRepository
    {
        void Add(Client client);
        void Delete(Guid clientId);
        Client GetById(Guid id);
        IEnumerable<Client> GetAll();
    }
}
