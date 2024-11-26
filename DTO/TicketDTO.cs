namespace eventTom.Api.DTO
{
    public class TicketDTO
    {
        public long TicketId { get; set; }
        public string EventTitle { get; set; }
        public string OwnerName { get; set; }
        public double FinalPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string TicketNumber { get; set; }
    }

}
