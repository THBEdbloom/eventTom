using eventTom.Api.Models.dataContext;
using eventTom.Api.Services.interfaces;
using eventTom.Api.Services;
using Microsoft.EntityFrameworkCore;
using eventTom.Api.Repositories.interfaces;
using eventTom.Api.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Füge die Controller-Dienste hinzu
builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddScoped<IEventService, EventService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ITicketService, TicketService>();

// Add repositories to the container.
builder.Services.AddScoped<IEventRepository, EventRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ITicketRepository, TicketRepository>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

var app = builder.Build();

// API-Routing aktivieren
app.MapControllers();  // Wichtig, damit die Controller richtig geroutet werden

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.Run();
