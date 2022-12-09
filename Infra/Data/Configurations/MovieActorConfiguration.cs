using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Configurations;

public class MovieActorConfiguration : IEntityTypeConfiguration<MovieActor>
{
    public void Configure(EntityTypeBuilder<MovieActor> builder)
    {
        builder.HasData(
                    new MovieActor()
                    {
                        ActorId = 1,
                        MovieId = 1
                    },
                        new MovieActor()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new MovieActor()
                         {
                             ActorId = 1,
                             MovieId = 2
                         },
                         new MovieActor()
                         {
                             ActorId = 4,
                             MovieId = 2
                         },

                        new MovieActor()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new MovieActor()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new MovieActor()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new MovieActor()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new MovieActor()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new MovieActor()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new MovieActor()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new MovieActor()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new MovieActor()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new MovieActor()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new MovieActor()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new MovieActor()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new MovieActor()
                        {
                            ActorId = 5,
                            MovieId = 6
                        }
        );
    }
}