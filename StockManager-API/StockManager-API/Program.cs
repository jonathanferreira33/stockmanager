using Microsoft.EntityFrameworkCore;
using StockManager_API.Data;
using StockManager_API.Services;
using StockManager_API.Services.Interfaces;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddDbContext<AppDbContext>(
//    options => options
//    .UseSqlServer(builder.Configuration
//    .GetConnectionString("StockManagerDatabaseCS")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


string mySqlConnection = builder.Configuration.GetConnectionString("StockManagerDatabaseCS");

builder.Services.AddDbContextPool<AppDbContext>(options =>
                options.UseMySql(mySqlConnection,
                      ServerVersion.AutoDetect(mySqlConnection)));

builder.Services.AddDbContext<AppDbContext>(options => options. UseMySQL(builder.Configuration.GetConnectionString("StockManagerDatabaseCS")));


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
