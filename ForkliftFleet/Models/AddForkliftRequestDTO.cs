namespace ForkliftFleet.Models
{
    public class AddForkliftRequestDTO
    {
        public required string Name { get; set; }
        public required string ModelNumber { get; set; }
        public required DateTime ManufacturingDate { get; set; }
    }
}
