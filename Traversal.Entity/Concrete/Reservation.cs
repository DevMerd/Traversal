namespace Traversal.Entity.Concrete
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string PersonCount { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public Destination Destination { get; set; }
        public int DestinationId { get; set; }
    }
}