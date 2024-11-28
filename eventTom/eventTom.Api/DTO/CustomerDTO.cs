namespace eventTom.Api.DTO
{
    public class CustomerDTO
    {
        public int Id { get; set; }              // Eindeutige Kunden-ID
        public string Name { get; set; }         // Name des Kunden
        public string Email { get; set; }        // E-Mail-Adresse des Kunden
        public List<VoucherDTO> Vouchers { get; set; } = new List<VoucherDTO>();  // Liste der Gutscheine des Kunden
        public List<TicketDTO> Tickets { get; set; } = new List<TicketDTO>();     // Liste der Tickets des Kunden
    }
}
