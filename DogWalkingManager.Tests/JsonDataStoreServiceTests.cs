using DogWalkingManager.Domain.Entities;
using DogWalkingManager.Infrastructure.Persistence;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DogWalkingManager.Tests
{
    /// <summary>
    /// Contains unit tests for JsonDataStoreService.
    /// </summary>
    [TestClass]
    public class JsonDataStoreServiceTests
    {
        private JsonDataStoreService _service;
        private const string ClientsFile = "clients.json";
        private const string DogsFile = "dogs.json";
        private const string WalksFile = "walks.json";

        [TestInitialize]
        public void Setup()
        {
            _service = new JsonDataStoreService();

            // Clean up any existing files before each test
            if (File.Exists(ClientsFile)) File.Delete(ClientsFile);
            if (File.Exists(DogsFile)) File.Delete(DogsFile);
            if (File.Exists(WalksFile)) File.Delete(WalksFile);
        }

        [TestCleanup]
        public void Cleanup()
        {
            // Clean up generated files after each test
            if (File.Exists(ClientsFile)) File.Delete(ClientsFile);
            if (File.Exists(DogsFile)) File.Delete(DogsFile);
            if (File.Exists(WalksFile)) File.Delete(WalksFile);
        }

        [TestMethod]
        public void SaveData_ShouldCreateJsonFiles()
        {
            // Arrange
            var clients = new List<Client> { new Client { Name = "John", PhoneNumber = "12345678" } };
            var dogs = new List<Dog> { new Dog { Name = "Rex", Breed = "Labrador", Age = 5, ClientId = clients[0].Id } };
            var walks = new List<Walk> { new Walk { WalkDate = DateTime.Now, DurationMinutes = 30, DogId = dogs[0].Id } };

            // Act
            _service.SaveData(clients, dogs, walks);

            // Assert
            Assert.IsTrue(File.Exists(ClientsFile));
            Assert.IsTrue(File.Exists(DogsFile));
            Assert.IsTrue(File.Exists(WalksFile));
        }

        [TestMethod]
        public void LoadData_ShouldLoadSavedDataCorrectly()
        {
            // Arrange
            SaveData_ShouldCreateJsonFiles(); // Save some data first

            var clients = new List<Client>();
            var dogs = new List<Dog>();
            var walks = new List<Walk>();

            // Act
            _service.LoadData(clients, dogs, walks);

            // Assert
            Assert.AreEqual(1, clients.Count);
            Assert.AreEqual(1, dogs.Count);
            Assert.AreEqual(1, walks.Count);

            Assert.AreEqual("John", clients.First().Name);
            Assert.AreEqual("Rex", dogs.First().Name);
            Assert.AreEqual(30, walks.First().DurationMinutes);
        }
    }
}
