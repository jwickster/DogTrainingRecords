using System.ComponentModel.DataAnnotations;

namespace Dog_Training_Records.Data;

public class DogTrainingConditions
{
    [Required, DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime TrainingDate { get; set; }
    
    [Required, DisplayFormat(DataFormatString = "{0:HH:mm}")]
    public DateTime TrainingStartTime { get; set; }
    
    [Required, DisplayFormat(DataFormatString = "{0:HH:mm}")]
    public DateTime TrainingEndTime { get; set; }
    
    [Required, MaxLength(10)]
    public int StartTemperature { get; set; }
    
    [Required, MaxLength(10)]
    public int EndTemperature { get; set; }
    
    [Required, MaxLength(10)]
    public int StartHumidity { get; set; }
    
    [Required, MaxLength(10)]
    public int EndHumidity { get; set; }
    
    [MaxLength(5)]
    public char? WindDirection { get; set; }
    
    
}