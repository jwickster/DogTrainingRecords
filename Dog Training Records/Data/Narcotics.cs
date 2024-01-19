using System.ComponentModel.DataAnnotations;

namespace Dog_Training_Records.Data;

public class Narcotics
{
    //marijuana
    [Required]
    public bool Marijuana { get; set; }
    
    //cocaine
    [Required]
    public bool Cocaine { get; set; }
    
    //heroin
    [Required]
    public bool Heroin { get; set; }
    
    //meth
    [Required]
    public bool Meth { get; set; }
    
    //ecstasy
    [Required]
    public bool Ecstasy { get; set; }
}