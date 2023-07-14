using BE_Veterinaria.Models;
using BE_Veterinaria.Models.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// CORS

builder.Services.AddCors(options => options.AddPolicy(
    "AllowWebapp",
     builder => builder.AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod()));


// ADD CONTEXT

builder.Services.AddDbContext<AplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Conexion"));
});

// AUTOMAPPER

builder.Services.AddAutoMapper(typeof(Program));

// ADD SERVICES

builder.Services.AddScoped<IMascotaRepository, MascotaRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowWebapp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
