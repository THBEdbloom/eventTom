namespace eventTom.Api.Models
{
    public class Event
    {
        public int Id { get; set; }               // Eindeutige Event-ID
        public string Title { get; set; }         // Titel des Events
        public DateTime Date { get; set; }        // Datum des Events
        public int TotalTickets { get; set; }     // Gesamtzahl der verfügbaren Tickets
        public int SoldTickets { get; set; }      // Anzahl der bereits verkauften Tickets
        public long ThresholdValue { get; set; } // Schwellwert für die Anzahl verkaufter Tickets
        public long BasePrice { get; set; }    // Basispreis des Tickets
        public List<Ticket> Tickets { get; set; } = new List<Ticket>(); // Liste der Tickets, die mit dem Event verknüpft sind
    }
}
