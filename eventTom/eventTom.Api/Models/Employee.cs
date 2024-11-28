namespace eventTom.Api.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }      // Eindeutige Mitarbeiter-ID
        public string Position { get; set; }     // Position des Mitarbeiters (z. B. Eventmanager, Eventcreator)
        public string Name { get; set; }         // Name des Mitarbeiters
        public string Email { get; set; }        // E-Mail-Adresse des Mitarbeiters
    }
}
