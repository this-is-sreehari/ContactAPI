using ContactAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// To use in memory database 
//builder.Services.AddDbContext<ContactAPIdbcontext>(options => options.UseInMemoryDatabase("ContactsDb"));


//Connecting to SQL Server
builder.Services.AddDbContext<ContactAPIdbcontext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("ContactsApiConnectionString")));

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
