﻿namespace eventTom.Api.Models
{
    public class Voucher
    {
        public int VoucherId { get; set; }       // Eindeutige Gutschein-ID
        public long Amount { get; set; }      // Betrag des Gutscheins
        public DateTime ValidUntil { get; set; } // Gültigkeitsdatum des Gutscheins
        public int CustomerId { get; set; }      // Kunden-ID, dem der Gutschein gehört
        public Customer Customer { get; set; }   // Navigation Property zum Customer
    }
}
