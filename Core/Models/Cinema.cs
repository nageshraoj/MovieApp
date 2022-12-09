using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models;

public class Cinema
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Display(Name = "Cinema Name")]
    public string Name { get; set; }
    [Display(Name = "Description")]

    public string Description { get; set; }
    [Display(Name = "Logo")]

    public string Logo { get; set; }
    public List<Movie> Movies { get; set; }
}