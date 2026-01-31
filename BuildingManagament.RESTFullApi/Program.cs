using BuildingManagament.Application.Interfaces;
using BuildingManagament.Application.Services;
using BuildingManagament.Persistence.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BuildingManagamentDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BuildingManagamentDb")));

builder.Services.AddScoped<IBuildingServices, BuildingServices>();
builder.Services.AddScoped<IDuePlanServices, DuePlanServices>();

// Add services to the container.
builder.Services.AddControllers();
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
