using DogWalkingManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace DogWalkingManager.Infrastructure.Persistence
{
    /// <summary>
    /// Manages loading and saving entity data to JSON files on disk.
    /// </summary>
    public class JsonDataStoreService
    {
        private const string ClientsFile = "clients.json";
        private const string DogsFile = "dogs.json";
        private const string WalksFile = "walks.json";

        public void SaveData(List<Client> clients, List<Dog> dogs, List<Walk> walks)
        {
            File.WriteAllText(ClientsFile, JsonSerializer.Serialize(clients, new JsonSerializerOptions { WriteIndented = true }));
            File.WriteAllText(DogsFile, JsonSerializer.Serialize(dogs, new JsonSerializerOptions { WriteIndented = true }));
            File.WriteAllText(WalksFile, JsonSerializer.Serialize(walks, new JsonSerializerOptions { WriteIndented = true }));
        }

        public void LoadData(List<Client> clients, List<Dog> dogs, List<Walk> walks)
        {
            if (File.Exists(ClientsFile))
            {
                var loaded = JsonSerializer.Deserialize<List<Client>>(File.ReadAllText(ClientsFile));
                if (loaded != null) clients.AddRange(loaded);
            }

            if (File.Exists(DogsFile))
            {
                var loaded = JsonSerializer.Deserialize<List<Dog>>(File.ReadAllText(DogsFile));
                if (loaded != null) dogs.AddRange(loaded);
            }

            if (File.Exists(WalksFile))
            {
                var loaded = JsonSerializer.Deserialize<List<Walk>>(File.ReadAllText(WalksFile));
                if (loaded != null) walks.AddRange(loaded);
            }
        }
    }
}
