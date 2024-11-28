namespace eventTom.Api.Models
{
    public class Customer
    {
        public int Id { get; set; }              // Eindeutige Kunden-ID
        public string Name { get; set; }         // Name des Kunden
        public string Email { get; set; }        // E-Mail-Adresse des Kunden
        public List<Voucher> Vouchers { get; set; } = new List<Voucher>();  // Liste von Gutscheinen des Kunden
        public List<Ticket> Tickets { get; set; } = new List<Ticket>();     // Liste von Tickets, die der Kunde gekauft hat
    }
}
