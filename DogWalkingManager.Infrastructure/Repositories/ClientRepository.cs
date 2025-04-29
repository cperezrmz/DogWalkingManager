using DogWalkingManager.Domain.Entities;
using DogWalkingManager.Domain.Interfaces;
using DogWalkingManager.Infrastructure.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DogWalkingManager.Infrastructure.Repositories
{
    /// <summary>
    /// Repository for managing Client entities.
    /// </summary>
    public class ClientRepository : IClientRepository
    {
        private readonly InMemoryContext _context;

        public ClientRepository(InMemoryContext context)
        {
            _context = context;
        }

        public void Add(Client client)
        {
            _context.Clients.Add(client);
        }

        public void Delete(Guid clientId)
        {
            var client = _context.Clients.FirstOrDefault(c => c.Id == clientId);
            if (client != null)
            {
                _context.Clients.Remove(client);
            }
        }

        public Client GetById(Guid id)
        {
            return _context.Clients.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Client> GetAll()
        {
            return _context.Clients;
        }
    }
}
