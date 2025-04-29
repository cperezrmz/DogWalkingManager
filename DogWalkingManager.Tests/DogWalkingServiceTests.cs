using DogWalkingManager.Domain.Entities;
using DogWalkingManager.Infrastructure.DataContext;
using DogWalkingManager.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace DogWalkingManager.Tests
{
    /// <summary>
    /// Contains unit tests for DogWalkingService.
    /// </summary>
    [TestClass]
    public class DogWalkingServiceTests
    {
        private DogWalkingService _service;
        private InMemoryContext _context;

        [TestInitialize]
        public void Setup()
        {
            _context = new InMemoryContext();
            _service = new DogWalkingService(_context);
        }

        [TestMethod]
        public void SaveClientDogAndWalk_ShouldSaveDataCorrectly()
        {
            // Arrange
            string clientName = "John Doe";
            string phone = "12345678";
            string dogName = "Rex";
            string breed = "Labrador";
            int age = 5;
            DateTime walkDate = DateTime.Now;
            int duration = 30;

            // Act
            _service.SaveClientDogAndWalk(clientName, phone, dogName, breed, age, walkDate, duration);

            // Assert
            Assert.AreEqual(1, _context.Clients.Count);
            Assert.AreEqual(1, _context.Dogs.Count);
            Assert.AreEqual(1, _context.Walks.Count);

            var client = _context.Clients.First();
            var dog = _context.Dogs.First();
            var walk = _context.Walks.First();

            Assert.AreEqual(clientName, client.Name);
            Assert.AreEqual(phone, client.PhoneNumber);
            Assert.AreEqual(dogName, dog.Name);
            Assert.AreEqual(breed, dog.Breed);
            Assert.AreEqual(age, dog.Age);
            Assert.AreEqual(duration, walk.DurationMinutes);
        }

        [TestMethod]
        public void DeleteClientByName_ShouldDeleteClientDogsAndWalks()
        {
            // Arrange
            SaveClientDogAndWalk_ShouldSaveDataCorrectly();

            string clientName = "John Doe";

            // Act
            _service.DeleteClientByName(clientName);

            // Assert
            Assert.AreEqual(0, _context.Clients.Count);
            Assert.AreEqual(0, _context.Dogs.Count);
            Assert.AreEqual(0, _context.Walks.Count);
        }
    }
}
