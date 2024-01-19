using System.ComponentModel.DataAnnotations;

namespace Dog_Training_Records.Data;

public class DogTrainingConditions
{
    [Required, DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime DogTrainingDate { get; set; }
    
    [Required, DisplayFormat(DataFormatString = "{0:HH:mm}")]
    public DateTime DogTrainingStartTime { get; set; }
    
    [Required, DisplayFormat(DataFormatString = "{0:HH:mm}")]
    public DateTime DogTrainingEndTime { get; set; }
    
    [Required, MaxLength(10)]
    public int StartAmbientTemperature { get; set; }
    
    [Required, MaxLength(10)]
    public int EndAmbientTemperature { get; set; }
    
    [Required, MaxLength(10)]
    public int StartHumidity { get; set; }
    
    [Required, MaxLength(10)]
    public int EndHumidity { get; set; }
    
    [MaxLength(5)]
    public char? WindDirection { get; set; }
    
    
}