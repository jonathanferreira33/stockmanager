using Microsoft.EntityFrameworkCore;
using StockManager_API.Data;
using StockManager_API.Services;
using StockManager_API.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<MovementStockContext>(
    options => options
    .UseSqlServer("Data Source=DESKTOP-3CQKGCT\\SQLEXPRESS;Initial Catalog=DB001_STOCK;Integrated Security=False;User ID=admin;Password=admin123;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IMovementStockService, MovementStockService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
