using System.ComponentModel.DataAnnotations;

namespace Dog_Training_Records.Data;

public class HandlerInfo
{
    //handler name
    [Required, MaxLength(100)]
    public string HandlerFirstName { get; set; } = default!;
    
    [Required, MaxLength(100)]
    public string HandlerLastName { get; set; } = default!;
    
    [Required, MaxLength(100)]
    public string HandlerPhone { get; set; } = default!;
    
    [Required, MaxLength(100)]
    public string HandlerEmail { get; set; } = default!;
    
    //Date graduated Handler Course
    [Required, DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime DateGraduated { get; set; }
    
    //handler rank
    [Required, MaxLength(10)]
    public string HandlerRank { get; set; } = default!;
    
}