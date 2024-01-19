using System.ComponentModel.DataAnnotations;

namespace Dog_Training_Records.Models;

public class DogInfo
{
    [Required, MaxLength(100)]
    public string DogName { get; set; } = default!;
    
    [Required, MaxLength(100)]
    public string DogBreed { get; set; } = default!;
    
    [Required, DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime DogArrivedOnStation { get; set; }
    
    [Required, DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime DogWhelpDateTime { get; set; }
    
    [Required, MaxLength(1)]
    public string DogCATStatus { get; set; } = default!;
    
    //bool is dog deployable
    [Required]
    public bool DogDeployable { get; set; }
    
    //dog last physical date
    [Required, DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime DogLastPhysical { get; set; }
    
    //dog last dental date
    [Required, DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime DogLastDental { get; set; }
    
    
    //dog tattoo
    [Required, MaxLength(5)]
    public string? Tattoo { get; set; }
    
    //dog certificaton date
    [Required, DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime DateCertified { get; set; }
    
    //dog validation date
    [Required, DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime DateValidated { get; set; }
    
    //is the dog certified?
    [Required]
    public bool DogCertified { get; set; }
    
    //is the dog validated?
    [Required]
    public bool DogValidated { get; set; }
}