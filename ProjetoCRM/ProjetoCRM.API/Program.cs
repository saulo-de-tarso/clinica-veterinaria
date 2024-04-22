global using Microsoft.EntityFrameworkCore;
using ProjetoCRM.API.Services.ClientesService;
using ProjetoCRM.API.Data;
using ProjetoCRM.API.Models;
using System;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Builde para registrar o automapper
builder.Services.AddAutoMapper(typeof(Program).Assembly);

// Builder para registrar o cliente de serviços no programa
builder.Services.AddScoped<IClientesService, ClientesService>();

//Builder para conexão do SQL com plataforma azure

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING")));


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
