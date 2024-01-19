using System.ComponentModel.DataAnnotations;

namespace Dog_Training_Records.Data;

public class Explosives
{
    //C4
    [Required]
    public bool C4 { get; set; }
    
    //TNT
    [Required]
    public bool TNT { get; set; }
    
    //Potassium Chlorate
    [Required]
    public bool PotassiumChlorate { get; set; }
    
    //Sodium Chlorate
    [Required]
    public bool SodiumChlorate { get; set; }
    
    //Det Cord
    [Required]
    public bool DetCord { get; set; }
    
    //nitroglycerin
    [Required]
    public bool Nitroglycerin { get; set; }
    
   
}