using DogWalkingManager.Domain.Entities;
using DogWalkingManager.Domain.Interfaces;
using DogWalkingManager.Infrastructure.DataContext;
using DogWalkingManager.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DogWalkingManager.Services
{
    /// <summary>
    /// Provides operations for managing clients, dogs, and walks.
    /// </summary>
    public class DogWalkingService
    {
        private readonly InMemoryContext _context;
        private readonly IClientRepository _clientRepository;
        private readonly IDogRepository _dogRepository;
        private readonly IWalkRepository _walkRepository;        

        public DogWalkingService(InMemoryContext context)
        {
            _context = context;
            _clientRepository = new ClientRepository(context);
            _dogRepository = new DogRepository(context);
            _walkRepository = new WalkRepository(context);
        }

        public void SaveClientDogAndWalk(string clientName, string phone, string dogName, string breed, int age, DateTime walkDate, int durationMinutes)
        {
            var client = new Client
            {
                Name = clientName.Trim(),
                PhoneNumber = phone.Trim()
            };
            _clientRepository.Add(client);

            var dog = new Dog
            {
                Name = dogName.Trim(),
                Breed = breed.Trim(),
                Age = age,
                ClientId = client.Id
            };
            _dogRepository.Add(dog);

            var walk = new Walk
            {
                WalkDate = walkDate,
                DurationMinutes = durationMinutes,
                DogId = dog.Id
            };
            _walkRepository.Add(walk);
        }

        public void DeleteClientByName(string clientName)
        {
            var client = _clientRepository.GetAll().FirstOrDefault(c => c.Name == clientName);
            if (client == null) return;

            var dogs = _dogRepository.GetAll().Where(d => d.ClientId == client.Id).ToList();
            foreach (var dog in dogs)
            {
                var walks = _walkRepository.GetAll().Where(w => w.DogId == dog.Id).ToList();
                foreach (var walk in walks)
                {
                    _context.Walks.Remove(walk);
                }
                _dogRepository.Delete(dog.Id);
            }

            _clientRepository.Delete(client.Id);
        }
    }
}
