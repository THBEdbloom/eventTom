namespace eventTom.Api.Models
{
    public class Voucher
    {
        public long VoucherId { get; set; }
        public double Amount { get; set; }
        public DateTime ValidUntil { get; set; }

        // Navigation Property
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
    }

}
