using System.ComponentModel.DataAnnotations;

namespace Dog_Training_Records.Data;

public class DogFood
{
    [Required, MaxLength(50)]
    public string DogFoodName { get; set; } = default!;
    
    [Required, MaxLength(5)]
    public decimal DogFoodServing { get; set; } = default!;
}