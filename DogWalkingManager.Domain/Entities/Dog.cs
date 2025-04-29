namespace DogWalkingManager.Domain.Entities
{
    /// <summary>
    /// Represents a dog owned by a client.
    /// </summary>
    public class Dog
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public Guid ClientId { get; set; }
    }
}
