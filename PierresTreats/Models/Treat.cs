using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresTreats.Models
{
  public class Treat
  {
    public int TreatId { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "You must add a treat to a flavor. Please create a flavor and try again.")]
    public int FlavorId { get; set; }

    [Required(ErrorMessage = "Treat must have a name.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Treat must have a description.")]
    public string Description { get; set; }
    public Flavor Flavor { get; set; }
    public List<TreatFlavor> JoinEntities { get; }
  }
}