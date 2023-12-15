using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresTreats.Models
{
  public class Treat
  {
    public int TreatId { get; set; }

    [Required(ErrorMessage = "Treat must have a name.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Treat must have a description.")]
    public string Description { get; set; }
    public List<TreatFlavor> JoinEntities { get; }
  }
}