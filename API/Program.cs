using API.Contracts;
using API.Repository;
using Core.Models;
using Infra;
using Infra.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

var connectionstring = builder.Configuration.GetConnectionString("DbConnection");

builder.Services.AddDbContext<MovieContext>(option => option.UseSqlServer(connectionstring));
builder.Services.AddIdentityCore<ApiUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<MovieContext>();

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IActorRepository, ActorRepository>();
builder.Services.AddScoped<IProducerRepository, ProducerRepository>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<ICinemaRepository, CinemaRepository>();

builder.Services.AddCors(p => p.AddPolicy("MovieClient", x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000")));

builder.Host.UseSerilog((ctx, cl) => cl.WriteTo.Console().ReadFrom.Configuration(ctx.Configuration));

// Add services to the container.

builder.Services.AddControllers();
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
app.UseCors("MovieClient");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
