namespace eventTom.Api.DTO
{
    public class TicketDTO
    {
        public int TicketId { get; set; }        // Eindeutige Ticket-ID
        public long FinalPrice { get; set; }  // Endpreis des Tickets
        public DateTime PurchaseDate { get; set; } // Kaufdatum des Tickets
        public bool Used { get; set; }           // Status, ob das Ticket verwendet wurde
        public int EventId { get; set; }         // Event-ID, mit dem das Ticket verknüpft ist
        public int CustomerId { get; set; }      // Kunden-ID, der das Ticket gekauft hat
    }
}
