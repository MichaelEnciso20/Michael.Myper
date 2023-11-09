using Michael.Myper.Application.Interface;
using Michael.Myper.Application.Main;
using Michael.Myper.Domain.Core;
using Michael.Myper.Domain.Interface;
using Michael.Myper.infrastructure.Date;
using Michael.Myper.infrastructure.Interface;
using Michael.Myper.infrastructure.Repository;
using Michael.Myper.Trasversal.Mapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Configuración de AutoMapper
builder.Services.AddAutoMapper(typeof(MappingsProfile));


builder.Services.AddDbContext<TrabajadoresPruebaContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection")));

// Configuración de ICustomersApplication
builder.Services.AddScoped<ITrabajadoreApplication, TrabajadoreApplication>();

// Configuración de ICustomersDomain
builder.Services.AddScoped<ITrabajadoreDomain, TrabajadoreDomain>();

// Configuración de ICustomersRepository
builder.Services.AddScoped<ITrabajadoreRepository, TrabajadoreRepository>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
