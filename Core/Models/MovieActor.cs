using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models;

public class MovieActor
{
    public int ActorId { get; set; }
    public int MovieId { get; set; }
    [ForeignKey(nameof(ActorId))]
    public Actor Actor { get; set; }
    [ForeignKey(nameof(MovieId))]
    public Movie Movie { get; set; }
}