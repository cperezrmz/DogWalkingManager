namespace DogWalkingManager.Domain.Entities
{
    /// <summary>
    /// Represents a dog walking session.
    /// </summary>
    public class Walk
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime WalkDate { get; set; }
        public int DurationMinutes { get; set; }
        public Guid DogId { get; set; }
    }
}
