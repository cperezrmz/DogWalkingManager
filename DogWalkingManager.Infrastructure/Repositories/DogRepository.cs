using DogWalkingManager.Domain.Entities;
using DogWalkingManager.Domain.Interfaces;
using DogWalkingManager.Infrastructure.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DogWalkingManager.Infrastructure.Repositories
{
    /// <summary>
    /// Repository for managing Dog entities.
    /// </summary>
    public class DogRepository : IDogRepository
    {
        private readonly InMemoryContext _context;

        public DogRepository(InMemoryContext context)
        {
            _context = context;
        }

        public void Add(Dog dog)
        {
            _context.Dogs.Add(dog);
        }

        public void Delete(Guid dogId)
        {
            var dog = _context.Dogs.FirstOrDefault(d => d.Id == dogId);
            if (dog != null)
            {
                _context.Dogs.Remove(dog);
            }
        }

        public Dog GetById(Guid id)
        {
            return _context.Dogs.FirstOrDefault(d => d.Id == id);
        }

        public IEnumerable<Dog> GetAll()
        {
            return _context.Dogs;
        }
    }
}
