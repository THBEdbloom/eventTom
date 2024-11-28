using Microsoft.EntityFrameworkCore;

namespace eventTom.Api.Models.dataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Event> Events { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
