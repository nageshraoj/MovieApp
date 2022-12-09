using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models;

public class Producer
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Display(Name = "Name")]
    public string Name { get; set; }
    [Display(Name = "Biography")]
    public string Bio { get; set; }
    [Display(Name = "Profile Picture")]
    public string ProfilePictureURL { get; set; }
    public List<Movie> Movies { get; set; }
}