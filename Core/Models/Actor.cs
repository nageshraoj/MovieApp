using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models;

public class Actor
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Display(Name = "Actor Name")]
    public string Name { get; set; }
    [Display(Name = "Biograpy")]

    public string Bio { get; set; }
    [Display(Name = "Profile Picture")]

    public string ProfilePictureURL { get; set; }
    public List<MovieActor> MovieActors { get; set; }
}