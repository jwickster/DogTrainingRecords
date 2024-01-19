using System.ComponentModel.DataAnnotations;

namespace Dog_Training_Records.Data;

public class DogWeight
{
    //dog ideal weight
    [Required, MaxLength(5)]
    public decimal DogIdealWeight { get; set; } = default!;
    
    //dog actual weight
    [Required, MaxLength(5)]
    public decimal DogActualWeight { get; set; } = default!;
    
    //dog last weight
    [Required, MaxLength(5)]
    public decimal DogLastWeight { get; set; } = default!;
    
    //underweight?
    [Required]
    public bool DogUnderweight { get; set; }
    
    //overweight?
    [Required]
    public bool DogOverweight { get; set; }
    
    
    
    
    
    
}