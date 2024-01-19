using System.ComponentModel.DataAnnotations;

namespace Dog_Training_Records.Data;

public class DogWeight
{
    [Required, MaxLength(5)]
    public string? Tattoo { get; set; }
    
    [Required, MaxLength(50)]
    public string DogName { get; set; } = default!;
    
    [Required, MaxLength(100)]
    public string DogBreed { get; set; } = default!;
    
    [Required, DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime DogWhelpDateTime { get; set; }
    
    [Required, MaxLength(100)]
    public string DogFoodBrand { get; set; } = default!;
    
    [Required, MaxLength(100)]
    public string DogFoodType { get; set; } = default!;
    
    [Required, MaxLength(100)]
    public string DogFoodAmount { get; set; } = default!;
    
    
    
    
    
    
}