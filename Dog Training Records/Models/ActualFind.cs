using System.ComponentModel.DataAnnotations;

namespace Dog_Training_Records.Data;

public class ActualFind
{
    [Required, MaxLength(100)]
    string Location { get; set; } = default!;
}