using DogWalkingManager.Domain.Entities;
using System.Collections.Generic;

namespace DogWalkingManager.Infrastructure.DataContext
{
    /// <summary>
    /// Provides an in-memory data context for storing clients, dogs, and walks.
    /// </summary>
    public class InMemoryContext
    {
        public List<Client> Clients { get; set; } = new List<Client>();
        public List<Dog> Dogs { get; set; } = new List<Dog>();
        public List<Walk> Walks { get; set; } = new List<Walk>();
    }
}
