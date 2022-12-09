using Core.Models;
using Infra.Data.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data;

public class MovieContext : IdentityDbContext<ApiUser>
{
    public MovieContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Actor> Actors { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<MovieActor> MovieActors { get; set; }
    public DbSet<Producer> Producers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<MovieActor>().HasKey(p => new
        {
            p.ActorId,
            p.MovieId
        });
        modelBuilder.Entity<MovieActor>().HasOne(p => p.Actor).WithMany(q => q.MovieActors).HasForeignKey(f => f.ActorId);
        modelBuilder.Entity<MovieActor>().HasOne(p => p.Movie).WithMany(q => q.MovieActors).HasForeignKey(f => f.MovieId);
        modelBuilder.ApplyConfiguration(new ActorConfiguration());
        modelBuilder.ApplyConfiguration(new CinemaConfiguration());
        modelBuilder.ApplyConfiguration(new ProducerConfiguratoin());
        modelBuilder.ApplyConfiguration(new MovieConfiguration());
        modelBuilder.ApplyConfiguration(new MovieActorConfiguration());
        modelBuilder.ApplyConfiguration(new RoleConfiguration());
    }
}