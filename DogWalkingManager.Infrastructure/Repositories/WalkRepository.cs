using DogWalkingManager.Domain.Entities;
using DogWalkingManager.Domain.Interfaces;
using DogWalkingManager.Infrastructure.DataContext;
using System.Collections.Generic;

namespace DogWalkingManager.Infrastructure.Repositories
{
    /// <summary>
    /// Repository for managing Walk entities.
    /// </summary>
    public class WalkRepository : IWalkRepository
    {
        private readonly InMemoryContext _context;

        public WalkRepository(InMemoryContext context)
        {
            _context = context;
        }

        public void Add(Walk walk)
        {
            _context.Walks.Add(walk);
        }

        public IEnumerable<Walk> GetAll()
        {
            return _context.Walks;
        }
    }
}
