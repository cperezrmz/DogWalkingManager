namespace DogWalkingManager.Domain.Entities
{
    /// <summary>
    /// Represents a client that owns dogs.
    /// </summary>
    public class Client
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
