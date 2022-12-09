using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations;

public class MovieConfiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.HasData(
                new Movie()
                {
                    Id=1,
                    Name = "Life",
                    Description = "This is the Life movie description",
                    Price = 39.50m,
                    ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                    StartDate = DateTime.Now.AddDays(-10),
                    EndDate = DateTime.Now.AddDays(10),
                    CinemaId = 3,
                    ProducerId = 3,
                    MovieCategory = MovieCategory.Documentary
                },
                new Movie()
                {
                    Id=2,
                    Name = "The Shawshank Redemption",
                    Description = "This is the Shawshank Redemption description",
                    Price = 29.50m,
                    ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(3),
                    CinemaId = 1,
                    ProducerId = 1,
                    MovieCategory = MovieCategory.Action
                },
                new Movie()
                {
                    Id=3,
                    Name = "Ghost",
                    Description = "This is the Ghost movie description",
                    Price = 39.50m,
                    ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(7),
                    CinemaId = 4,
                    ProducerId = 4,
                    MovieCategory = MovieCategory.Horror
                },
                new Movie()
                {
                    Id=4,
                    Name = "Race",
                    Description = "This is the Race movie description",
                    Price = 39.50m,
                    ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                    StartDate = DateTime.Now.AddDays(-10),
                    EndDate = DateTime.Now.AddDays(-5),
                    CinemaId = 1,
                    ProducerId = 2,
                    MovieCategory = MovieCategory.Documentary
                },
                new Movie()
                {
                    Id=5,
                    Name = "Scoob",
                    Description = "This is the Scoob movie description",
                    Price = 39.50m,
                    ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                    StartDate = DateTime.Now.AddDays(-10),
                    EndDate = DateTime.Now.AddDays(-2),
                    CinemaId = 1,
                    ProducerId = 3,
                    MovieCategory = MovieCategory.Cartoon
                },
                new Movie()
                {
                    Id=6,
                    Name = "Cold Soles",
                    Description = "This is the Cold Soles movie description",
                    Price = 39.50m,
                    ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                    StartDate = DateTime.Now.AddDays(3),
                    EndDate = DateTime.Now.AddDays(20),
                    CinemaId = 1,
                    ProducerId = 5,
                    MovieCategory = MovieCategory.Drama
                }
        );
    }
}