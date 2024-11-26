namespace eventTom.Api.Models
{
    public class Customer
    {
        public long CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // Navigation Properties
        public ICollection<Voucher> Vouchers { get; set; } = new List<Voucher>();
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }

}
