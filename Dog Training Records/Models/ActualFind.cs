using System.ComponentModel.DataAnnotations;

namespace Dog_Training_Records.Models;

public class ActualFind
{
    [Required, MaxLength(100)]
    string Location { get; set; } = default!;
}