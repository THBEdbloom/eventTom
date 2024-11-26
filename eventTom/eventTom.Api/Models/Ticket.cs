namespace eventTom.Api.Models
{
    public class Ticket
    {
        public long TicketId { get; set; }
        public double FinalPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public bool Used { get; set; }
        public string TicketNumber { get; set; }

        // Navigation Properties
        public long EventId { get; set; }
        public Event Event { get; set; }

        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
