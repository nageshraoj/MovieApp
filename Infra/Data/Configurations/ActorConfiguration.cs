using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations;

public class ActorConfiguration : IEntityTypeConfiguration<Actor>
{
    public void Configure(EntityTypeBuilder<Actor> builder)
    {
        builder.HasData(
                new Actor()
                {
                    Id = 1,
                    Name = "Actor 1",
                    Bio = "This is the Bio of the first actor",
                    ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                },
                new Actor()
                {
                    Id = 2,
                    Name = "Actor 2",
                    Bio = "This is the Bio of the second actor",
                    ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                },
                new Actor()
                {
                    Id = 3,
                    Name = "Actor 3",
                    Bio = "This is the Bio of the second actor",
                    ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                },
                new Actor()
                {
                    Id = 4,
                    Name = "Actor 4",
                    Bio = "This is the Bio of the second actor",
                    ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                },
                new Actor()
                {
                    Id = 5,
                    Name = "Actor 5",
                    Bio = "This is the Bio of the second actor",
                    ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                }
        );
    }
}