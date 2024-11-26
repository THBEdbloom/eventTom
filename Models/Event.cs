namespace eventTom.Api.Models
{
    public class Event
    {
        public long EventId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int TotalTickets { get; set; }
        public int SoldTickets { get; set; }
        public int ThresholdValue { get; set; }
        public double BasePrice { get; set; }
    }
}
