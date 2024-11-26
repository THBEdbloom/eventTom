namespace eventTom.Api.DTO
{
    public class EventDTO
    {
        public long EventId { get; set; }
        public string Title { get; set; }
        public int AvailableTickets { get; set; }
        public double Price { get; set; }
    }
}
