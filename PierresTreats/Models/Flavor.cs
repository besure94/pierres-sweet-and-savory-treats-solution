using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }

    [Required(ErrorMessage = "Flavor must have a name.")]
    public string Name { get; set; }
    public List<TreatFlavor> JoinEntities { get; }
  }
}