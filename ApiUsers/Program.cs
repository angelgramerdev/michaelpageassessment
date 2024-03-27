using Application.Interfaces;
using Application.Services;
using Domain;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infraestructure.Context;
using Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
string connectionString=builder.Configuration.GetConnectionString("conexionSql");
builder.Services.AddDbContext<UserContext>(opt => opt.UseSqlServer(connectionString));
builder.Services.AddScoped<IServiceUser, ServiceUser>();
builder.Services.AddScoped<IBaseRepository<User>, UserRepository>();
builder.Services.AddScoped<ObjResponse>();
builder.Services.AddMvc();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
