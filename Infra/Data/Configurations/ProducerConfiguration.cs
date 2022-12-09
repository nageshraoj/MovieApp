using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations;

public class ProducerConfiguratoin : IEntityTypeConfiguration<Producer>
{
    public void Configure(EntityTypeBuilder<Producer> builder)
    {
        builder.HasData(
            new Producer()
            {
                Id = 1,
                Name = "Producer 1",
                Bio = "This is the Bio of the first actor",
                ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

            },
            new Producer()
            {
                Id = 2,
                Name = "Producer 2",
                Bio = "This is the Bio of the second actor",
                ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
            },
            new Producer()
            {
                Id = 3,
                Name = "Producer 3",
                Bio = "This is the Bio of the second actor",
                ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
            },
            new Producer()
            {
                Id = 4,
                Name = "Producer 4",
                Bio = "This is the Bio of the second actor",
                ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
            },
            new Producer()
            {
                Id = 5,
                Name = "Producer 5",
                Bio = "This is the Bio of the second actor",
                ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
            }
        );
    }
}