using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models;

public class Movie
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageURL { get; set; }

    public decimal Price { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public MovieCategory MovieCategory { get; set; }

    public List<MovieActor> MovieActors { get; set; }
    public int CinemaId { get; set; }
    [ForeignKey(nameof(CinemaId))]
    public Cinema Cinemas { get; set; }
    public int ProducerId { get; set; }
    [ForeignKey(nameof(ProducerId))]
    public Producer Producer { get; set; }

}