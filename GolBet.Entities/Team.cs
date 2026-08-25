using GolBet.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace GolBet.Entities;

public class Team : AuditableEntity

{
    [Required, MaxLength(80)]
    public string Name { get; set; } = null!;

    [Required, MaxLength(60)]
    public string City { get; set; } = null!;

    [MaxLength(300)]
    public string? CrestUrl { get; set; }

}
