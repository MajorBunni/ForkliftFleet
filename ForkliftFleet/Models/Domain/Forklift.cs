namespace ForkliftFleet.Models.Domain
{
    public class Forklift
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string ModelNumber { get; set; }
        public required DateTime ManufacturingDate { get; set; }
    }
}
